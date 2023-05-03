using Microsoft.EntityFrameworkCore;
using SuperZapatos.Application.Interfaces;
using SuperZapatos.Application.Services;
using SuperZapatos.Infraestructure;
using SuperZapatos.Infraestructure.Interfaces;
using SuperZapatos.Infraestructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IArticlesRepository,ArticlesRepository>();
builder.Services.AddScoped<IStoreRepository, StoreRepository>();
builder.Services.AddScoped<IArticlesApplication, ArticlesApplication>();
builder.Services.AddScoped<IStoreApplication, StoreApplication>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDBContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("conexionBD")));
builder.Services.AddCors(options => options.AddPolicy("Todos", builder => {
    builder.AllowAnyHeader();
    builder.AllowAnyMethod();
    builder.AllowAnyOrigin();
})
);
var app = builder.Build();

//using (var scope=app.Services.CreateScope())
//{
//    var context=scope.ServiceProvider.GetRequiredService<AppDBContext>();
//    context.Database.Migrate();
//}

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
