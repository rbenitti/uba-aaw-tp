﻿using Domain;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion.UseCases.Propietario
{
    public class DetalleTurneroResponse
    {
        public int Id { get; set;  }
        public string IdPropietario { get; set; }
        public string Concepto { get; set; }
        public string Ciudad { get; set; }
        public string Calle { get; set; }
        public int Numero { get; set; }
        public string Qr { get; set; }
        public int CantidadMaxima { get; set; }
    }
}
