using SvtRoboticsLoaderApi.Clients;
using SvtRoboticsLoaderApi.Processors;
using SvtRoboticsLoaderApi.Processors.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddHttpClient<IRobotService, RobotService>(c => c.BaseAddress = new Uri("https://60c8ed887dafc90017ffbd56.mockapi.io/"));
builder.Services.AddTransient<ILoadProcessor, LoadProcessor>();

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
