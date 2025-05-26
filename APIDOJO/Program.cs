using APIDOJO.Interfaces;
using APIDOJO.Models;
using APIDOJO.Services;

var builder = WebApplication.CreateBuilder(args);

//adicionando Serviço no Container de DI

builder.Services.AddSingleton<ILivroService, LivroService>();
builder.Services.AddSingleton<IAutorService, AutorService>();
builder.Services.AddControllers();


// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapControllers();


app.Run();
