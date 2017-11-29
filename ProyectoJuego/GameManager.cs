using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoJuego
{
    class GameManager
    {
        MyDbContext db = new MyDbContext();
        public GameManager()
        {

        }
        public List<Jugada> GetList()
        {
            return db.palabras.ToList();
        }
            
        public void agregar(Jugada s)
        {

            db.palabras.Add(s);
            db.SaveChanges();

        }


    }
}
