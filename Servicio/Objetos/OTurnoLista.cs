﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
namespace Servicio.Objetos
{
    public class OTurnoLista:RespuestaBase
    {
        public IEnumerable<Turno> TurnoLista { get; set; }
    }
}
