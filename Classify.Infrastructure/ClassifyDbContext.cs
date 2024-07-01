using Classify.Infrastructure.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Classify.Infrastructure
{
    public class ClassifyDbContext : IdentityDbContext<ApplicationUser>
    {
        public ClassifyDbContext(DbContextOptions<ClassifyDbContext> opt) 
            : base(opt)
        { 
        }

        public DbSet<ApplicationUser> AppUsers { get; set; } = null!;
        public DbSet<Composer> Composers { get; set; } = null!;
        public DbSet<Piece> Pieces { get; set; } = null!;
        public DbSet<Publisher> Publishers { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Composer>()
                .HasData(new Composer()
                {
                    Id = 1,
                    FirstName = "Johann Sebastian",
                    LastName = "Bach",
                    YearnBorn = 1685,
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/6/6a/Johann_Sebastian_Bach.jpg",
                    Description = "The music he wrote spanned forces – from solo instrumental works, such as the Cello Suites (below), " +
                    "to huge sacred choral pieces, instrumental concertos like the Brandenburg Concertos, and collections of " +
                    "keyboard music, including The Well-Tempered Clavier, that pushed contemporaneous instruments to their limits."
                },
                new Composer()
                {
                    Id = 2,
                    FirstName = "Wolfgang Amadeus",
                    LastName = "Mozart",
                    YearnBorn = 1756,
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1e/Wolfgang-amadeus-mozart_1.jpg/800px-Wolfgang-amadeus-mozart_1.jpg",
                    Description = "Composing in, and defining, the Classical era, Mozart wrote 41 symphonies, numerous concertos, " +
                    "revolutionary Italian operas including The Marriage of Figaro and Cosí fan tutte, and chamber works that are " +
                    "loved as much by audiences today as when they were composed."
                },
                new Composer()
                {
                    Id = 3,
                    FirstName = "Frédéric",
                    LastName = "Chopin",
                    YearnBorn = 1810,
                    ImageUrl = "https://media.wnyc.org/i/1395/1860/l/80/1/Chopin.jpeg",
                    Description = "Chopin was a great Romantic composer and keyboard virtuoso. His solo piano music remains some of the " +
                    "finest there is, his seminal works being his preludes, nocturnes and virtuosic waltzes.He maintained a very" +
                    " expensive lifestyle, by all accounts, and kept it up by giving piano lessons to Paris’s wealthiest people. He never " +
                    "liked the idea of asking them for money, though, so would look away while they left the fee on his mantelpiece."
                },
                new Composer()
                {
                    Id = 4,
                    FirstName = "Ludwig van",
                    LastName = "Beethoven",
                    YearnBorn = 1770,
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6e/Joseph_Karl_Stieler%27s_Beethoven_mit_dem_Manuskript_der_Missa_solemnis.jpg/1200px-Joseph_Karl_Stieler%27s_Beethoven_mit_dem_Manuskript_der_Missa_solemnis.jpg",
                    Description = "Beethoven’s name is widely interchanged with the phrase ‘greatest composer who ever lived’. And we’re okay with" +
                    " that.Beethoven, who composed in classical music’s Romantic era, absolutely revolutionised orchestral music" +
                    " with his Third ‘Eroica’ Symphony, writing music that captured the inner struggle of the individual alongside" +
                    " the sheer joy of life."
                }
                );

            builder.Entity<Piece>()
                .HasData(new Piece()
                {
                    Id = 1,
                    Title = "Violin Sonata No. 1 in G minor, BWV 1001",
                    InstrumentType = Enums.InstrumentType.Violin,
                    Type = Enums.PieceType.Sonata,
                    ComposerId = 1
                },
                new Piece()
                {
                    Id = 2,
                    Title = "Piano Sonata No. 16 in C Major, K.545",
                    InstrumentType = Enums.InstrumentType.Piano,
                    Type = Enums.PieceType.Sonata,
                    ComposerId = 2
                },
                new Piece()
                {
                    Id = 3,
                    Title = "Ballade No. 1 in G minor, Op. 23",
                    InstrumentType = Enums.InstrumentType.Piano,
                    Type = Enums.PieceType.Ballade,
                    ComposerId = 3
                },
                new Piece()
                {
                    Id = 4,
                    Title = "Cello Sonata No. 3 in A major, Op. 69",
                    InstrumentType = Enums.InstrumentType.Cello,
                    Type = Enums.PieceType.Sonata,
                    ComposerId = 4
                });

            base.OnModelCreating(builder);
        }
    }
}
