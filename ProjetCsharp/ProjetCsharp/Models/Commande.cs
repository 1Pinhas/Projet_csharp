namespace ProjetCsharp.Models;

public class Commande
{
    public int CommandeId { get; set; }
    public DateTime Date { get; set; }
    public decimal Montant { get; set; }
    public string Statut { get; set; }

    public int ClientId { get; set; }
    public Client Client { get; set; }
    public int RSId { get; set; }
    public RS RS { get; set; }

    public ICollection<Produit> Produits { get; set; }
    public ICollection<LigneCommande> LignesCommande { get; set; }
}
