using _2.Data.DbContexts;
using _2.Data.IRepositories;
using _2.Data.Repositories;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped(typeof(IAllRepositories<>), typeof(AllRepositories<>));
builder.Services.AddDbContext<DoAnNhanhDbContext>(c => c.UseSqlServer("Server=.;Database=Net106Database;Trusted_Connection=True;"));

builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy", builder => builder
    .SetIsOriginAllowed((host) => true)
    .AllowAnyMethod()
    .AllowAnyHeader()
    .AllowCredentials());

});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("CorsPolicy");
app.UseAuthorization();

app.MapControllers();

app.Run();
