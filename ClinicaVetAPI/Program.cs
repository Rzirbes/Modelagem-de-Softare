using AutoMapper;
using ClinicaVetAPI.Data;
using ClinicaVetAPI.Interfaces;
using ClinicaVetAPI.Interfaces.Repositories;
using ClinicaVetAPI.Models;
using ClinicaVetAPI.Repositories;
using ClinicaVetAPI.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=clinicaVet.db"));

builder.Services.AddSingleton(provider =>
{
    var config = new MapperConfiguration(cfg =>
    {
        cfg.AddProfile(new ClinicaVetAPI.Mappings.AutoMapperProfile());
    });

    return config.CreateMapper();
});

builder.Services.AddScoped<IBaseService<Tutor>, TutorService>();
builder.Services.AddScoped<IBaseService<Pet>, PetService>();
builder.Services.AddScoped<ITutorRepository, TutorRepository>();
builder.Services.AddScoped<IPetRepository, PetRepository>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new() { Title = "Clínica Veterinária API", Version = "v1" });

    var xmlFile = $"{System.Reflection.Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    options.IncludeXmlComments(xmlPath, includeControllerXmlComments: true);
});

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    db.Database.Migrate();
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "Clínica Veterinária API v1");
        options.RoutePrefix = string.Empty;
    });
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();
