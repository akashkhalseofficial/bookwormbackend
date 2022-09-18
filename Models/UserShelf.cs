namespace bookwormbackend.Models
{
    public class UserShelf
    {
        public int Id { get; set; }

        public int bids { get; set; }

        public int userid { get; set; }

        public string rentType { get; set; }

        public int? booksRented { get; set; }

        public int? booksPurchased { get; set; }

        public string? image { get; set; }

        public string? Ordered { get; set; }

        public DateTime Created { get; set; }
    }
}
