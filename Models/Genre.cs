using System;
using MVCAPI.Data;
using System.ComponentModel.DataAnnotations;

namespace MVCAPI.Models
{
    public class Genre : IEntity
    {
        public Genre()
        {
            this.Movies = new HashSet<Movie>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Name { get; set; }

        [StringLength(120)]
        public string? Description { get; set; }

        /*
        [Required]
        [StringLength(30)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        public string Genre { get; set; }
        */

        public virtual ICollection<Movie> Movies { get; set; }
    }
}

