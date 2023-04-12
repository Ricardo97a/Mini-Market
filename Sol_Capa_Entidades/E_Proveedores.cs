using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol_Capa_Entidades
{
    public class E_Proveedores
    {   
        public int codigo_pv { get; set; }
        public int codigo_tdpc { get; set; }
        public string NroDocumento_pv { get; set; }
        public string Razon_Social_pv { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int codigo_sx { get; set; }
        public int codigo_ru { get; set; }
        public string email_pv { get; set; }
        public string telefono_pv { get; set; }
        public string movil_pv { get; set; }
        public string direccion_pv { get; set; }
        public int codigo_di { get; set; }
        public string observaciones_pv { get; set; }
    }
}
