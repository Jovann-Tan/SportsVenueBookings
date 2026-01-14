using SportsVenueBookings.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SportsVenueBookings.Data;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using SportsVenueBookings.Components.Account;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContextFactory<SportsVenueBookingsContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SportsVenueBookingsContext") ?? throw new InvalidOperationException("Connection string 'SportsVenueBookingsContext' not found.")));

builder.Services.AddQuickGridEntityFrameworkAdapter();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddCascadingAuthenticationState();

builder.Services.AddScoped<IdentityUserAccessor>();

builder.Services.AddScoped<IdentityRedirectManager>();

builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();

builder.Services.AddAuthentication(options =>
    {
        options.DefaultScheme = IdentityConstants.ApplicationScheme;
        options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
    })
    .AddIdentityCookies();

builder.Services.AddIdentityCore<SportsVenueBookingsUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<SportsVenueBookingsContext>()
    .AddSignInManager()
    .AddDefaultTokenProviders();

builder.Services.AddSingleton<IEmailSender<SportsVenueBookingsUser>, IdentityNoOpEmailSender>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    app.UseMigrationsEndPoint();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.MapAdditionalIdentityEndpoints();;

app.Run();
