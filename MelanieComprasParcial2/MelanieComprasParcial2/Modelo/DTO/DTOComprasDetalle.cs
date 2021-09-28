using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelanieComprasParcial2.Modelo.DTO
{
    public class DTOComprasDetalle
    {
        public string documento_compraenca { get; set; }
        public string codigo_producto { get; set; }
        public float cantidad_compradet { get; set; }
        public float costo_compradet { get; set; }
        public string codigo_bodega { get; set; }

        public DTOComprasDetalle()
        {
        }
    }
}