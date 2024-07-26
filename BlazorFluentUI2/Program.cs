using BlazorFluentUI2.Data;
using BlazorFluentUI2.Components;
using Microsoft.FluentUI.AspNetCore.Components;


var builder = WebApplication.CreateBuilder(args);

var connString = builder.Configuration.GetConnectionString("BloodPressure");
builder.Services.AddSqlServer<BloodPressureContext>(connString);


// Add services to the container.
builder.Services.AddRazorComponents();
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
app.UseAntiforgery();

app.MapRazorComponents<App>();

app.Run();



