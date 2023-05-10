using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol_Capa_Entidades
{
    public class E_Usuarios
    {   
        public int codigo_us { get; set; }
        public string login_us { get; set; }
        public string nombre_us { get; set; }
        public string password { get; set; }
        public string cargo_us { get; set; }
        public bool admin { get; set; }
    }
}
