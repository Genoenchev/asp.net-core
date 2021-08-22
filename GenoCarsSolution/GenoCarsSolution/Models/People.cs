using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GenoCarsSolution.Models
{
    public class People
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string PersonName { get; set; }

        public int Age { get; set; }

        public ICollection<Cars> Cars { get; set; }
    }
}
