using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WorkoutJournal.Data.Data;

var hostBuilder = Host.CreateDefaultBuilder(args);

hostBuilder.ConfigureAppConfiguration(config => {
    config.AddJsonFile("appsettings.json");
});

hostBuilder.ConfigureServices((context, services) =>
{
    var connectionString = context.Configuration.GetConnectionString("DefaultConnection");
    services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));
});

using IHost host = hostBuilder.Build();

var context = host.Services.GetService<AppDbContext>();

host.RunAsync();