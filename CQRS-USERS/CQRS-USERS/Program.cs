using CQRS_USERS.Domain.Commands.Requests;
using CQRS_USERS.Domain.Handlers;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<ICreateCustomerHandler, CreateCustomerHandler>();
builder.Services.AddTransient<IFindCustomerByIdHandler, FindCustomerByIdHandler>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();

app.MapPost("/create-customer", ([FromServices] ICreateCustomerHandler handler, [FromBody] CreateCustomerRequest command) =>
{
    return handler.Handle(command);
})
.WithTags("Customer Create");

app.MapGet("/get-user-by-id/{id}", ([FromServices] IFindCustomerByIdHandler handler) =>
{
    var command = new FindCustomerByIdRequest { Id = Guid.NewGuid() };
    return handler.Handle(command);
})
.WithTags("Getting user by Id");

app.Run();