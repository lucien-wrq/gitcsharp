public class Societe
{
    public string Nom { get; set; }
    private List<IEmploye> Employes { get; set; }

    public Societe(string nom)
    {
        this.Nom = nom;
        this.Employes = new List<IEmploye>();
    }

    public void Embauche(IEmploye employe)
    {
        this.Employes.Add(employe);
    }

    public string GetChef()
    {
        foreach (IEmploye employe in Employes)
        {
            if (employe is Boss)
            {
                return employe.Nom;
            }
        }
        return "Pas de chef";
    }

    public double CalculSommeSalaire()
    {
        double somme = 0;
        foreach (IEmploye employe in Employes)
        {
            somme += employe.Salaire;
        }
        return somme;
    }

    public string Travail()
    {
        string travail = "";
        foreach (IEmploye employe in Employes)
        {
            travail += employe.Travail() + "\n";
        }
        return travail;
    }

    // public string Stalker()
    // {
    //     string hobby = "";
    //     foreach (IEmploye employe in Employes)
    //     {
    //         hobby += $"{employe.Nom} : {employe.HobbyHonteux}, ";
    //     }
    //     return hobby;
    // }    
}
