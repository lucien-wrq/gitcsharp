//using System.Runtime.CompilerServices;

//EtreVivant elephant = new EtreVivant(new DateTime(1958, 1, 1));
//EtreVivant souris = new EtreVivant(new DateTime(2025, 3, 3));

//Console.WriteLine($"elephant : {elephant.DateDeNaissance}");
//Console.WriteLine($"souris : {souris.DateDeNaissance}");

//Console.WriteLine($"elephant a : {elephant.GetAge()} ans");
//Console.WriteLine($"souris a : {souris.GetAge()} ans");


//int variable1 = 22;
//int variable2 = variable1;

//Console.WriteLine($"variable1 : {variable1}");
//Console.WriteLine($"variable2 : {variable2}");

//Helper.Test(variable1);

//Console.WriteLine($"variable1 : {variable1}");
//Console.WriteLine($"variable2 : {variable2}");

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

Console.WriteLine(societe.Stalker());