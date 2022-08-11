using Microsoft.EntityFrameworkCore;
using RazorWebApp.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container. Extract and use w/ help of dependency injection
builder.Services.AddRazorPages();
builder.Services.AddDbContext<ApplicationDbContext>(options=>options.UseSqlServer( // Add DbContext as a service
        // GetConnectionString looks for keyname in appsettings.json
        builder.Configuration.GetConnectionString("DefaultConnection")
    ));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
