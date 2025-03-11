using API_REVISAO.Models;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Revisao de Wer API e EF");

app.MapPost("/api/produto/cadastrar", ([FromBody] Produto produto) => 
{
    return produto;
});

app.Run();
