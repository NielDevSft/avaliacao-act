using Administrativo.Contexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var stringConnection = "";

var provIder = builder.Services.BuildServiceProvider();
var configuration = provIder.GetRequiredService<IConfiguration>();

if (builder.Environment.IsDevelopment()) {
    stringConnection = configuration.GetConnectionString("PgsqlConnection");
}
else { 
    var config = new ConfigurationBuilder().AddEnvironmentVariables();
    
    var dbHost = configuration["PG_HOST"] ?? "";
    var dbPort = configuration["PG_PORT"] ?? "";
    var dbUser = configuration["PG_USER"] ?? "";
    var dbPassword = configuration["PG_PASSWORD"] ?? "";
    var dbName = configuration["PG_DB_NAME"] ?? "";

    stringConnection = $"Host={dbHost};Port={dbPort};Database={dbName};User Id={dbUser};Password={dbPassword};";
}


builder.Services.AddEntityFrameworkNpgsql()
    .AddDbContext<LancamentoContext>(options =>
    options.UseNpgsql(stringConnection));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<LancamentoContext>();
    if (context.Database.GetPendingMigrations().Any())
    {
        context.Database.Migrate();
    }
}

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{Id?}");

app.Run();
