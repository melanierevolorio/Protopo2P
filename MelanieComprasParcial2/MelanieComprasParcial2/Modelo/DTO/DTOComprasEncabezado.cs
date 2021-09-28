using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelanieComprasParcial2.Modelo.DTO
{
    public class DTOComprasEncabezado
    {
        public string documento_compraenca { get; set; }
        public string codigo_proveedor { get; set; }
        public DateTime fecha_compraenca { get; set; }
        public float total_compraenca { get; set; }
        public string estatus_compraenca { get; set; }

        public DTOComprasEncabezado()
        {
            fecha_compraenca = DateTime.Now;
        }
    }
}