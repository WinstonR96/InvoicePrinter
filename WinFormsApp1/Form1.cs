using Stubble.Core.Builders;
using Stubble.Extensions.StringFormatter;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private int n { get; set; } = 0;
        private string PlantillaPath { get; set; }
        private string InvoiceTemp { get; set; }

        string typeId { get; set; }
        public Form1()
        {
            InitializeComponent();
            var folder = Directory.GetCurrentDirectory();
            PlantillaPath = $"{folder}/invoice.txt";
            InvoiceTemp = $"{folder}/invoiceTemp.txt";
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += Imprimir;
            printDocument1.Print();
        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            try
            {

                Font font = new Font(new FontFamily(GenericFontFamilies.Monospace), 7, FontStyle.Regular, GraphicsUnit.Point);
                int y = 20;
                factura f = new factura()
                {
                    productos = GetProductos(ListProducts),
                    cliente = new cliente() { Identificador = $"{typeId} - {txtNumId.Text}", nombreCompleto = txtNombreCliente.Text}
                };
                double total = f.productos.Sum(x => x.total);
                f.totalFactura = total;
                var stubble = new StubbleBuilder()
                    .Configure(settings =>
                    {
                        settings.SetFormattedInterpolationTokenRenderer();
                    })
                    .Build();
                using (StreamReader streamReader = new StreamReader(PlantillaPath, Encoding.UTF8))
                {
                    var output = stubble.Render(streamReader.ReadToEnd(), f);
                    Console.WriteLine("Respuesta esperada");
                    Console.WriteLine(output);
                    StreamWriter sw = new StreamWriter(InvoiceTemp);
                    sw.WriteLine(output);
                    sw.Close();
                }
                foreach (string line in File.ReadLines(InvoiceTemp))
                {
                    e.Graphics.DrawString(line, font, Brushes.Black, new RectangleF(0, y += 20, 250, 20));
                }
                File.Delete(InvoiceTemp);         
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
               
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            n = ListProducts.Rows.Add();
            double cantidad = Convert.ToDouble(txtCantidad.Text);
            double precio = Convert.ToDouble(txtPrecio.Text);
            double total = cantidad * precio;
            ListProducts.Rows[n].Cells[0].Value = txtDescripcion.Text;
            ListProducts.Rows[n].Cells[1].Value = txtCantidad.Text;
            ListProducts.Rows[n].Cells[2].Value = txtPrecio.Text;
            ListProducts.Rows[n].Cells[3].Value = total.ToString();

            txtDescripcion.Text = "";
            txtCantidad.Text = "";
            txtPrecio.Text = "";
        }

        private void ListProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;

            if (n != -1)
            {
                lblInformacion.Text += (string)ListProducts.Rows[n].Cells[0].Value;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (n != -1)
            {
                ListProducts.Rows.RemoveAt(n);
            }
        }

        private void cmbIDType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = cmbIDType.SelectedIndex;
            typeId = cmbIDType.Items[indice].ToString();
        }

        private List<producto> GetProductos(DataGridView dataGridView)
        {
            List<producto> productos = new List<producto>();
            int cont = 1;
            int lenght = dataGridView.Rows.Count;
            foreach(DataGridViewRow row in dataGridView.Rows)
            {                
                if (cont < lenght)
                {
                    string descripcion = row.Cells["Descripcion"].Value.ToString();
                    double cantidad = Convert.ToDouble(row.Cells["Cantidad"].Value);
                    double precio = Convert.ToDouble(row.Cells["Precio"].Value);
                    producto producto = new producto(descripcion, cantidad, precio);
                    productos.Add(producto);
                    cont += 1;
                }
            }
            return productos;
        }
    }
}
