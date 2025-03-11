using API_REVISAO.Models;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDataContext>();
var app = builder.Build();

app.MapGet("/", () => "Revisao de Wer API e EF");

app.MapPost("/api/produto/cadastrar", ([FromBody] Produto produto,
[FromServices] AppDataContext ctx) => 
{
    ctx.Produtos.Add(produto);
    ctx.SaveChanges();
    return Results.Created("", produto);
});

app.MapGet("/api/produto/listar", ([FromServices] AppDataContext ctx) => 
{
    return Results.Ok(ctx.Produtos.ToList());
});

app.Run();
