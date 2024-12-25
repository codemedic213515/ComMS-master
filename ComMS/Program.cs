using ComMS.Components;
using Microsoft.FluentUI.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using ComMS.Models;
using ComMS.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddHttpContextAccessor();

builder.Services.AddAuthorization();
builder.Services.AddIdentity<ApplicationUser, IdentityRole<Guid>>(o =>
{
    o.SignIn.RequireConfirmedEmail = false;
    o.Password.RequireNonAlphanumeric = false;
    o.Password.RequireDigit = false;
    o.Password.RequireLowercase = false;
    o.Password.RequireUppercase = false;
    o.SignIn.RequireConfirmedPhoneNumber = false;
    o.User.RequireUniqueEmail = true;
    o.Password.RequiredLength = 6;
    o.SignIn.RequireConfirmedAccount = false;
    o.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@#()";

}).AddEntityFrameworkStores<ConstructionPortalDBContext>().AddDefaultTokenProviders();
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/Component/Pages/Login";
        //options.LogoutPath = "/Component/Pages/Logout";
    });
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddHttpClient();

builder.Services.AddRazorPages().WithRazorPagesRoot("/Components/Pages");
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddDbContext<ConstructionPortalDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


builder.Services.AddScoped<CatService>();
builder.Services.AddScoped<SelectClientSelectService>();
builder.Services.AddScoped<SelectSupplierService>();
builder.Services.AddScoped<ZipServices>();
builder.Services.AddScoped<RankService>();
builder.Services.AddScoped<WorkTypeService>();
builder.Services.AddScoped<UnitService>();
builder.Services.AddScoped<SessionObjects>();
builder.Services.AddScoped<GroupService>();
builder.Services.AddScoped<DepartmentService>();

builder.Services.AddFluentUIComponents();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
//app.UseSession();
app.UseAuthentication();
app.UseAuthorization();
app.UseAntiforgery();
app.MapRazorPages();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();
app.Run();