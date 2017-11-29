using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoJuego
{
    public partial class Juego : Form
    {
        GameManager g = new GameManager();
        public string Palabra { get; set; }
        private List<Jugada> palabras { get; set; }
        List<Button> botones = new List<Button>();
        List<Label> respuestas=new List<Label>();
        private Char[] compare;
        public bool bandera = false;

        public Juego()
        {
            palabras = g.GetList();

            InitializeComponent();

        }

        private void Juego_Load(object sender, EventArgs e)
        {
            bandera = false;
            using (fWaitForTask fwait = new fWaitForTask())
            {
                fwait.ActionToExecute = asignarPalabra;
                fwait.ShowDialog();
            }

            CargarBotones();
            lbl_nivel.Text = "1";
            timer1.Enabled = true;
        }
        void resetGame()
        {
            strikes = 0;
            palabras = g.GetList();
            asignarPalabra();
            asignarBotones();
            GamePad(true);
            timer1.Enabled = true;
            lbl_nivel.Text = "1";
        }

        void CargarBotones()
        {
            botones.Add(btn1);
            botones.Add(btn2);
            botones.Add(btn3);
            botones.Add(btn4);
            botones.Add(btn5);
            botones.Add(btn6);
            botones.Add(btn7);
            botones.Add(btn8);
            botones.Add(btn9);
            botones.Add(btn10);

            respuestas.Add(res1);
            respuestas.Add(res2);
            respuestas.Add(res3);
            respuestas.Add(res4);
            respuestas.Add(res5);
            respuestas.Add(res6);
            respuestas.Add(res7);
            respuestas.Add(res8);
            respuestas.Add(res9);
            respuestas.Add(res10);
            RespuestasReset();
            asignarBotones();
        

        }
        void RespuestasReset()
        {
            foreach (var item in respuestas)
            {
                item.Text = "";
            }
        }
        void asignarPalabra()
        {
            if (palabras.Count == 0)
            {
                if (MessageBox.Show("Palabras agotadas, no es posible continuar.", "Game", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    resetGame();
                    timer1.Enabled = false;
                    this.Hide();

                }
            }
            else
            {
                int rnd = new Random().Next(0, palabras.Count);
                Palabra = palabras[rnd].palabraId;
                compare = new char[Palabra.Length];
                Pb_1.BackgroundImage = (Bitmap)((new ImageConverter()).ConvertFrom(palabras[rnd].foto1));
                Pb_1.BackgroundImageLayout = ImageLayout.Stretch;

                Pb_2.BackgroundImage = (Bitmap)((new ImageConverter()).ConvertFrom(palabras[rnd].foto2));
                Pb_2.BackgroundImageLayout = ImageLayout.Stretch;

                Pb_3.BackgroundImage = (Bitmap)((new ImageConverter()).ConvertFrom(palabras[rnd].foto3));
                Pb_3.BackgroundImageLayout = ImageLayout.Stretch;

                Pb_4.BackgroundImage = (Bitmap)((new ImageConverter()).ConvertFrom(palabras[rnd].foto4));
                Pb_4.BackgroundImageLayout = ImageLayout.Stretch;
                palabras.RemoveAt(rnd);
            }
        }
        int strikes = 0;

        private void Juego_FormClosing(object sender, FormClosingEventArgs e)
        {
            resetGame();
            timer1.Enabled = false;
            bandera = true;
        }

       bool validar(string value)
        {
            bool bandera = false; 
            for (int i = 0; i < Palabra.Length; i++)
            {
                if (Palabra[i].ToString()==value)
                {
                    compare[i] = Palabra[i];
                    bandera = true;
                }
            }
            if (!bandera)
            {
                strikes++;
            }
          
            return true;

        }





        void asignarBotones()
        {
            List<char> temp = new List<char>();

            for (int i = 0; i < Palabra.Length; i++)
            {
                temp.Add( Palabra[i]);
            }
            int index = 0;
            for (int i = 0; i < botones.Count; i++)
            {
                if (i%2==0)
                {
                    if (temp.Count > 0)
                    {

                        index = new Random().Next(0, temp.Count);
                        botones[i].Text = temp[index].ToString();
                        temp.RemoveAt(index);
                    }
                }
                else
                {
                    botones[i].Text = Convert.ToChar(new Random().Next(65,90)).ToString();
                }
                Thread.Sleep(15);
                
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            btn1.Enabled=!validar(btn1.Text);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            btn9.Enabled = !validar(btn9.Text);

        }

        private void btn8_Click(object sender, EventArgs e)
        {
           btn8.Enabled = !validar(btn8.Text);

        }

        private void btn7_Click(object sender, EventArgs e)
        {
          btn7.Enabled = !validar(btn7.Text);

        }

        private void btn6_Click(object sender, EventArgs e)
        {
           btn6.Enabled = !validar(btn6.Text);

        }

        private void btn5_Click(object sender, EventArgs e)
        {
           btn5.Enabled = !validar(btn5.Text);

        }

        private void btn4_Click(object sender, EventArgs e)
        {
         btn4.Enabled = !validar(btn4.Text);

        }

        private void btn3_Click(object sender, EventArgs e)
        {
          btn3.Enabled = !validar(btn3.Text);

        }

        private void btn2_Click(object sender, EventArgs e)
        {
          btn2.Enabled = !validar(btn2.Text);

        }

        private void btn10_Click(object sender, EventArgs e)
        {
         btn10.Enabled = !validar(btn10.Text);

        }
        void GamePad(bool enable)
        {
            foreach (var item in botones)
            {
                item.Enabled = enable;
                if (enable)
                {
                    item.BackColor = Color.White;
                }
                else
                {
                    item.BackColor = Color.Green;
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < compare.Length; i++)
            {
                respuestas[i].Text = compare[i].ToString();
            }
            if (IsCorrect())
            {
                timer1.Enabled = false;
                GamePad(false);
                strikes = 0;
                if (MessageBox.Show("Has pasado de nivel.","Level UP!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation)==DialogResult.OK)
                {
                    nextLevel();
                }
            }


            if (strikes>=3)
            {
                GamePad(false);
                timer1.Enabled = false;

                if (MessageBox.Show("Has Perdido.","3 strikes",MessageBoxButtons.OK,MessageBoxIcon.Exclamation)==DialogResult.OK)
                {
                    resetGame();
                    bandera = true;
                    this.Hide();
                }
                timer1.Enabled = false;
                strikes = 0;
            }





        }
        
        void nextLevel()
        {
            CargarBotones();
            asignarPalabra();
            asignarBotones();
            for (int i = 0; i < compare.Length; i++)
            {
                compare[i] = ' ';
            }
            strikes = 0;
            int level = int.Parse(lbl_nivel.Text);
            level++;
            lbl_nivel.Text = level.ToString();
            timer1.Enabled = true;
            GamePad(true);
        }
        bool IsCorrect()
        {
            for (int i = 0; i < Palabra.Length; i++)
            {
                if (Palabra[i]!=compare[i])
                {
                    return false;
                }
            }
            return true;
        }

    }
}
