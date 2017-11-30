using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4fotos
{
    class Jugada
    {
        public GameItem[] Palabras;

        public Jugada() { }


        void obtenerPalabras()
        {




        }
        public void AgregarPalabra(string palabra, Image[] imagenes) { }
        public void AgregarPalabra()
        {
            SqlConnection cnn = new SqlConnection(new Conexion().ConnectionString);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("Agregar",cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Palabra","CARRO");
            cmd.Parameters.AddWithValue("@Foto2", (Image)Properties.Resources.carro1);
            cmd.Parameters.AddWithValue("@Foto3", (Image)Properties.Resources.carro2);
            cmd.Parameters.AddWithValue("@Foto4", (Image)Properties.Resources.carro3);
            cmd.ExecuteNonQuery();

            cnn.Close();
            




        }











    }
}
