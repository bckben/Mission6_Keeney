using Microsoft.EntityFrameworkCore;
using Mission6_Keeney.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add Entity Framework Core and SQLite connection
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // In development, show detailed errors and disable HTTPS redirection
    app.UseDeveloperExceptionPage();
    app.UseHttpsRedirection(); // You can disable this line if you don't need HTTPS locally
}
else
{
    // In production, use HTTPS redirection and exception handling
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection(); // Ensure HTTPS redirection is active (optional in development)
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();