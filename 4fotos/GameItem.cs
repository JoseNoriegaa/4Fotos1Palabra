using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4fotos
{
    class GameItem
    {
        public string palabra { get; private set; }
        public Image[] fotos { get; private set; }
        public GameItem() { }
        public GameItem(string palabra, Image[] imagenes) { }
    }
}
