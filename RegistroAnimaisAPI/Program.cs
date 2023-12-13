using Microsoft.EntityFrameworkCore;
using RegistroAnimaisAPI.Data;
using RegistroAnimaisAPI.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql("server=localhost;initial catalog=REGISTRO_ANIMAIS_API;uid=developer;pwd=123456",
        ServerVersion.Parse("8.0.34-mysql")));

// Add services to the container.
builder.Services.AddScoped<AnimalService>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
