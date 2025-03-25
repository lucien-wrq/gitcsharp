namespace SN2;

public class Eleve
{

    publique string Nom { get; set; }
    publique string Prenom { get; set; }


}

public class  SN2Service : Eleve
{
    public List<Eleve> Eleves { get; set; }

    public void AddEleve(Eleve eleve)
    {
        List.Add(eleve);
    }

    public List GetList()
    {
        return List;
    }

    public string Roulette()
    {
        return List[Random.ReferenceEquals(0, List.Count)].Nom;
    }

}