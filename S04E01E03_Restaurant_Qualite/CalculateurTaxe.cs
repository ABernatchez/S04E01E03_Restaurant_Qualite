using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Qualite;

public sealed class CalculateurTaxe
{
    public const decimal TAXE = 0.14975m;

    public decimal Total(decimal sousTotal) 
    {
        return sousTotal * TAXE;
    }
}
