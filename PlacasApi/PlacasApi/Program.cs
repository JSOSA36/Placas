using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Placas.DataAccess.Data;
using Placas.DataAccess.Repository;
using Placas.DataAccess.Servicios;
using Placas.Entities.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<PlacasContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DbPlaca"));
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);

});

builder.Services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
builder.Services.AddScoped<IUsuarios, UsuariosServices>();
builder.Services.AddScoped<IVehiculos, VehiculosServices>();
builder.Services.AddScoped<ITipoPersona, TipoPersonaServices>();
builder.Services.AddScoped<IClientes, ClientesServices>();
builder.Services.AddScoped<ITipoPlaca, TipoPlacasServices>();
builder.Services.AddScoped<ITipoVehiculos, TipoVehiculosServices>();
builder.Services.AddScoped<IPlacas, PlacasServices>();



builder.Services.AddAutoMapper(typeof(Program).Assembly);


//LoadData load = new LoadData();
//load.CartTipoPlacas();
//load.CargarTipoVehiculos();
//load.CargarDatosPersona();


builder.Services.AddControllersWithViews()
    .AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);


builder.Services.AddCors(options =>
{
    options.AddPolicy("PolicyConfig",
                      policy =>
                      {
                          policy.AllowAnyOrigin().
                           AllowAnyHeader()
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


app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseCors("PolicyConfig");
app.UseAuthorization();
app.UseHttpsRedirection();

app.MapControllers();

app.Run();







