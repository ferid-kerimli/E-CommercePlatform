using NotificationService.Services;
using NotificationService.Settings;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Bind the NotificationSettings configuration to the appsettings.json file.		
builder.Services.Configure<NotificationSettings>(builder.Configuration);
// Add the NotificationSender service to the container.
builder.Services.AddScoped<NotificationSender>();
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();