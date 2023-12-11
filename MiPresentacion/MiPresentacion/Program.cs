using MiPresentacion.Models.Interfaces;
using MiPresentacion.Models.Servicios;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//AGREGO EL TIPO DE DATO QUE RECIBIRA Y EL VALOR POR PARAMETRO. EL TIPO DE LA INTERFAZ, EL VALOR PROVIENE DE LA CLASE
builder.Services.AddTransient<IRepositorio, RepositorioProyectos>();

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
