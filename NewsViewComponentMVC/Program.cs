using Microsoft.EntityFrameworkCore;
using NewsViewComponentMVC.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<NewsDbContext>(c => c.UseSqlServer(builder.Configuration.GetConnectionString("NewsDbCnn")));
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();


var app = builder.Build();
app.MapDefaultControllerRoute();
app.MapRazorPages();

app.Run();
