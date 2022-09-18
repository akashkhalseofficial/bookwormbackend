using System.ComponentModel.DataAnnotations;

namespace bookwormbackend.Models
{
    public class Books
    {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Language { get; set; }
            public string Category { get; set; }
            public string Author { get; set; }
            public int Pages { get; set; }
            public int Price { get; set; }
            public int stock { get; set; }
            public string? image { get; set; }
            public DateTime Created { get; set; }

            public virtual BooksStock? BooksStock { get; set; }

            public virtual Files? Files { get; set; }
    }

        public enum CategoryType
        {
            Text, Audio
        }

        public enum LanguageType
        {
            English, Hindi, Marathi, Sanskrit
        }
}
