using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4fotos
{
   public class Conexion
    {
        public String  ConnectionString { get;  set; }

        public Conexion() {
            this.ConnectionString = "Data source= DESKTOP-TIBD95D;initial catalog=DB4Fotos;integrated security=true;";
        }
    }
}
