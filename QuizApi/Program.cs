using Microsoft.EntityFrameworkCore;
using QuizApi.Domain.IRepositories;
using QuizApi.Domain.IServices;
using QuizApi.Persistence.Context;
using QuizApi.Persistence.Repositories;
using QuizApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("Conexion");
builder.Services.AddDbContext<AplicationDbContext>(options => options.UseSqlServer(connectionString));
// Services
builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<ILoginService, LoginService>();
// Repositories
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<ILoginRepository, LoginRepository>();
// Cors
builder.Services.AddCors(options => options.AddPolicy("AllowWebapp", 
    builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("AllowWebapp");

app.UseAuthorization();

app.MapControllers();

app.Run();
