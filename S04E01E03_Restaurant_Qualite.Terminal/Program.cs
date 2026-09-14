using Restaurant.Qualite;

// E01 : conservez une fonction d’assemblage manuel, puis ajoutez une fonction
// équivalente utilisant Host.CreateApplicationBuilder(args). Choisissez la
// première avec --manuel et la seconde par défaut.
 NotificationConsole notificationConsole = new NotificationConsole();

Client client = new("client@exemple.ca");
ServiceCommandes service = new(notificationConsole);
Commande commande = service.Creer(1001, 40m, client);

Console.Out.WriteLine($"Total : {commande.SousTotal + commande.Taxe:C}");
