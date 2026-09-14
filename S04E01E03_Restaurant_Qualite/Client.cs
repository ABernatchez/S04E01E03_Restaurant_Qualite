namespace Restaurant.Qualite;

public class Client
{
    public string Courriel => profil.Courriel;
    private ProfilClient profil;

    public Client(string courriel)
    {
        profil = new ProfilClient(courriel);
    }
}
