using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MyECommerce.DAL.Context;
using MyECommerce.BLL;
using MyECommerce.Entity.Entity;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<MyECommerceContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//Adding Session Here
builder.Services.AddSession(session =>
{
    session.Cookie.Name = "product_cart";
    session.IdleTimeout = TimeSpan.FromMinutes(2);
});

builder.Services.AddIdentity<AppUser, IdentityRole>().AddEntityFrameworkStores<MyECommerceContext>();

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = new PathString("/User/Login");
    options.Cookie = new CookieBuilder()
    {
        Name = "Berke"
    };
    options.SlidingExpiration = true;
    options.ExpireTimeSpan = TimeSpan.FromMinutes(31);
});

builder.Services.AddRepositoryServices();


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
//Added session here
app.UseSession();

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");

    endpoints.MapControllerRoute(name: "areas", pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

});

app.Run();
