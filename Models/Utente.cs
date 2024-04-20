using System.ComponentModel.DataAnnotations;

namespace morelli.giovanni._5h.Ecommerce.Models;

public class Utente
{
    public int? Id { get; set; }
    public string? Nome { get; set; }
    public string? Cognome { get; set; }
    public string? EMail { get; set; }
    public string? Password { get; set; }
    public string? Indirizzo { get; set; }

}