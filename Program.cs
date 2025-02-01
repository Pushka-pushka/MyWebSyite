using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddMvc();



var app = builder.Build();

app.UseRouting();
app.UseStaticFiles();
app.MapDefaultControllerRoute();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
    );




app.MapGet("/", () => "Zapuusk!");
app.MapGet("/test", () => "это тест");
app.MapGet("/func", HomePage);
app.MapGet("/b", () => app.Configuration["HelloMessage"]);

app.MapGet("/html", async context =>
{
    context.Response.ContentType = "text/html";
    await context.Response.WriteAsync("<h1> Heeeelooo</h1> joopa!"
        + context.Request.QueryString.ToString());
});
app.MapGet("/param", async context =>
{
    await context.Response.WriteAsync("это строка параметров: "
        + context.Request.QueryString.ToString());
});

app.Run();


async Task HomePage(HttpContext context)
{
    await context.Response.WriteAsync("looool!");
}