using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Qualite.Tests;

public sealed class CalculateurTaxeTest
{
    public const decimal SOUS_TOTAL = 40m;

    [Fact]
    public void Total_AvecSousTotalValide_RetourneBonTotal()
    {
        CalculateurTaxe calculateurTaxe = new CalculateurTaxe();

        decimal result = calculateurTaxe.Total(SOUS_TOTAL);

        Assert.Equal(SOUS_TOTAL * CalculateurTaxe.TAXE, result);
    }
}
