using Business.Services;
using Business.Services.Bases;
using DataAccess.Contexts;
using DataAccess.Repositories;
using DataAccess.Repositories.Bases;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

#region Authentication
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(config =>
    {
        config.LoginPath = "/Hesaplar/Giris";
        config.AccessDeniedPath = "/Hesaplar/YetkisizIslem";
        config.ExpireTimeSpan = TimeSpan.FromMinutes(30);
        config.SlidingExpiration = true;
    });
#endregion

//IoC Container: Inversion of control container: baðýmlýlýklarýn yönetimi
//builder.Services.AddDbContext<ETicaretContext>();
//builder.Services.AddScoped<KategoriRepoBase, KategoriRepo>();
builder.Services.AddScoped<IKategoriService, KategoriService>();
//builder.Services.AddSingleton<IKategoriService, KategoriService>();
//builder.Services.AddTransient<IKategoriService, KategoriService>();
builder.Services.AddScoped<IUrunService, UrunService>();
builder.Services.AddScoped<IHesapService, HesapService>();
builder.Services.AddScoped<IKullaniciService, KullaniciService>();
builder.Services.AddScoped<IUlkeService, UlkeService>();
builder.Services.AddScoped<ISehirService, SehirService>();
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
#region Authentication
app.UseAuthentication();
#endregion

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
