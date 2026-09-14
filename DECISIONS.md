# Décisions

## Exercice 1 — Substitution et DIP

- collaborateur devenu interchangeable: NotificationConsole -> INotificationCommande
- emplacement qui choisit l'implantation concrète: où l'objet est géré (Program.cs ou test unitaire)
- partie de la classe `ServiceCommandes` qui reste stable lors d'une substitution: Créatin et notification de la commande
- différence entre l’assemblage manuel et celui du cadriciel: Pas besoin de créer ServiceCommande et NotificationConsole
- justification du cycle de vie de chaque service: tous dans scoped car on veut qu'il garde leur état entre les demande, mais on ne veut pas qu'il soit le même objet dans un autre scoped.
- comparaison entre l’espion manuel et Moq: On doit créer l'espion manuelle tandis que Moq créer l'espion par lui même.

## Exercice 2 — SRP et CQS

À compléter :

- raisons de changer distinctes des classes `ServiceCommandes` et
  `CalculateurTaxe`;
- état modifié par la méthode de commande `Creer` de la classe
  `ServiceCommandes`;
- absence d'effet observable de la méthode de requête
  `ObtenirDerniereCommande` de la classe `ServiceCommandes`;
- mise à jour des assemblages manuel et avec le cadriciel.

## Exercice 3 — Loi de Déméter

À compléter :

- chaîne d’appels supprimée et message métier choisi;
- état observé par l’espion manuel;
- interaction équivalente vérifiée avec Moq.
