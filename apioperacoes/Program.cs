var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseUrls("http://localhost:8000");

var app = builder.Build();

app.MapGet("/", () => "Calcúlos com 10 e 5");

app.MapGet("/soma", () => new {mensagem= 10+5 });
app.MapGet("/subtracao", () => new {mensagem= 10-5 });
app.MapGet("/multiplicacao", () => new {mensagem= 10*5 });
app.MapGet("/divisao", () => new {mensagem= 10/5 });
app.MapGet("/soma/{a}/{b}", (int a, int b) => a + b);
app.MapGet("/subtracao/{a}/{b}", (int a, int b) => a - b);
app.MapGet("/multiplicacao/{a}/{b}", (int a, int b) => a * b);
app.MapGet("/divisao/{a}/{b}", (int a, int b) => a / b);

app.Run();