namespace ProjetCsharp.Models;

public class RS
{
    public int RSId { get; set; }
    public string Nom { get; set; }
    public string Prénom { get; set; }
    public string Téléphone { get; set; }

    public ICollection<Produit> Produits { get; set; }
    public ICollection<Commande> Commandes { get; set; }
}
