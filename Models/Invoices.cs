using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bookwormbackend.Models
{
    public class Invoices
    {
          public int Id { get; set; }

          public int bids { get; set; }

          public int userid { get; set; }

          public int totalordercost { get; set; }

          public string purchaseType { get; set; }

          public string? image { get; set; }


    }
}
