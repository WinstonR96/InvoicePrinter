using System.Collections.Generic;

namespace WinFormsApp1
{
    class factura
    {
        public double totalFactura { get; set; }

        public List<producto> productos { get; set; }
        public cliente cliente { get; set; }
    }
}
