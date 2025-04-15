using Microsoft.EntityFrameworkCore;
using LibraryAPI.Models; // adjust if your models are elsewhere

public class LibraryDbContext : DbContext
{
    public LibraryDbContext(DbContextOptions options) : base(options) { }

    public DbSet<BookModel> Books { get; set; }
    public DbSet<AuthorModel> Authors { get; set; } 
    // add more DbSets as needed
}
