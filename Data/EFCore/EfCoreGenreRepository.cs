using System;
using MVCAPI.Models;

namespace MVCAPI.Data.EFCore
{
    public class EfCoreGenreRepository : EfCoreRepository<Genre, MVCAPIContext>
    {
        public EfCoreGenreRepository(MVCAPIContext context) : base(context)
        {

        }
        // We can add new methods specific to the movie repository here in the future
    }
}

