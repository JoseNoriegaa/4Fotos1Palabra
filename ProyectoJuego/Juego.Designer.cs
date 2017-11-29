namespace ProyectoJuego
{
    partial class Juego
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.Pb_4 = new System.Windows.Forms.PictureBox();
            this.Pb_3 = new System.Windows.Forms.PictureBox();
            this.Pb_2 = new System.Windows.Forms.PictureBox();
            this.Pb_1 = new System.Windows.Forms.PictureBox();
            this.lbl_Puntaje = new System.Windows.Forms.Label();
            this.lbl_nivel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::ProyectoJuego.Properties.Resources.score;
            this.pictureBox6.Location = new System.Drawing.Point(233, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(43, 40);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::ProyectoJuego.Properties.Resources.Niveles;
            this.pictureBox5.Location = new System.Drawing.Point(114, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(81, 72);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // Pb_4
            // 
            this.Pb_4.Location = new System.Drawing.Point(157, 246);
            this.Pb_4.Name = "Pb_4";
            this.Pb_4.Size = new System.Drawing.Size(119, 113);
            this.Pb_4.TabIndex = 3;
            this.Pb_4.TabStop = false;
            // 
            // Pb_3
            // 
            this.Pb_3.Location = new System.Drawing.Point(35, 246);
            this.Pb_3.Name = "Pb_3";
            this.Pb_3.Size = new System.Drawing.Size(116, 113);
            this.Pb_3.TabIndex = 2;
            this.Pb_3.TabStop = false;
            // 
            // Pb_2
            // 
            this.Pb_2.Location = new System.Drawing.Point(157, 128);
            this.Pb_2.Name = "Pb_2";
            this.Pb_2.Size = new System.Drawing.Size(119, 109);
            this.Pb_2.TabIndex = 1;
            this.Pb_2.TabStop = false;
            // 
            // Pb_1
            // 
            this.Pb_1.Location = new System.Drawing.Point(35, 128);
            this.Pb_1.Name = "Pb_1";
            this.Pb_1.Size = new System.Drawing.Size(116, 109);
            this.Pb_1.TabIndex = 0;
            this.Pb_1.TabStop = false;
            // 
            // lbl_Puntaje
            // 
            this.lbl_Puntaje.AutoSize = true;
            this.lbl_Puntaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Puntaje.ForeColor = System.Drawing.Color.White;
            this.lbl_Puntaje.Location = new System.Drawing.Point(269, 18);
            this.lbl_Puntaje.Name = "lbl_Puntaje";
            this.lbl_Puntaje.Size = new System.Drawing.Size(34, 31);
            this.lbl_Puntaje.TabIndex = 6;
            this.lbl_Puntaje.Text = "--";
            // 
            // lbl_nivel
            // 
            this.lbl_nivel.AutoSize = true;
            this.lbl_nivel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_nivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nivel.ForeColor = System.Drawing.Color.White;
            this.lbl_nivel.Location = new System.Drawing.Point(134, 36);
            this.lbl_nivel.Name = "lbl_nivel";
            this.lbl_nivel.Size = new System.Drawing.Size(31, 29);
            this.lbl_nivel.TabIndex = 7;
            this.lbl_nivel.Text = "--";
            // 
            // Juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(316, 439);
            this.Controls.Add(this.lbl_nivel);
            this.Controls.Add(this.lbl_Puntaje);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.Pb_4);
            this.Controls.Add(this.Pb_3);
            this.Controls.Add(this.Pb_2);
            this.Controls.Add(this.Pb_1);
            this.Name = "Juego";
            this.Text = "Juego";
            this.Load += new System.EventHandler(this.Juego_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pb_1;
        private System.Windows.Forms.PictureBox Pb_2;
        private System.Windows.Forms.PictureBox Pb_3;
        private System.Windows.Forms.PictureBox Pb_4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lbl_Puntaje;
        private System.Windows.Forms.Label lbl_nivel;
    }
}