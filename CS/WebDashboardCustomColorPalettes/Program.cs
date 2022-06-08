using DevExpress.AspNetCore;
using DevExpress.DashboardAspNetCore;
using DevExpress.DashboardCommon;
using DevExpress.DashboardWeb;
using Microsoft.Extensions.FileProviders;
using System.Drawing;

var builder = WebApplication.CreateBuilder(args);

IFileProvider? fileProvider = builder.Environment.ContentRootFileProvider;
IConfiguration? configuration = builder.Configuration;

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddDevExpressControls();
builder.Services.AddScoped<DashboardConfigurator>((IServiceProvider serviceProvider) => {
    DashboardConfigurator configurator = new DashboardConfigurator();
    configurator.SetDashboardStorage(new DashboardFileStorage(fileProvider.GetFileInfo("Data/Dashboards").PhysicalPath));
    configurator.SetConnectionStringsProvider(new DashboardConnectionStringsProvider(configuration));
    configurator.CustomPalette += Default_CustomPalette;
   
    return configurator;
});


void Default_CustomPalette(object sender, CustomPaletteWebEventArgs e) {
    if (e.DashboardId == "SalesByCategory") {

        // Create a new custom palette.
        List<Color> customColors = new List<Color>();
        customColors.Add(Color.LightBlue);
        customColors.Add(Color.Aquamarine);
        customColors.Add(Color.SkyBlue);
        customColors.Add(Color.LightCoral);
        customColors.Add(Color.Tomato);
        customColors.Add(Color.IndianRed);
        customColors.Add(Color.Violet);
        customColors.Add(Color.Plum);
        customColors.Add(Color.MediumOrchid);

        // Assign a newly created custom palette to the Web Dashboard.
        e.Palette = new DashboardPalette(customColors);
    }
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment()) {
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseDevExpressControls();
EndpointRouteBuilderExtension.MapDashboardRoute(app, "dashboardControl", "DefaultDashboard");

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();

