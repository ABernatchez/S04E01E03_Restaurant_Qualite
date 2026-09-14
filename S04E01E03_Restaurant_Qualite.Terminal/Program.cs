using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Restaurant.Qualite;

partial class Program
{
    static void Main(string[] args)
    {
        if (args.Length > 0 && args[0] == "--manuel")
        {
            AssemblageManuel();
        }
        else
        {
            AssemblageAutomatique(args);
        }
    }

    static void AssemblageManuel()
    {
        Console.Out.WriteLine("\nManuel");

        NotificationConsole notificationConsole = new NotificationConsole();
        CalculateurTaxe calculateurTaxe = new();
        Client client = new("client@exemple.ca");
        ServiceCommandes service = new(notificationConsole, calculateurTaxe);
        service.Creer(1001, 40m, client);

        Commande? commande = service.ObtenirDerniereCommande();
        Console.Out.WriteLine($"Total : {commande?.SousTotal + commande?.Taxe:C}");
    }

    static void AssemblageAutomatique(string[] args)
    {
        Console.Out.WriteLine("\nAutomatisé");

        var builder = Host.CreateApplicationBuilder(args);
        builder.Services.AddScoped<INotificationCommande, NotificationConsole>();
        builder.Services.AddScoped<CalculateurTaxe>();
        builder.Services.AddScoped<Commande>();
        builder.Services.AddScoped<ServiceCommandes>();
        using IHost host = builder.Build();

        using (IServiceScope score = host.Services.CreateScope())
        {
            ServiceCommandes service = score.ServiceProvider.GetRequiredService<ServiceCommandes>();
            Client client = new("client@exemple.ca");
            service.Creer(1001, 40m, client);

            Commande? commande = service.ObtenirDerniereCommande();
            Console.Out.WriteLine($"Total : {commande?.SousTotal + commande?.Taxe:C}");
        }
    }
}



