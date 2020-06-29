using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CadastroDeEtiquetas.Models;

namespace CadastroDeEtiquetas.Data
{
    public class CadastroDeEtiquetasContext : DbContext
    {
        public CadastroDeEtiquetasContext(DbContextOptions<CadastroDeEtiquetasContext> options) : base(options)
        {

        }
        public DbSet<Etiqueta> Etiquetas { get; set; }
        public DbSet<Formulario> Formularios { get; set; }
    }
}
