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
    public partial class fWaitForTask : Form
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public Image Picture { get; set; }
        public Action ActionToExecute { get; set; }

        public fWaitForTask()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void fWaitForTask_Load(object sender, EventArgs e)
        {
        }
        private void taskCompleted()
        {
            if (InvokeRequired)
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    Close();
                    DialogResult = DialogResult.OK;
                }));
            }
        }

        private void fWaitForTask_Shown(object sender, EventArgs e)
        {
            Task.Factory.StartNew(ActionToExecute).ContinueWith((t) => taskCompleted());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
        }
    }
}
