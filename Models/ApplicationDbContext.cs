using Microsoft.EntityFrameworkCore;
using Mission6_Keeney.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Movie> Movies { get; set; }
    
    // Seeding my database with my 3 favorite movies
    protected override void OnModelCreating(ModelBuilder mb)
    {
        mb.Entity<Movie>().HasData(
            new Movie
            {
                MovieId = 1,
                Title = "Shawshank Redemption",
                Genre = "Drama",
                Director = "Frank Darabont",
                ReleaseYear = 1994,
                Rating = "R",
                Edited = false,
                LentTo = "Ben",
                Notes = "The best movie ever!"
            },
            new Movie
            {
                MovieId = 2,
                Title = "Avengers: Endgame",
                Genre = "Action",
                Director = "Anthony J. Russo",
                ReleaseYear = 2019,
                Rating = "PG-13",
                Edited = false,
                LentTo = "Ben",
                Notes = "Awesome movie!"
            },
            new Movie
            {
                MovieId = 3,
                Title = "The Dark Knight",
                Genre = "Action",
                Director = "Christopher Nolan",
                ReleaseYear = 2008,
                Rating = "PG-13",
                Edited = false,
                LentTo = "Ben",
                Notes = "Long but good!"
            });
    }
}