using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVCFilmes.Models.Data
{
    public class MVCFilmesContext : DbContext
    {
        public MVCFilmesContext(DbContextOptions<MVCFilmesContext> options) : base(options)
        {

        }

        public DbSet<Filmes> Filmes { get; set; }

    }
}

