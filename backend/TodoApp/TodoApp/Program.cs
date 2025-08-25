using TodoApp.Application;
using TodoApp.Domain;
using TodoApp.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddSingleton<ITodoRepository, InMemoryTodoRepository>();
builder.Services.AddSingleton<TodoService>();
builder.Services.AddCors(options =>
{
    // DO NOT USE THIS IN PRODUCTION - FOR DEMO PURPOSES ONLY
    options.AddPolicy("AllowAny",
        policy => policy
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseCors("AllowAny");
// app.UseHttpsRedirection();

app.SetupMinimalApi();

app.Run();
namespace TodoApp
{
    public partial class Program { }
}