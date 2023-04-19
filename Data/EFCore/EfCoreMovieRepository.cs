using System;
using MVCAPI.Models;

namespace MVCAPI.Data.EFCore
{
    public class EfCoreMovieRepository : EfCoreRepository<Movie, MVCAPIContext>
    {
        public EfCoreMovieRepository(MVCAPIContext context) : base(context)
        {

        }
        // We can add new methods specific to the movie repository here in the future
    }
}

