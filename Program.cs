using Microsoft.EntityFrameworkCore;
using MiPrimeraApi.Data;
using MiPrimeraApi.Repositories;
using MiPrimeraApi.Services;
using MiPrimeraApi.ExternalServices; // 👈 Asegúrate de importar el namespace correcto

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); // ¡ESTA ES LA FORMA CORRECTA!

// 👇 Registra tu DbContext aquí, usando la cadena de conexión de appsettings.json
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// 👇 Registra tus repositorios y servicios internos
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();

// 👇 REGISTRA EL SERVICIO EXTERNO (lo que te hacía falta)
builder.Services.AddHttpClient<ExternalUserService>();

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
