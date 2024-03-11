using DatabaseService.DI;
using DatabaseService.Services;

var builder = WebApplication.CreateBuilder(args);

// Add the appsettings.json file to the configuration.
builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

var connectionString = builder.Configuration.GetConnectionString("PostgreSqlConnection");

builder.Services.AddDatabaseServices(connectionString);

// Add AutoMapper
builder.Services.AddAutoMapper(typeof(Program).Assembly);

// Add services to the container.
builder.Services.AddGrpc();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapGrpcService<GreeterService>();
app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.MapGrpcService<LinkService>();
app.MapGrpcService<ClickService>();

app.Run();
