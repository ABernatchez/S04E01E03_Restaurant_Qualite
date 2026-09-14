namespace Restaurant.Qualite;

public class ServiceCommandes
{
    private INotificationCommande m_notificationCommande;
    private CalculateurTaxe m_calculateurTaxe;

    private Commande? m_derniereCommande;


    public ServiceCommandes(INotificationCommande notificationCommande, CalculateurTaxe calculateurTaxe)
    {
        ArgumentNullException.ThrowIfNull(notificationCommande, nameof(notificationCommande));
        this.m_notificationCommande = notificationCommande;

        ArgumentNullException.ThrowIfNull(calculateurTaxe, nameof(calculateurTaxe));
        this.m_calculateurTaxe = calculateurTaxe;
    }

    public void Creer(int numero, decimal sousTotal, Client client)
    {
        decimal taxe = this.m_calculateurTaxe.Total(sousTotal);
        Commande commande = new(numero, sousTotal, taxe, client);
        m_derniereCommande = commande;

        m_notificationCommande.NotifierCreation(
            commande.Numero,
            client.Courriel
        );
    }

    public Commande? ObtenirDerniereCommande()
    {
        return m_derniereCommande;
    }
}
