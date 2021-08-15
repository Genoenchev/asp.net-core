using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Library.Models;

namespace Library.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext (DbContextOptions<LibraryContext> options)
            : base(options)
        {
        }

        public DbSet<Library.Models.Author> Author { get; set; }

        public DbSet<Library.Models.Book> Book { get; set; }

        public DbSet<Library.Models.Genre> Genre { get; set; }

        public DbSet<Library.Models.Review> Review { get; set; }

        public DbSet<Library.Models.Stats> Stats { get; set; }

        public DbSet<Library.Models.Favourites> Favourites { get; set; }
    }
}
