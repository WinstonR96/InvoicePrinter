namespace WinFormsApp1
{
    class producto
    {
        public string descripcion { get; set; }
        public double cantidad { get; set; }

        public double precio { get; set; }

        public double total { get; set; }

        public producto(string descripcion, double cantidad, double precio)
        {
            this.descripcion = descripcion;
            this.cantidad = cantidad;
            this.precio = precio;
            this.total = this.cantidad * this.precio;
        }
    }
}
