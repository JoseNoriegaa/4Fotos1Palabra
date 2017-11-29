using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoJuego
{
    public partial class Juego : Form
    {
        GameManager g = new GameManager();
        public string  Palabra{get;set;} 
        private List<Jugada> palabras { get; set; }
        public Juego()
        {
            InitializeComponent();
        }

        private void Juego_Load(object sender, EventArgs e)
        {
            asignarPalabra();
        }
        void asignarPalabra()
        {
            
           palabras= g.GetList();
            int rnd = new Random().Next(0, palabras.Count);
            Palabra = palabras[rnd].palabraId;
            Pb_1.BackgroundImage = (Bitmap)((new ImageConverter()).ConvertFrom(palabras[rnd].foto1));
            Pb_1.BackgroundImageLayout = ImageLayout.Stretch;

            Pb_2.BackgroundImage = (Bitmap)((new ImageConverter()).ConvertFrom(palabras[rnd].foto2));
            Pb_2.BackgroundImageLayout = ImageLayout.Stretch;

            Pb_3.BackgroundImage = (Bitmap)((new ImageConverter()).ConvertFrom(palabras[rnd].foto3));
            Pb_3.BackgroundImageLayout = ImageLayout.Stretch;

            Pb_4.BackgroundImage = (Bitmap)((new ImageConverter()).ConvertFrom(palabras[rnd].foto4));
            Pb_4.BackgroundImageLayout = ImageLayout.Stretch;







        }



    }
}
