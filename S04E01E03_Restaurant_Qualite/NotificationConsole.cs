namespace Restaurant.Qualite;

public class NotificationConsole
{
    public void NotifierCreation(int numeroCommande, string courriel)
    {
        Console.Out.WriteLine($"Commande {numeroCommande} créée pour {courriel}.");
    }
}
