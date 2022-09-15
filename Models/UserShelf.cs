namespace bookwormbackend.Models
{
    public class UserShelf
    {
        public int Id { get; set; }

        public int bid { get; set; }

        public int userid { get; set; }

        public int? booksRented { get; set; }

        public int? booksPurchased { get; set; }

        public string? image { get; set; }
    }
}
