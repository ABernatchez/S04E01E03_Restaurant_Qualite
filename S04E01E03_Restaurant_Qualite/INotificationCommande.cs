using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Qualite;

public interface INotificationCommande
{
    void NotifierCreation(int numeroCommande, string courriel);
}
