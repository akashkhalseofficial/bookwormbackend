using bookwormbackend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using bookwormbackend.Controllers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<BookwormDbContext>(
    o => o.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("corsapp");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapUserDataEndpoints();

app.MapOrdersEndpoints();

app.MapBooksEndpoints();

app.MapUserCredsEndpoints();

app.MapBooksRentedEndpoints();

app.MapBooksPurchasedEndpoints();

app.MapInvoicesEndpoints();

app.MapUserShelfEndpoints();

app.Run();
