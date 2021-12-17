using MinimalAPi1;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddScoped<IMyService, MyService>()
    .AddControllers()
    ;
builder.Logging
    .ClearProviders()
    .AddConsole()
    ;

var app = builder.Build();

app.Logger.LogInformation("Starting...");

app.MapGet("/", () => "Try out the /Home route!");

app.MapControllers();


app.Run();

