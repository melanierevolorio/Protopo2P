using MelanieComprasParcial2.Modelo.DAO;
using MelanieComprasParcial2.Modelo.DTO;
using MelanieComprasParcial2.Vista.Encabezado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MelanieComprasParcial2.Controlador
{
    class ControladorVerEncabezado
    {
        private VerEncabezado catalogo = null;

        public ControladorVerEncabezado(VerEncabezado Catalogo)
        {
            catalogo = Catalogo;
            DAOComprasEncabezado ver = new DAOComprasEncabezado();
            var list = ver.MostrarDetalles();
            var bindingList = new BindingList<DTOComprasEncabezado>(list);
            var source = new BindingSource(bindingList, null);
            catalogo.DGVDetalles.DataSource = source;
        }
    }
}