namespace Restaurant.Qualite;

public class ProfilClient
{
    public string Courriel => coordonnees.Courriel;
    private Coordonnees coordonnees;

    public ProfilClient(string courriel)
    {
        coordonnees = new Coordonnees(courriel);
    }
}
