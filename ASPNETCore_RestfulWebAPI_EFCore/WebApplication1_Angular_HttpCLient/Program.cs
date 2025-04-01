using Microsoft.EntityFrameworkCore;
using WebApplication1_Angular_HttpCLient.Contexts;

var builder = WebApplication.CreateBuilder(args);

// Configure DbContext with SQL Server
builder.Services.AddDbContext<MyDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("sqlconstr")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//If API and Angular runs on different server then use CORS
builder.Services.AddCors((options) =>
{
    options.AddPolicy("myCors", policy =>
    {
        policy.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//add above used CORS name
app.UseCors("myCors");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
