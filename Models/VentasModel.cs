using System;
using System.Collections.Generic;

namespace cosmetics.Models
{
    public class VentasModel
    {
        public int IdVentas { get; set; }

        public string FormaPago { get; set; }

        public DateTime Hora { get; set; }

        public string Marca { get; set; }

        public ClienteModel Cliente { get; set; }

        public List<ProductosModel> Productos = new List<ProductosModel>();
    }
}