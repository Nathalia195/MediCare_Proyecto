﻿using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Negocio_Puesto
    {
        DatosPuesto obj_datosPuesto = new DatosPuesto();

        public List<EntidadPuesto> GetPuesto()
        {
            return obj_datosPuesto.GetPuesto();
        }
    }
}
