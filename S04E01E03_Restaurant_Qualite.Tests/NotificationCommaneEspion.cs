using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Qualite.Tests;

public sealed class NotificationCommaneEspion : INotificationCommande
{
    private int? m_numeroCommandeRecu;
    private string? m_courrielRecu;

    public void NotifierCreation(int numeroCommande, string courriel)
    {
        m_numeroCommandeRecu = numeroCommande;
        m_courrielRecu = courriel;
    }

    public void Verifier(int? numeroAttendu, string? courrielRecu)
    {
        if (m_numeroCommandeRecu != numeroAttendu)
        {
            throw new ArgumentException("Le numéro de commande devrait être égale à celui reçu.");
        }

        if (m_courrielRecu != courrielRecu)
        {
            throw new ArgumentException("Le courriel devrait être égale à celui reçu.");
        }
    }
}
