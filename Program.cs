using EmployeeAccounting.Services;

var builder = WebApplication.CreateBuilder();

// Регистрируем хранилище для пицц чтобы хранить все заказы в оперативной памяти
//builder.Services.AddSingleton<PizzaStorage>();

builder.Services.AddSingleton<EmployeeStorage>();

// Добавить MVC контроллеры в dependency injection
// Чтобы при начале обработки запроса сервер смог создать настроенный контроллер
// Контроллеры - scoped объекты
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Разрешение на использование статик файлов (css, js, html.....)
// Грубо говоря - активация папки wwwroot
app.UseStaticFiles();

// Формируем формат URL для попадания в нужную точку
// localhost:5000/staff/form
app.MapControllerRoute("default", "{controller}/{action}/{id?}");

app.Run();