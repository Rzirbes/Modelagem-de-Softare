using ClinicaVetAPI.Data;
using ClinicaVetAPI.Interfaces;
using ClinicaVetAPI.Interfaces.Repositories;
using ClinicaVetAPI.Models;
using ClinicaVetAPI.Repositories;
using ClinicaVetAPI.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlite("Data Source=clinicaVet.db"));

builder.Services.AddScoped<IBaseService<Tutor>, TutorService>();
builder.Services.AddScoped<IBaseService<Pet>, PetService>();
builder.Services.AddScoped<ITutorRepository, TutorRepository>();
builder.Services.AddScoped<IPetRepository, PetRepository>();
builder.Services.AddControllers();

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    db.Database.Migrate();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();



app.Run();

