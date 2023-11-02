using Domain;
using Domain.Entities;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Service;
using Domain.Services;
using Infraestructura.SqlServer.Lape_DbContext;
using Infraestructura.SqlServer.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

#region Inyeccion de dependencias
builder.Services.AddScoped<IUnidadMedidaRepository, UnidadMedidaRepository>();
builder.Services.AddScoped<IUnidadMedidaService, UnidadMedidaService>();


builder.Services.AddScoped<ICantidadRepository, CantidadRespository>();
builder.Services.AddScoped<ICantidadService, CantidadService>();


builder.Services.AddScoped<IFloracionRepository, FloracionRepository>();
builder.Services.AddScoped<IFloracionService, FloracionService>();


builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
builder.Services.AddScoped<IClienteService, ClienteService>();


builder.Services.AddScoped<IProveedorRepository, ProveedorRepository>();
builder.Services.AddScoped<IProveedorService, ProveedorService>();

builder.Services.AddScoped<IProductoRepository, ProductoRepository>();
builder.Services.AddScoped<IProductoService, ProductoService>();


builder.Services.AddScoped<IMaestroRepository, MaestroRepository>();
builder.Services.AddScoped<IDetalleRepository, DetalleRepository>();
builder.Services.AddScoped<IVentasService, VentasService>();


builder.Services.AddScoped<IStockRepository,  StockRepository>();
builder.Services.AddScoped<IStockService, StockService>();


#endregion

//Connection EntityFramework
builder.Services.AddDbContext<LapeDbContext>(opt => opt.UseSqlServer("name=DefaultConnection"));

//autommaper
builder.Services.AddAutoMapper(typeof(AutoMapperMappingProfile));



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//CORS
builder.Services.AddCors(options => {
    options.AddPolicy("pruebaTecnica", app =>
    {
        app.AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod();
    });

});

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
