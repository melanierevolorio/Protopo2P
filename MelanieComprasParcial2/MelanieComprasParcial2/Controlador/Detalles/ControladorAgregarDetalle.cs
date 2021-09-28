using MelanieComprasParcial2.Modelo.DAO;
using MelanieComprasParcial2.Modelo.DTO;
using MelanieComprasParcial2.Vista.Detalles;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelanieComprasParcial2.Controlador.Detalles
{
    public class ControladorAgregarDetalle
    {
        private AgregarDetalle mantinsertar = null;

        public ControladorAgregarDetalle(AgregarDetalle Mantenimiento)
        {
            mantinsertar = Mantenimiento;
            mantinsertar.btnInsertarDetalle.Click += BtnInsertarDetalle_Click; ;
        }

        private void BtnInsertarDetalle_Click(object sender, EventArgs e)
        {
            DAOComprasDetalle modeloAgregar = new DAOComprasDetalle();
            DTOComprasDetalle modelo = new DTOComprasDetalle();
            modelo.cantidad_compradet = float.Parse(mantinsertar.txtCantidadProducto.Text, CultureInfo.InvariantCulture.NumberFormat); ;
            modelo.codigo_bodega = mantinsertar.txtCodigoBodega.Text;
            modelo.documento_compraenca = mantinsertar.txtCodigoEncabezado.Text;
            modelo.codigo_producto = mantinsertar.txtCodigoProducto.Text;
            modelo.costo_compradet = float.Parse(mantinsertar.txtCostoProductos.Text, CultureInfo.InvariantCulture.NumberFormat);

            modeloAgregar.AgregarDetalle(modelo);
        }
    }
}