using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoJuego
{
    public partial class frm_Menu : Form
    {
        Juego game = new Juego();
        GameManager g = new GameManager();
        bool ventanaActiva = false;

        public frm_Menu()
        {
            InitializeComponent();
        }
        private void btnJugar_Click(object sender, EventArgs e)
        {
            ventanaActiva = true;
            game.ShowDialog();
            
        }
        private void frm_Menu_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ventanaActiva)
            {
                if (game.bandera)
                {
                    this.Show();
                    ventanaActiva = false;
                }
                else
                {
                    this.Hide();
                }

            }
        }
    }
}
