using Microsoft.EntityFrameworkCore;
using DAL;
using Services;
using Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddRazorPages();

builder.Services.AddAutoMapper(typeof(Program).Assembly);

//builder.Services.AddSingleton<IUsersRepository, UsersRepository>();
builder.Services.AddScoped<IUsersRepository, UsersRepository>();

//builder.Services.AddSingleton<IUsersService, UsersService>();
builder.Services.AddScoped<IUsersService, UsersService>();

//builder.Services.AddTransient<DatabaseContext>();

builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("ConnectionString")
    ));

builder.Services.AddAutoMapper(typeof(Program));

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
app.UseAuthentication();
app.UseAuthorization();

//app.MapRazorPages();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
