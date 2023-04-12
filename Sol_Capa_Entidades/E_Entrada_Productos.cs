using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol_Capa_Entidades
{
    public class E_Entrada_Productos
    {
        public int codigo_ep { get; set; }
        public int codigo_tde{ get; set; }
        public string nrodocumento_ep{ get; set; }
        public int codigo_pv{ get; set; }
        public DateTime Fecha_ep{ get; set; }
        public int codigo_al{ get; set; }
        public string observacion{ get; set; }
        public decimal subtotal{ get; set; }
        public decimal iva{ get; set; }
        public decimal importe_total{ get; set; }

        

    }
}
