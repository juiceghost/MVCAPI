using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCAPI.Data.EFCore;
using MVCAPI.Models;

namespace MVCAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : MVCAPIController<Genre, EfCoreGenreRepository>
    {
        public GenresController(EfCoreGenreRepository repository) : base(repository)
        {

        }
    }
}
