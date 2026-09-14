namespace Restaurant.Qualite;

public class ServiceCommandes
{
    private Commande? m_derniereCommande;
    private INotificationCommande m_notificationCommande;

    public ServiceCommandes(INotificationCommande notificationCommande)
    {
        ArgumentNullException.ThrowIfNull(notificationCommande, nameof(notificationCommande));
        this.m_notificationCommande = notificationCommande;
    }

    public Commande Creer(int numero, decimal sousTotal, Client client)
    {
        decimal taxe = sousTotal * 0.14975m;
        Commande commande = new(numero, sousTotal, taxe, client);
        m_derniereCommande = commande;

        m_notificationCommande.NotifierCreation(
            commande.Numero,
            commande.Client.Profil.Coordonnees.Courriel
        );

        return commande;
    }

    public Commande? ObtenirDerniereCommande()
    {
        return m_derniereCommande;
    }
}
