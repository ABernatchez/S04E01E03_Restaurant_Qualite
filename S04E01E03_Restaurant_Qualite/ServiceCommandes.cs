namespace Restaurant.Qualite;

public class ServiceCommandes
{
    private Commande? m_derniereCommande;

    public Commande Creer(int numero, decimal sousTotal, Client client)
    {
        decimal taxe = sousTotal * 0.14975m;
        Commande commande = new(numero, sousTotal, taxe, client);
        m_derniereCommande = commande;

        NotificationConsole notification = new();
        notification.NotifierCreation(
            commande.Numero,
            commande.Client.Profil.Coordonnees.Courriel);

        return commande;
    }

    public Commande? ObtenirDerniereCommande()
    {
        return m_derniereCommande;
    }
}
