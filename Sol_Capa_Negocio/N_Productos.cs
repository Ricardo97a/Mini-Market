﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sol_Capa_Datos;
using Sol_Capa_Entidades;

namespace Sol_Capa_Negocio
{
    public class N_Productos
    {

        public static DataTable Listado_pr(string ctexto)
        {
            D_Productos Datos = new D_Productos();
            return Datos.Listado_pr(ctexto);
        }

        public static string Guardar_pr(int nopcion, E_Productos oPR)
        {
            D_Productos Datos = new D_Productos();
            return Datos.Guardar_pr(nopcion, oPR);
        }
        public static string Eliminar_pr(int codigo_pr)
        {
            D_Productos Datos = new D_Productos();
            return Datos.Eliminar_pr(codigo_pr);
        }
    }
}
