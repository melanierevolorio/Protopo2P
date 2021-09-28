using MelanieComprasParcial2.Modelo.DAO;
using MelanieComprasParcial2.Modelo.DTO;
using MelanieComprasParcial2.Vista.Detalles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MelanieComprasParcial2.Controlador.Detalles
{
    class ControladorVerDetalle
    {
        private VerDetalle catalogo = null;

        public ControladorVerDetalle(VerDetalle Catalogo)
        {
            catalogo = Catalogo;
            DAOComprasDetalle ver = new DAOComprasDetalle();
            var list = ver.MostrarDetalles();
            var bindingList = new BindingList<DTOComprasDetalle>(list);
            var source = new BindingSource(bindingList, null);
            catalogo.DGVDetalles.DataSource = source;
        }
    }
}