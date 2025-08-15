using Modelos.Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelos.Entidades
{
    public class Zapato
    {
        private int idzapato;
        private int idCategoria;
        private string nombre;
        private double precio;
        private string imagenURL;
        private DateTime fechaCreacion;

        public int Idzapato { get => idzapato; set => idzapato = value; }
        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }
        public string ImagenURL { get => imagenURL; set => imagenURL = value; }
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        public static DataTable cargarZapatos()
        {
            try
            {
                SqlConnection conexion = ConexionDB.Conectar();
                string cadena = "Select *from vistasCategorias";
                SqlDataAdapter data = new SqlDataAdapter(cadena, conexion);
                DataTable tablaVirtual = new DataTable();
                data.Fill(tablaVirtual);
                return tablaVirtual;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos"+ ex);
                return null;
            }
        }
        //Metodo de insertar datos
        public bool insertarZapatos() {
            try
            {
                //Siempre traer la conexion
                SqlConnection conexion = ConexionDB.Conectar();
                string consultaQueryInsert = "insert into Zapatos (CategoriaId, Nombre, Precio, ImagenURL, FechaCreacion) values (@CategoriaId, @Nombre, @Precio, @ImagenURL, @FechaCreacion);";
                SqlCommand insertar = new SqlCommand(consultaQueryInsert, conexion);
                //Vamos a insertar o sustituir los @nombre con los datos que se obtienen en los txt
                insertar.Parameters.AddWithValue("@CategoriaId", idCategoria);
                insertar.Parameters.AddWithValue("@Nombre", nombre);
                insertar.Parameters.AddWithValue("@Precio", precio);
                insertar.Parameters.AddWithValue("@ImagenURL", imagenURL);
                insertar.Parameters.AddWithValue("@FechaCreacion", fechaCreacion);
                insertar.ExecuteNonQuery();
                return true;

            }
            catch ( Exception ex)
            {
                MessageBox.Show("Verifica si la consulta de insertar esta correcta" +ex, "Error al insertar datos", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
