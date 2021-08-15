using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }


        public Author Author { get; set; }
        [ForeignKey("Author")]
        public int AuthorFK { get; set; }


        public Genre Genre { get; set; }
        [ForeignKey("Genre")]
        public int GenreFK { get; set; }

        public ICollection<Favourites> Favourites { get; set; }
    }
}