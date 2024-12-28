namespace ProjetCsharp.Models;

public class Produit
{
    public int ProduitId { get; set; }
    public string Libellé { get; set; }
    public int QuantitéStock { get; set; }
    public decimal PrixUnitaire { get; set; }
    public int QuantitéSeuil { get; set; }
    public string[] Images { get; set; }

    public ICollection<LigneCommande> LignesCommande { get; set; }
}
