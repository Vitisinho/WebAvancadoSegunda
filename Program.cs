var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Revisao de Wer API e EF");

app.MapPost

app.Run();
