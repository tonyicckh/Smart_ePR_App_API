using ePR_App_Api.Data;
using ePR_App_Api.Models;
using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Register the DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Register AppCoreContext as scoped (it depends on IHttpContextAccessor & IConfiguration)
builder.Services.AddScoped<AppCoreContext>();
// Register Active Directory service
builder.Services.AddScoped<AdService>();
// Register TokenService
builder.Services.AddSingleton<TokenService>();
builder.Services.AddAuthorization();

// Add CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFlutterApp",
        policy => policy
            .WithOrigins("http://localhost", "http://10.0.2.2", "http://127.0.0.1")
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials());
});


// Read key path from configuration
var serviceAccountPath = builder.Configuration["Firebase:ServiceAccountKeyPath"];

// Initialize Firebase Admin SDK
FirebaseApp.Create(new AppOptions()
{
    Credential = GoogleCredential.FromFile(serviceAccountPath)
});

// Add IHttpContextAccessor (required by AppCoreContext)
builder.Services.AddHttpContextAccessor();

builder.Services.AddControllers();

// Swagger configuration
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
// Use CORS before Authentication and Authorization
app.UseCors("AllowFlutterApp");
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
