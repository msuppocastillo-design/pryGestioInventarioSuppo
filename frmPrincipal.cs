using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace pryGestioInventarioSuppo
{
    public partial class frmFuncionalidades : Form
    {
        clsConexionBD clsConexionBD = new clsConexionBD();
        public frmFuncionalidades()
        {
            InitializeComponent();
        }

      
        private void frmFuncionalidades_Load(object sender, EventArgs e)
        {
           
            clsConexionBD.ConectarBD(toolStripStatusLabelConex);
            clsConexionBD.CargarCategorias(cmbCategoria);
            clsConexionBD.CargarCategorias(cmbCategoriaBusq);
            txtCodigo.Text = clsConexionBD.ObtenerProximoCodigo().ToString();

            cboTipoReporte.Items.Add("Listado general de productos");
            cboTipoReporte.Items.Add("Productos por categoría");
            cboTipoReporte.Items.Add("Productos con bajo stock");
            cboTipoReporte.SelectedIndex = 0; // valor por defecto

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                //TENGO QUE CORREGIR PARA QUE TOME LA CATEGORIA QUE ES Y NO CARGUE UN CERO.
                //
                clsConexionBD clsConexionBD = new clsConexionBD();
                clsConexionBD.ConectarBD(toolStripStatusLabelConex);
                clsConexionBD.AgregarProducto(Convert.ToInt32(txtCodigo.Text), Convert.ToString(cmbCategoria.Text), txtNombre.Text, txtDescripcion.Text, Convert.ToInt32(txtPrecio.Text), Convert.ToInt32(txtStock.Text));
               
                MessageBox.Show("Producto agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
        }

        private bool ValidarCampos()
        {
            // Verifica que la categoría esté seleccionada
            if (string.IsNullOrWhiteSpace(cmbCategoria.Text))
            {
                MessageBox.Show("Debe seleccionar una categoría.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCategoria.Focus();
                return false;
            }
            // Verifica el código
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Debe ingresar un código.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
                return false;
            }
            // Verifica el nombre
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar un nombre.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }
            // Verifica la descripción
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Debe ingresar una descripción.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescripcion.Focus();
                return false;
            }
            // Verifica el precio
            if (string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("Debe ingresar un precio.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
                return false;
            }
            // Verifica el stock
            if (string.IsNullOrWhiteSpace(txtStock.Text))
            {
                MessageBox.Show("Debe ingresar el stock.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStock.Focus();
                return false;
            }
            // Todo está completo
            return true;
        }

        private void LimpiarCampos()
        {
            // 🔹 Cerramos y volvemos a abrir la conexión para refrescar los datos
            clsConexionBD.ConectarBD(toolStripStatusLabelConex);

            // 🔹 Ahora sí obtenemos el nuevo código
            txtCodigo.Text = clsConexionBD.ObtenerProximoCodigo().ToString();
            cmbCategoria.SelectedIndex = -1;
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtStock.Clear();

            // Si querés que el foco vuelva al primer campo
            txtCodigo.Focus();
        }
        private void LimpiarCamposBusq()
        {
            txtCodigoBusq.Clear();
            txtNombreBusq.Clear();
            txtDescripcionBusq.Clear();
            cmbCategoriaBusq.SelectedIndex = -1;
            txtPrecioBusq.Clear();
            txtStockBusq.Clear();
        }

        private void mrcDatos_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigoBusq.Text))
            {
                MessageBox.Show("Debe ingresar un código para buscar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigoBusq.Focus();
                return;
            }

            clsConexionBD clsConexionBD = new clsConexionBD();
            clsConexionBD.ConectarBD(toolStripStatusLabelConex);

            if (int.TryParse(txtCodigoBusq.Text, out int codigo))
            {
                bool encontrado = clsConexionBD.BuscarProducto(
                    codigo,
                    txtNombreBusq,
                    txtDescripcionBusq,
                    cmbCategoriaBusq,
                    txtPrecioBusq,
                    txtStockBusq
                );

                if (encontrado)
                {
                    toolStripStatusLabelConex.Text = "Producto encontrado.";
                    toolStripStatusLabelConex.BackColor = Color.LightGreen;
                }
                else
                {
                    toolStripStatusLabelConex.Text = "Producto no encontrado.";
                    toolStripStatusLabelConex.BackColor = Color.LightPink;
                }
            }
            else
            {
                MessageBox.Show("El código debe ser numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigoBusq.Focus();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigoBusq.Text))
            {
                MessageBox.Show("Debe ingresar un código de producto válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigoBusq.Focus();
                return;
            }

            if (!int.TryParse(txtCodigoBusq.Text, out int codigo))
            {
                MessageBox.Show("El código debe ser numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtPrecioBusq.Text, out int precio) || !int.TryParse(txtStockBusq.Text, out int stock))
            {
                MessageBox.Show("El precio y el stock deben ser valores numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsConexionBD clsConexionBD = new clsConexionBD();
            clsConexionBD.ConectarBD(toolStripStatusLabelConex);

            bool actualizado = clsConexionBD.ModificarProducto(
                codigo,
                txtNombreBusq.Text,
                txtDescripcionBusq.Text,
                cmbCategoriaBusq.Text,
                precio,
                stock
            );

            if (actualizado)
            {
                MessageBox.Show("Producto modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                toolStripStatusLabelConex.Text = "Producto actualizado correctamente";
                toolStripStatusLabelConex.BackColor = Color.LightGreen;
                LimpiarCamposBusq();
            }
            else
            {
                MessageBox.Show("No se pudo modificar el producto. Verifique el código ingresado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                toolStripStatusLabelConex.Text = "Error al modificar producto";
                toolStripStatusLabelConex.BackColor = Color.LightPink;
            }
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigoBusq.Text))
            {
                MessageBox.Show("Debe ingresar un código de producto válido para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigoBusq.Focus();
                return;
            }

            if (!int.TryParse(txtCodigoBusq.Text, out int codigo))
            {
                MessageBox.Show("El código debe ser numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                "¿Está seguro de que desea eliminar este producto?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacion == DialogResult.Yes)
            {
                clsConexionBD clsConexionBD = new clsConexionBD();
                clsConexionBD.ConectarBD(toolStripStatusLabelConex);

                bool eliminado = clsConexionBD.EliminarProducto(codigo);

                if (eliminado)
                {
                    MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    toolStripStatusLabelConex.Text = "Producto eliminado correctamente";
                    toolStripStatusLabelConex.BackColor = Color.LightGreen;
                    LimpiarCamposBusq();
                }
                else
                {
                    MessageBox.Show("No se encontró el producto para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    toolStripStatusLabelConex.Text = "Error al eliminar producto";
                    toolStripStatusLabelConex.BackColor = Color.LightPink;
                }
            }
            else
            {
                toolStripStatusLabelConex.Text = "Eliminación cancelada";
                toolStripStatusLabelConex.BackColor = Color.LightYellow;
            }
        }

        private void tbReportes_Click(object sender, EventArgs e)
        {
      
        }

        public void btnGenerar_Click(object sender, EventArgs e)
        {
            string opcion = cboTipoReporte.SelectedItem.ToString();

            if (opcion == "Listado general de productos")
            {
                MostrarGrillaGeneral();
            }
            else if (opcion == "Productos por categoría")
            {
                MostrarGraficoPorCategoria();
            }
            else if (opcion == "Productos con bajo stock")
            {
                MostrarBajoStock();
            }
        }

        public void MostrarGrillaGeneral()
        {
            chartInventario.Visible = false;
            dgvProductos.Visible = true;

            using (OleDbConnection conexion = new OleDbConnection(clsConexionBD.cadenaConexion))
            {
                string consulta = "SELECT [Código], [Categoría], [Nombre], [Descripción], [Precio], [Stock] FROM Productos";
                OleDbDataAdapter adaptador = new OleDbDataAdapter(consulta, conexion);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dgvProductos.DataSource = tabla;
            }

            // Colores según stock
            foreach (DataGridViewRow fila in dgvProductos.Rows)
            {
                if (fila.Cells["Stock"].Value != null && fila.Cells["Stock"].Value.ToString() != "")
                {
                    int stock = Convert.ToInt32(fila.Cells["Stock"].Value);
                    if (stock < 3)
                        fila.DefaultCellStyle.BackColor = Color.LightCoral; // rojo
                    else if (stock > 10)
                        fila.DefaultCellStyle.BackColor = Color.LightGreen; // verde
                }
            }
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // 📊 2. Gráfico de productos por categoría
        public void MostrarGraficoPorCategoria()
        {
            dgvProductos.Visible = false;
            chartInventario.Visible = true;
            chartInventario.Series.Clear();
            chartInventario.ChartAreas.Clear();

            chartInventario.ChartAreas.Add(new ChartArea("MainArea"));
            Series serie = new Series("Productos por Categoría");
            serie.ChartType = SeriesChartType.Column;
            serie.IsValueShownAsLabel = true;

            using (OleDbConnection conexion = new OleDbConnection(clsConexionBD.cadenaConexion))
            {
                conexion.Open();
                string consulta = "SELECT [Categoría], COUNT(*) AS Cantidad FROM Productos GROUP BY [Categoría]";
                OleDbCommand comando = new OleDbCommand(consulta, conexion);
                OleDbDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    string categoria = lector["Categoría"].ToString();
                    int cantidad = Convert.ToInt32(lector["Cantidad"]);
                    serie.Points.AddXY(categoria, cantidad);
                }
            }

            chartInventario.Series.Add(serie);
            chartInventario.Titles.Clear();
            chartInventario.Titles.Add("Cantidad de productos por categoría");
        }

        // ⚠️ 3. Productos con bajo stock
        public void MostrarBajoStock()
        {
            chartInventario.Visible = false;
            dgvProductos.Visible = true;
            using (OleDbConnection conexion = new OleDbConnection(clsConexionBD.cadenaConexion))
            {
                conexion.Open();
                string consulta = "SELECT [Código], [Categoría], [Nombre], [Descripción], [Precio], [Stock] FROM Productos WHERE [Stock] < 3";
                OleDbDataAdapter adaptador = new OleDbDataAdapter(consulta, conexion);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dgvProductos.DataSource = tabla;
            }

            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            foreach (DataGridViewRow fila in dgvProductos.Rows)
            {
                fila.DefaultCellStyle.BackColor = Color.LightCoral;
            }
        }

        private void tbBusquedas_Click(object sender, EventArgs e)
        {

        }
    }
}
