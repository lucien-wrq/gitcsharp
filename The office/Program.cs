Employe jacky = new Employe("Jacky", 2000, "Taylor Swift");
Employe Tom = new Employe("Tom", 3000, "Kids united");


Console.WriteLine($"{jacky.Travail()}");
Console.WriteLine($"{Tom.Travail()}");

Boss oli = new Boss("oli", 5000, "Pieds");
Console.WriteLine($"{jacky.Salaire}");
Console.WriteLine($"{oli.Travail()}");

oli.Augmente(jacky);
Console.WriteLine($"{jacky.Salaire}");

Societe societe = new Societe("Societe");
societe.Embauche(jacky);
societe.Embauche(Tom);
societe.Embauche(oli);

Console.WriteLine($"{societe.GetChef()}");
Console.WriteLine($"{societe.CalculSommeSalaire()}");
Console.WriteLine($"{societe.Travail()}");

// Console.WriteLine(societe.Stalker());