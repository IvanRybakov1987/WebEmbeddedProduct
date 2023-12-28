var builder = WebApplication.CreateBuilder(args);

// Добавьте сервисы в контейнер.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Настройте конвейер HTTP-запросов.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // Значение HSTS по умолчанию — 30 дней. Возможно, вы захотите изменить это для производственных сценариев, см. https://aka.ms/aspnetcore-hsts.
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
