using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol_Capa_Entidades
{
    public class E_Productos
    {
        public int codigo_pr { get; set; }
        public string descripcion_pr { get; set; }
        public int codigo_ma { get; set; }
        public int codigo_um { get; set; }
        public int codigo_ca { get; set; }
        public int stock_min { get; set; }
        public decimal stock_max { get; set; }
    }
}
