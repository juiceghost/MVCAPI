using System;
using MVCAPI.Data;
using System.ComponentModel.DataAnnotations;

namespace MVCAPI.Models
{
    public class Movie : IEntity
    {
        public Movie()
        {
            this.Genres = new HashSet<Genre>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }

        /*
        [Required]
        [StringLength(30)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        public string Genre { get; set; }
        */

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public virtual ICollection<Genre> Genres { get; set; }
    }
}

