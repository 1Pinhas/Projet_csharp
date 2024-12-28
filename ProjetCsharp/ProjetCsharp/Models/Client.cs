namespace ProjetCsharp.Models;

public class Client
{
    public int ClientId { get; set; }
    public string Nom { get; set; }
    public string Prénom { get; set; }
    public string Téléphone { get; set; }
    public string Adresse { get; set; }
    public decimal SoldeCompte { get; set; }

    public ICollection<Commande> Commandes { get; set; }
    public ICollection<Versement> Versements { get; set; }
}
{
}
