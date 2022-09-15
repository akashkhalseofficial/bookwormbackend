using Microsoft.EntityFrameworkCore;
using bookwormbackend.Models;

namespace bookwormbackend.Data
{
    public class BookwormDbContext : DbContext
    {

        public BookwormDbContext(DbContextOptions<BookwormDbContext> options)
            : base(options)
        {

        }

        public DbSet<Books>? Books { get; set; }

        public DbSet<bookwormbackend.Models.UserCreds>? UserCreds { get; set; }

        public DbSet<bookwormbackend.Models.UserData>? UserData { get; set; }

        public DbSet<bookwormbackend.Models.Orders>? Orders { get; set; }

        public DbSet<bookwormbackend.Models.OrderDetails>? OrderDetails { get; set; }

        public DbSet<bookwormbackend.Models.BooksRented>? BooksRented { get; set; }

        public DbSet<bookwormbackend.Models.BooksPurchased>? BooksPurchased { get; set; }

        public DbSet<bookwormbackend.Models.Invoices>? Invoices { get; set; }

        public DbSet<bookwormbackend.Models.UserShelf>? UserShelf { get; set; }
    }
}
