using MediatR;
using FluentValidation;
using Api.Modules;
using Application.Authors.Queries;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMediatR(cfg =>
    cfg.RegisterServicesFromAssemblies(
        typeof(Program).Assembly,
        typeof(GetAllAuthorsQueryHandler).Assembly
    ));

builder.Services.AddValidatorsFromAssembly(typeof(Program).Assembly);

// services
builder.Services.AddBookModule();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();