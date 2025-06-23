using Microsoft.EntityFrameworkCore;
using RareDiseasesAPI.Data;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// ✅ 1. Configure Services

// Enable CORS (Allow All Origins - for development)
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

// Add Controllers
builder.Services.AddControllers();

// Add Database Context (using SQLite)
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add Swagger/OpenAPI Support
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Rare Diseases API", Version = "v1" });
});

var app = builder.Build();

// ✅ 2. Configure Middleware

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();

    // 🔥 Smart HTTPS Redirection inside Development
    try
    {
        app.UseHttpsRedirection();
    }
    catch (Exception ex)
    {
        Console.WriteLine("⚠️ HTTPS Redirection Failed: " + ex.Message);
        Console.WriteLine("✅ Continuing without HTTPS redirection in Development mode.");
    }

    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Rare Diseases API v1");
    });
}
else
{
    app.UseHttpsRedirection();
}

// ✅ Seeding database (Add diseases if not exist)
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    db.Database.EnsureCreated(); // يتأكد إن الداتابيز موجودة
    DataSeeder.Seed(db); // يحط الأمراض
}

// Static Files for Frontend
app.UseDefaultFiles(); // لو فتحت http://localhost:5057/ يفتح index.html
app.UseStaticFiles();

// Core Middlewares
app.UseRouting();
app.UseCors("AllowAll");
app.UseAuthorization();

// Map Controllers
app.MapControllers();

// Run Application
app.Run();
