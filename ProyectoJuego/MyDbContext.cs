using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoJuego
{
    class MyDbContext:DbContext
    {
        public DbSet<Jugada> palabras { get; set; }
        public MyDbContext()
        { }
    }
}
