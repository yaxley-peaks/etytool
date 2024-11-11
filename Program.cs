using System.Configuration;
using EtyTool.Context;
using EtyTool.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<EtyToolContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("default")));

var mwClientName = builder.Configuration["MWHttpClientName"];
ArgumentException.ThrowIfNullOrEmpty(mwClientName);
builder.Services.AddHttpClient(
    mwClientName,
    client =>
    {
        client.BaseAddress=new Uri("https://dictionaryapi.com/api/v3/references/collegiate/json/");
        client.DefaultRequestHeaders.UserAgent.ParseAdd("EtyTool"); 
    });

builder.Services.AddSingleton<LangService>();
builder.Services.AddScoped<EtymologyService>();
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