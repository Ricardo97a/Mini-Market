using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol_Capa_Entidades
{
    public class E_Salida_Productos
    {
        public int codigo_sp { get; set; }
        public int codigo_tde{ get; set; }
        public string nrodocumento_sp{ get; set; }
        public int codigo_cl{ get; set; }
        public string nrodocumento_cl { get; set; }
        public string razon_social_cl { get; set; }
        public DateTime Fecha_sp{ get; set; }       
        public string observacion{ get; set; }
        public decimal subtotal{ get; set; }
        public decimal iva{ get; set; }
        public decimal importe_total{ get; set; }

        

    }
}
