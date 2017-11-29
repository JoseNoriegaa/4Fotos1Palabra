using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoJuego
{
    class Jugada
    {
        [Key,Display(Name = "Palabra")]
        public string palabraId { get; set; }
        public byte[] foto1 { get; set; }
        public byte[] foto2 { get; set; }
        public byte[] foto3 { get; set; }
        public byte[] foto4 { get; set; }
        public Jugada() { }

        public Jugada(string palabra,byte[] foto1, byte[] foto2, byte[] foto3, byte[] foto4)
        {
            this.palabraId = palabra;
            this.foto1 = foto1;
            this.foto2 = foto2;
            this.foto3 = foto3;
            this.foto4 = foto4;



        }




    }
}
