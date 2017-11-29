using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoJuego
{
    public partial class frm_Menu : Form
    {

        GameManager g = new GameManager();

        public frm_Menu()
        {
            InitializeComponent();
        }
        private void btnJugar_Click(object sender, EventArgs e)
        {
            var g = new Juego();
            g.ShowDialog();
            this.Show();
        }
        private void frm_Menu_Load(object sender, EventArgs e)
        {
            ImageConverter conveer = new ImageConverter();

            // var foto = (byte[])conveer.ConvertTo(Properties.Resources.carro,typeof(byte[]));


            //g.agregar(new Jugada("CARRO", (byte[])conveer.ConvertTo(Properties.Resources.carro, typeof(byte[])), (byte[])conveer.ConvertTo(Properties.Resources.carro1, typeof(byte[])), (byte[])conveer.ConvertTo(Properties.Resources.carro2, typeof(byte[])), (byte[])conveer.ConvertTo(Properties.Resources.carro3, typeof(byte[]))));
            //g.agregar(new Jugada("PERRO", (byte[])conveer.ConvertTo(Properties.Resources.perro, typeof(byte[])), (byte[])conveer.ConvertTo(Properties.Resources.perro1, typeof(byte[])), (byte[])conveer.ConvertTo(Properties.Resources.perro2, typeof(byte[])), (byte[])conveer.ConvertTo(Properties.Resources.perro3, typeof(byte[]))));


        }
    }
}
