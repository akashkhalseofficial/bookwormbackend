namespace bookwormbackend.Models
{
    public class BooksRented
    {
        public int Id { get; set; }

        public int bid { get; set; }
        public int userid { get; set; }

        public string? image { get; set; }

        public string? ordered { get; set; }

    }
}
