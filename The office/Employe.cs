﻿public class Employe : Personne, IEmploye
{
    public double Salaire { get; set; }

    public Employe(string nom, double salaire, string HobbyHonteux) : base(nom, HobbyHonteux)
    {
        Salaire = salaire;
    }

    public string Travail()
    {
        return $"{this.Nom} travaille !";
    }
}