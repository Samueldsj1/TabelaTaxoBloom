using WebAppBloom.Contexts;

var builder = WebApplication.CreateBuilder(args);


// a injeção de dependencia é um padrão de projeto que permite que as dependências de um objeto sejam injetadas nele por meio de um mecanismo externo
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>();
// essas duas linhas de codigo esta definindo que vai injetar uma dependencia no App


// Add services to the container.
builder.Services.AddControllersWithViews();

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
