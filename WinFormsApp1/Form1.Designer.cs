
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.ListProducts = new System.Windows.Forms.DataGridView();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbIDType = new System.Windows.Forms.ComboBox();
            this.txtNumId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ListProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListProducts
            // 
            this.ListProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descripcion,
            this.Cantidad,
            this.Precio,
            this.Total});
            this.ListProducts.Location = new System.Drawing.Point(79, 275);
            this.ListProducts.Name = "ListProducts";
            this.ListProducts.RowHeadersWidth = 62;
            this.ListProducts.RowTemplate.Height = 33;
            this.ListProducts.Size = new System.Drawing.Size(676, 205);
            this.ListProducts.TabIndex = 1;
            this.ListProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListProducts_CellClick);
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.MinimumWidth = 8;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 150;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 8;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 150;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 8;
            this.Precio.Name = "Precio";
            this.Precio.Width = 150;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 8;
            this.Total.Name = "Total";
            this.Total.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cantidad";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(440, 66);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(150, 31);
            this.txtDescripcion.TabIndex = 5;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(440, 164);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(150, 31);
            this.txtPrecio.TabIndex = 6;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(440, 116);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(150, 31);
            this.txtCantidad.TabIndex = 7;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(694, 88);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(112, 34);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(694, 142);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(112, 34);
            this.btnBorrar.TabIndex = 9;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Location = new System.Drawing.Point(330, 224);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(195, 25);
            this.lblInformacion.TabIndex = 10;
            this.lblInformacion.Text = "Información Producto: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(527, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Agregar Producto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cliente";
            // 
            // cmbIDType
            // 
            this.cmbIDType.FormattingEnabled = true;
            this.cmbIDType.Items.AddRange(new object[] {
            "C.C.",
            "T.I.",
            "NIT",
            "PS",
            "C.E."});
            this.cmbIDType.Location = new System.Drawing.Point(31, 58);
            this.cmbIDType.Name = "cmbIDType";
            this.cmbIDType.Size = new System.Drawing.Size(182, 33);
            this.cmbIDType.TabIndex = 14;
            this.cmbIDType.Text = "Tipo ID";
            this.cmbIDType.SelectedIndexChanged += new System.EventHandler(this.cmbIDType_SelectedIndexChanged);
            // 
            // txtNumId
            // 
            this.txtNumId.Location = new System.Drawing.Point(31, 142);
            this.txtNumId.Name = "txtNumId";
            this.txtNumId.Size = new System.Drawing.Size(182, 31);
            this.txtNumId.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Digite Número";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(31, 218);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(182, 31);
            this.txtNombreCliente.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Nombre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 545);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNumId);
            this.Controls.Add(this.cmbIDType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblInformacion);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListProducts);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ListProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridView ListProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbIDType;
        private System.Windows.Forms.TextBox txtNumId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label8;
    }
}

