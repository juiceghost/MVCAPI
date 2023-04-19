using System;
using Microsoft.EntityFrameworkCore;

namespace MVCAPI.Models
{
	public class MVCAPIContext : DbContext
    {

		public MVCAPIContext(DbContextOptions<MVCAPIContext> options)
			: base(options)
		{

		}

		public DbSet<Movie> Movie { get; set; }

        public DbSet<Genre> Genre { get; set; }
    }
}

