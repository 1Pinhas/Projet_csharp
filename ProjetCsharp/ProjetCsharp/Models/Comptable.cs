namespace ProjetCsharp.Models;

public class Comptable
{
    public int ComptableId { get; set; }
    public string Nom { get; set; }
    public string Prénom { get; set; }
    public string Téléphone { get; set; }

    public ICollection<Commande> Commandes { get; set; }
}

