namespace bookwormbackend.Models
{
    public class BooksPurchased
    {
        public int Id { get; set; }
        public string? image { get; set; }
        public int bid { get; set; }
        public int userid { get; set; }
        public string? ordered { get; set; }
    }
}
