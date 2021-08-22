using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GenoCarsSolution.Models
{
    public class Cars
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Brand { get; set; }
        [Required]
        [StringLength(30)]
        public string Model { get; set; }

        public string Color { get; set; }
        public int SizeOfEngine { get; set; }
        public int HorsePowers { get; set; }
        public People People { get; set; }
        [ForeignKey("Person")]
        public int PeopleId { get; set; }
    }
}
