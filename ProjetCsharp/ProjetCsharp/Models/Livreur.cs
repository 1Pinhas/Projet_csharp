namespace ProjetCsharp.Models;

public class Livreur
{
    public int LivreurId { get; set; }
    public string Nom { get; set; }
    public string Prénom { get; set; }
    public string Téléphone { get; set; }

    public ICollection<Livraison> Livraisons { get; set; }
}
