using System.ComponentModel.DataAnnotations.Schema;

namespace bookwormbackend.Models
{
    public class Orders
    {
        public int Id { get; set; }

        public int quantity { get; set; }
        public int totalorderprice { get; set; }

        public int bid { get; set; }

        public int userid { get; set; }

        public string? image { get; set; }

        public string? ordered { get; set; }

        public virtual OrderDetails? OrderDetails { get; set; }

        public virtual Invoices? Invoices { get; set; }

        public virtual UserShelf? UserShelf { get; set; }

        public virtual BooksPurchased? BooksPurchased { get; set; }

        public virtual BooksRented? BooksRented { get; set; }
    }
}
