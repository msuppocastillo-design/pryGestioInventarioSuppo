using System;
using System.Collections.Generic;
using System.Data;
//para conexion de ACcess
using System.Data.OleDb;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pryGestioInventarioSuppo
{
    internal class clsConexionBD
    {
        public static string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../dbGestiondeInventario.accdb";

        OleDbConnection coneccionBaseDatos;
        OleDbCommand comandoBaseDatos;
        OleDbDataReader lectorDataReader;
       

        public string nombreBaseDeDatos;
        public string mensaje = "";

        public void ConectarBD(ToolStripStatusLabel label)
        {
            try
            {
                //coneccionBaseDatos = new SqlConnection(cadenaConexion);
                coneccionBaseDatos = new OleDbConnection(cadenaConexion);

                nombreBaseDeDatos = coneccionBaseDatos.Database;

                coneccionBaseDatos.Open();
                label.Text = "Conectado a base de datos";
                label.BackColor = System.Drawing.Color.LightBlue;
                
             
            }
            catch (Exception error)
            {

                label.Text = "Error al conectar "+ error.Message;
                label.BackColor = System.Drawing.Color.LightBlue;
            }     

        }

        public void CargarCategorias(ComboBox categoria)
        {
            comandoBaseDatos = new OleDbCommand();
            comandoBaseDatos.Connection = coneccionBaseDatos;
            comandoBaseDatos.CommandType =System.Data.CommandType.Text;
            comandoBaseDatos.CommandText = "SELECT DISTINCT Categoría FROM Productos ";
            lectorDataReader = comandoBaseDatos.ExecuteReader();

            while (lectorDataReader.Read())
            {
                categoria.Items.Add(lectorDataReader[0]);
            }

        }

        public void AgregarProducto(Int32 id, string cat, string nom, string desc, Int32 prec, Int32 stock)
        {
            comandoBaseDatos = new OleDbCommand();
            comandoBaseDatos.Connection = coneccionBaseDatos;
            comandoBaseDatos.CommandType = System.Data.CommandType.Text;
            comandoBaseDatos.CommandText = "INSERT INTO Productos (Código, Categoría, Nombre, Descripción, Precio, Stock) " +
                                               "VALUES (" + id + ", '" + cat + "', '" + nom + "', '" + desc + "', " + prec + ", " + stock + ")";
            comandoBaseDatos.ExecuteNonQuery();

        }
        public int ObtenerProximoCodigo()
        {
            int proximoCodigo = 1;
            try
            {
                // Usamos la conexión ya abierta
                comandoBaseDatos = new OleDbCommand();
                comandoBaseDatos.Connection = coneccionBaseDatos;
                comandoBaseDatos.CommandType = System.Data.CommandType.Text;
                comandoBaseDatos.CommandText = "SELECT MAX(Código) FROM Productos";
                object resultado = comandoBaseDatos.ExecuteScalar();
                if (resultado != DBNull.Value)
                {
                    proximoCodigo = Convert.ToInt32(resultado) + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el próximo código: " + ex.Message);
            }
            return proximoCodigo;
        }

        public bool BuscarProducto(int codigo, TextBox txtNombreBusq, TextBox txtDescripcionBusq, ComboBox cmbCategoriaBusq, TextBox txtPrecioBusq, TextBox txtStockBusq)
        {
            bool encontrado = false;

            try
            {
                comandoBaseDatos = new OleDbCommand();
                comandoBaseDatos.Connection = coneccionBaseDatos;
                comandoBaseDatos.CommandType = CommandType.Text;
                comandoBaseDatos.CommandText = "SELECT * FROM Productos WHERE Código = @codigo";
                comandoBaseDatos.Parameters.AddWithValue("@codigo", codigo);

                OleDbDataReader lector = comandoBaseDatos.ExecuteReader();

                if (lector.Read())
                {
                    txtNombreBusq.Text = lector["Nombre"].ToString();
                    txtDescripcionBusq.Text = lector["Descripción"].ToString();
                    cmbCategoriaBusq.Text = lector["Categoría"].ToString();
                    txtPrecioBusq.Text = lector["Precio"].ToString();
                    txtStockBusq.Text = lector["Stock"].ToString();
                    encontrado = true;
                }
                else
                {
                    MessageBox.Show("No se encontró ningún producto con ese código.", "Buscar producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                lector.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el producto: " + ex.Message);
            }

            return encontrado;
        }
        
        public bool ModificarProducto( int codigo, string nombre, string descripcion, string categoria, int precio, int stock)
        {
            bool actualizado = false;

            try
            {
                comandoBaseDatos = new OleDbCommand();
                comandoBaseDatos.Connection = coneccionBaseDatos;
                comandoBaseDatos.CommandType = CommandType.Text;
                comandoBaseDatos.CommandText = "UPDATE Productos " +
                                               "SET Nombre = @nombre, " +
                                               "Descripción = @descripcion, " +
                                               "Categoría = @categoria, " +
                                               "Precio = @precio, " +
                                               "Stock = @stock " +
                                               "WHERE Código = @codigo";

                comandoBaseDatos.Parameters.AddWithValue("@nombre", nombre);
                comandoBaseDatos.Parameters.AddWithValue("@descripcion", descripcion);
                comandoBaseDatos.Parameters.AddWithValue("@categoria", categoria);
                comandoBaseDatos.Parameters.AddWithValue("@precio", precio);
                comandoBaseDatos.Parameters.AddWithValue("@stock", stock);
                comandoBaseDatos.Parameters.AddWithValue("@codigo", codigo);

                int filasAfectadas = comandoBaseDatos.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    actualizado = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return actualizado;
        }
        public bool EliminarProducto(int codigo)
        {
            bool eliminado = false;

            try
            {
                comandoBaseDatos = new OleDbCommand();
                comandoBaseDatos.Connection = coneccionBaseDatos;
                comandoBaseDatos.CommandType = CommandType.Text;
                comandoBaseDatos.CommandText = "DELETE FROM Productos WHERE Código = @codigo";
                comandoBaseDatos.Parameters.AddWithValue("@codigo", codigo);

                int filasAfectadas = comandoBaseDatos.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    eliminado = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return eliminado;
        }
      
    }

}

