using Shiko.PopularCourses.Api.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddControllers();
builder.Services.AddSingleton<PopularCourseService>();

var app = builder.Build();

app.MapOpenApi();

app.MapControllers();

app.Run();