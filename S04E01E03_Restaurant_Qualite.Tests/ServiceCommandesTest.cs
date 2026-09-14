using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Qualite.Tests;

public sealed class ServiceCommandesTest
{
    public const string EMAIL_CLIENT = "client@exemple.ca";
    public const int NUMERO_COMMANDE = 1001;
    public const decimal TEST_SOUS_TOTAL = 40m;


    [Fact]
    public void Creer_ClientEtNumeroCommandeValide_NotificationCommandeEstAppeleAvecBonArgument()
    {
        NotificationCommaneEspion notificationEspion = new();
        CalculateurTaxe calculateurTaxe = new();
        Client client = new(EMAIL_CLIENT);
        ServiceCommandes service = new(notificationEspion, calculateurTaxe);

        var _ = service.Creer(NUMERO_COMMANDE, TEST_SOUS_TOTAL, client);

        notificationEspion.Verifier(NUMERO_COMMANDE, EMAIL_CLIENT);
    }

    [Fact]
    public void Creer_ClientEtNumeroCommandeValide_MoqNotificationCommandeEstAppeleAvecBonArgument()
    {
        Mock<INotificationCommande> notificationEspion = new();
        CalculateurTaxe calculateurTaxe = new();
        Client client = new(EMAIL_CLIENT);
        ServiceCommandes service = new(notificationEspion.Object, calculateurTaxe);

        var _ = service.Creer(NUMERO_COMMANDE, TEST_SOUS_TOTAL, client);

        notificationEspion.Verify(e => e.NotifierCreation(NUMERO_COMMANDE, EMAIL_CLIENT), Times.Once);
    }
}
