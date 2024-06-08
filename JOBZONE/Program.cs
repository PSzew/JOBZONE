using JOBZONE;
using JOBZONE.Models;
using JOBZONE.Services;
using JOBZONE.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IJobOfferService, JobOfferService>();
builder.Services.AddScoped<IEducationService, EducationService>();
builder.Services.AddScoped<ICertificateService, CertificateService>();
builder.Services.AddScoped<ICompanySerivce, CompanyService>();

builder.Services.AddDbContext<DbJobZoneContext>(builder =>
{
    builder.UseSqlServer(@"Data Source=DESKTOP-PLI69GE\SQLEXPRESS;Initial Catalog=Jobzone_Main;Integrated Security=True;TrustServerCertificate=True");
});

builder.Services.AddIdentity<UserModel,IdentityRole>(options =>
{
    options.Password.RequireDigit = false;
    options.Password.RequiredLength = 2;
    options.Password.RequireUppercase = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.User.RequireUniqueEmail = true;
}).AddEntityFrameworkStores<DbJobZoneContext>();

builder.Services.ConfigureApplicationCookie(options =>
{
    // Ustawienie œcie¿ki przekierowania dla niezalogowanych u¿ytkowników
    options.LoginPath = "/Home/LoginPage";
    // Opcjonalnie: Ustawienie œcie¿ki przekierowania w przypadku braku uprawnieñ
    options.AccessDeniedPath = "/Home/Index";
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
