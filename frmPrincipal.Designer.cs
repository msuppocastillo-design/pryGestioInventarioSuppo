namespace pryGestioInventarioSuppo
{
    partial class frmFuncionalidades
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuncionalidades));
            this.tbAgregarProd = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.mrcDatos = new System.Windows.Forms.GroupBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tbBusquedas = new System.Windows.Forms.TabPage();
            this.mrcMB = new System.Windows.Forms.GroupBox();
            this.cmbCategoriaBusq = new System.Windows.Forms.ComboBox();
            this.lblCategoriaMB = new System.Windows.Forms.Label();
            this.mrcBusqueda = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtCodigoBusq = new System.Windows.Forms.TextBox();
            this.lblCodigoMB = new System.Windows.Forms.Label();
            this.txtStockBusq = new System.Windows.Forms.TextBox();
            this.txtPrecioBusq = new System.Windows.Forms.TextBox();
            this.txtDescripcionBusq = new System.Windows.Forms.TextBox();
            this.txtNombreBusq = new System.Windows.Forms.TextBox();
            this.lblNombreMB = new System.Windows.Forms.Label();
            this.lblDescripcionMB = new System.Windows.Forms.Label();
            this.lblPrecioMB = new System.Windows.Forms.Label();
            this.lblStockMB = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.tbReportes = new System.Windows.Forms.TabPage();
            this.cboTipoReporte = new System.Windows.Forms.ComboBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.chartInventario = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelConex = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbAgregarProd.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.mrcDatos.SuspendLayout();
            this.tbBusquedas.SuspendLayout();
            this.mrcMB.SuspendLayout();
            this.mrcBusqueda.SuspendLayout();
            this.tbReportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartInventario)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbAgregarProd
            // 
            this.tbAgregarProd.Controls.Add(this.tabPage1);
            this.tbAgregarProd.Controls.Add(this.tbBusquedas);
            this.tbAgregarProd.Controls.Add(this.tbReportes);
            this.tbAgregarProd.Location = new System.Drawing.Point(9, 10);
            this.tbAgregarProd.Margin = new System.Windows.Forms.Padding(2);
            this.tbAgregarProd.Name = "tbAgregarProd";
            this.tbAgregarProd.SelectedIndex = 0;
            this.tbAgregarProd.Size = new System.Drawing.Size(663, 405);
            this.tbAgregarProd.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.mrcDatos);
            this.tabPage1.Controls.Add(this.btnAgregar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(655, 379);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar Productos";
            // 
            // mrcDatos
            // 
            this.mrcDatos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mrcDatos.Controls.Add(this.cmbCategoria);
            this.mrcDatos.Controls.Add(this.txtStock);
            this.mrcDatos.Controls.Add(this.txtPrecio);
            this.mrcDatos.Controls.Add(this.lblCategoria);
            this.mrcDatos.Controls.Add(this.txtCodigo);
            this.mrcDatos.Controls.Add(this.txtDescripcion);
            this.mrcDatos.Controls.Add(this.txtNombre);
            this.mrcDatos.Controls.Add(this.lblCodigo);
            this.mrcDatos.Controls.Add(this.lblNombre);
            this.mrcDatos.Controls.Add(this.lblDescripcion);
            this.mrcDatos.Controls.Add(this.lblPrecio);
            this.mrcDatos.Controls.Add(this.lblStock);
            this.mrcDatos.Location = new System.Drawing.Point(14, 9);
            this.mrcDatos.Name = "mrcDatos";
            this.mrcDatos.Size = new System.Drawing.Size(624, 309);
            this.mrcDatos.TabIndex = 2;
            this.mrcDatos.TabStop = false;
            this.mrcDatos.Enter += new System.EventHandler(this.mrcDatos_Enter);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(132, 24);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(164, 21);
            this.cmbCategoria.TabIndex = 1;
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(132, 267);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(164, 24);
            this.txtStock.TabIndex = 6;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(132, 217);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(164, 24);
            this.txtPrecio.TabIndex = 5;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(6, 24);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(109, 21);
            this.lblCategoria.TabIndex = 10;
            this.lblCategoria.Text = "CATEGORIA";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(132, 71);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(164, 20);
            this.txtCodigo.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(132, 167);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(453, 24);
            this.txtDescripcion.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(132, 117);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(453, 24);
            this.txtNombre.TabIndex = 3;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(6, 74);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(82, 21);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "CÓDIGO";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(6, 124);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 21);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "NOMBRE";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(6, 174);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(120, 21);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "DESCRIPCIÓN";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(6, 224);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(70, 21);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "PRECIO";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(6, 274);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(62, 21);
            this.lblStock.TabIndex = 1;
            this.lblStock.Text = "STOCK";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(269, 324);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(111, 40);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // tbBusquedas
            // 
            this.tbBusquedas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbBusquedas.Controls.Add(this.mrcMB);
            this.tbBusquedas.Controls.Add(this.btnEliminar);
            this.tbBusquedas.Controls.Add(this.btnModificar);
            this.tbBusquedas.Location = new System.Drawing.Point(4, 22);
            this.tbBusquedas.Margin = new System.Windows.Forms.Padding(2);
            this.tbBusquedas.Name = "tbBusquedas";
            this.tbBusquedas.Padding = new System.Windows.Forms.Padding(2);
            this.tbBusquedas.Size = new System.Drawing.Size(655, 379);
            this.tbBusquedas.TabIndex = 1;
            this.tbBusquedas.Text = "Modificación y Bajas";
            this.tbBusquedas.Click += new System.EventHandler(this.tbBusquedas_Click);
            // 
            // mrcMB
            // 
            this.mrcMB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mrcMB.Controls.Add(this.cmbCategoriaBusq);
            this.mrcMB.Controls.Add(this.lblCategoriaMB);
            this.mrcMB.Controls.Add(this.mrcBusqueda);
            this.mrcMB.Controls.Add(this.txtStockBusq);
            this.mrcMB.Controls.Add(this.txtPrecioBusq);
            this.mrcMB.Controls.Add(this.txtDescripcionBusq);
            this.mrcMB.Controls.Add(this.txtNombreBusq);
            this.mrcMB.Controls.Add(this.lblNombreMB);
            this.mrcMB.Controls.Add(this.lblDescripcionMB);
            this.mrcMB.Controls.Add(this.lblPrecioMB);
            this.mrcMB.Controls.Add(this.lblStockMB);
            this.mrcMB.Location = new System.Drawing.Point(14, 9);
            this.mrcMB.Name = "mrcMB";
            this.mrcMB.Size = new System.Drawing.Size(625, 305);
            this.mrcMB.TabIndex = 3;
            this.mrcMB.TabStop = false;
            // 
            // cmbCategoriaBusq
            // 
            this.cmbCategoriaBusq.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoriaBusq.FormattingEnabled = true;
            this.cmbCategoriaBusq.Location = new System.Drawing.Point(136, 81);
            this.cmbCategoriaBusq.Name = "cmbCategoriaBusq";
            this.cmbCategoriaBusq.Size = new System.Drawing.Size(168, 29);
            this.cmbCategoriaBusq.TabIndex = 1;
            // 
            // lblCategoriaMB
            // 
            this.lblCategoriaMB.AutoSize = true;
            this.lblCategoriaMB.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaMB.Location = new System.Drawing.Point(19, 90);
            this.lblCategoriaMB.Name = "lblCategoriaMB";
            this.lblCategoriaMB.Size = new System.Drawing.Size(96, 20);
            this.lblCategoriaMB.TabIndex = 10;
            this.lblCategoriaMB.Text = "CATEGORIA";
            // 
            // mrcBusqueda
            // 
            this.mrcBusqueda.BackColor = System.Drawing.Color.Gainsboro;
            this.mrcBusqueda.Controls.Add(this.button2);
            this.mrcBusqueda.Controls.Add(this.txtCodigoBusq);
            this.mrcBusqueda.Controls.Add(this.lblCodigoMB);
            this.mrcBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcBusqueda.Location = new System.Drawing.Point(13, 19);
            this.mrcBusqueda.Name = "mrcBusqueda";
            this.mrcBusqueda.Size = new System.Drawing.Size(583, 56);
            this.mrcBusqueda.TabIndex = 12;
            this.mrcBusqueda.TabStop = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(366, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 27);
            this.button2.TabIndex = 2;
            this.button2.Text = "BUSCAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtCodigoBusq
            // 
            this.txtCodigoBusq.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoBusq.Location = new System.Drawing.Point(123, 14);
            this.txtCodigoBusq.Name = "txtCodigoBusq";
            this.txtCodigoBusq.Size = new System.Drawing.Size(168, 27);
            this.txtCodigoBusq.TabIndex = 2;
            // 
            // lblCodigoMB
            // 
            this.lblCodigoMB.AutoSize = true;
            this.lblCodigoMB.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoMB.Location = new System.Drawing.Point(6, 21);
            this.lblCodigoMB.Name = "lblCodigoMB";
            this.lblCodigoMB.Size = new System.Drawing.Size(76, 20);
            this.lblCodigoMB.TabIndex = 0;
            this.lblCodigoMB.Text = "CÓDIGO";
            // 
            // txtStockBusq
            // 
            this.txtStockBusq.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockBusq.Location = new System.Drawing.Point(425, 263);
            this.txtStockBusq.Name = "txtStockBusq";
            this.txtStockBusq.Size = new System.Drawing.Size(171, 27);
            this.txtStockBusq.TabIndex = 6;
            // 
            // txtPrecioBusq
            // 
            this.txtPrecioBusq.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioBusq.Location = new System.Drawing.Point(136, 263);
            this.txtPrecioBusq.Name = "txtPrecioBusq";
            this.txtPrecioBusq.Size = new System.Drawing.Size(168, 27);
            this.txtPrecioBusq.TabIndex = 5;
            // 
            // txtDescripcionBusq
            // 
            this.txtDescripcionBusq.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionBusq.Location = new System.Drawing.Point(136, 203);
            this.txtDescripcionBusq.Name = "txtDescripcionBusq";
            this.txtDescripcionBusq.Size = new System.Drawing.Size(460, 27);
            this.txtDescripcionBusq.TabIndex = 4;
            // 
            // txtNombreBusq
            // 
            this.txtNombreBusq.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreBusq.Location = new System.Drawing.Point(136, 143);
            this.txtNombreBusq.Name = "txtNombreBusq";
            this.txtNombreBusq.Size = new System.Drawing.Size(460, 27);
            this.txtNombreBusq.TabIndex = 3;
            // 
            // lblNombreMB
            // 
            this.lblNombreMB.AutoSize = true;
            this.lblNombreMB.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMB.Location = new System.Drawing.Point(19, 149);
            this.lblNombreMB.Name = "lblNombreMB";
            this.lblNombreMB.Size = new System.Drawing.Size(74, 20);
            this.lblNombreMB.TabIndex = 4;
            this.lblNombreMB.Text = "NOMBRE";
            // 
            // lblDescripcionMB
            // 
            this.lblDescripcionMB.AutoSize = true;
            this.lblDescripcionMB.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionMB.Location = new System.Drawing.Point(19, 208);
            this.lblDescripcionMB.Name = "lblDescripcionMB";
            this.lblDescripcionMB.Size = new System.Drawing.Size(111, 20);
            this.lblDescripcionMB.TabIndex = 3;
            this.lblDescripcionMB.Text = "DESCRIPCIÓN";
            // 
            // lblPrecioMB
            // 
            this.lblPrecioMB.AutoSize = true;
            this.lblPrecioMB.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioMB.Location = new System.Drawing.Point(19, 270);
            this.lblPrecioMB.Name = "lblPrecioMB";
            this.lblPrecioMB.Size = new System.Drawing.Size(65, 20);
            this.lblPrecioMB.TabIndex = 2;
            this.lblPrecioMB.Text = "PRECIO";
            // 
            // lblStockMB
            // 
            this.lblStockMB.AutoSize = true;
            this.lblStockMB.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockMB.Location = new System.Drawing.Point(342, 270);
            this.lblStockMB.Name = "lblStockMB";
            this.lblStockMB.Size = new System.Drawing.Size(55, 20);
            this.lblStockMB.TabIndex = 1;
            this.lblStockMB.Text = "STOCK";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(381, 320);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(111, 40);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(133, 320);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(111, 40);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // tbReportes
            // 
            this.tbReportes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbReportes.Controls.Add(this.cboTipoReporte);
            this.tbReportes.Controls.Add(this.dgvProductos);
            this.tbReportes.Controls.Add(this.btnGenerar);
            this.tbReportes.Controls.Add(this.chartInventario);
            this.tbReportes.Location = new System.Drawing.Point(4, 22);
            this.tbReportes.Margin = new System.Windows.Forms.Padding(2);
            this.tbReportes.Name = "tbReportes";
            this.tbReportes.Padding = new System.Windows.Forms.Padding(2);
            this.tbReportes.Size = new System.Drawing.Size(655, 379);
            this.tbReportes.TabIndex = 2;
            this.tbReportes.Text = "Reportes";
            this.tbReportes.Click += new System.EventHandler(this.tbReportes_Click);
            // 
            // cboTipoReporte
            // 
            this.cboTipoReporte.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoReporte.FormattingEnabled = true;
            this.cboTipoReporte.Location = new System.Drawing.Point(4, 30);
            this.cboTipoReporte.Margin = new System.Windows.Forms.Padding(2);
            this.cboTipoReporte.Name = "cboTipoReporte";
            this.cboTipoReporte.Size = new System.Drawing.Size(187, 25);
            this.cboTipoReporte.TabIndex = 3;
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(195, 30);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.Size = new System.Drawing.Size(444, 308);
            this.dgvProductos.TabIndex = 2;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(56, 73);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(83, 42);
            this.btnGenerar.TabIndex = 1;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // chartInventario
            // 
            chartArea1.Name = "ChartArea1";
            this.chartInventario.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartInventario.Legends.Add(legend1);
            this.chartInventario.Location = new System.Drawing.Point(212, 50);
            this.chartInventario.Margin = new System.Windows.Forms.Padding(2);
            this.chartInventario.Name = "chartInventario";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartInventario.Series.Add(series1);
            this.chartInventario.Size = new System.Drawing.Size(441, 299);
            this.chartInventario.TabIndex = 0;
            this.chartInventario.Text = "chart1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelConex});
            this.statusStrip1.Location = new System.Drawing.Point(0, 426);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(685, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelConex
            // 
            this.toolStripStatusLabelConex.Name = "toolStripStatusLabelConex";
            this.toolStripStatusLabelConex.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabelConex.Text = "toolStripStatusLabel1";
            // 
            // frmFuncionalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 448);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tbAgregarProd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFuncionalidades";
            this.Text = "Gestion de Inventario";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.frmFuncionalidades_Load);
            this.tbAgregarProd.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.mrcDatos.ResumeLayout(false);
            this.mrcDatos.PerformLayout();
            this.tbBusquedas.ResumeLayout(false);
            this.mrcMB.ResumeLayout(false);
            this.mrcMB.PerformLayout();
            this.mrcBusqueda.ResumeLayout(false);
            this.mrcBusqueda.PerformLayout();
            this.tbReportes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartInventario)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbAgregarProd;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox mrcDatos;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TabPage tbBusquedas;
        private System.Windows.Forms.TabPage tbReportes;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelConex;
        private System.Windows.Forms.GroupBox mrcMB;
        private System.Windows.Forms.GroupBox mrcBusqueda;
        private System.Windows.Forms.Label lblCategoriaMB;
        private System.Windows.Forms.TextBox txtCodigoBusq;
        private System.Windows.Forms.Label lblCodigoMB;
        private System.Windows.Forms.TextBox txtStockBusq;
        private System.Windows.Forms.TextBox txtPrecioBusq;
        private System.Windows.Forms.TextBox txtDescripcionBusq;
        private System.Windows.Forms.TextBox txtNombreBusq;
        private System.Windows.Forms.Label lblNombreMB;
        private System.Windows.Forms.Label lblDescripcionMB;
        private System.Windows.Forms.Label lblPrecioMB;
        private System.Windows.Forms.Label lblStockMB;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.ComboBox cmbCategoriaBusq;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartInventario;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.ComboBox cboTipoReporte;
        private System.Windows.Forms.DataGridView dgvProductos;
    }
}