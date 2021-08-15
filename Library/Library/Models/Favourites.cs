using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models
{
    public class Favourites
    {
        public int Id { get; set; }
        public Book Book { get; set; }
        [ForeignKey("Book")]
        public int BookFK { get; set; }
        public string Comment { get; set; }
    }
}
