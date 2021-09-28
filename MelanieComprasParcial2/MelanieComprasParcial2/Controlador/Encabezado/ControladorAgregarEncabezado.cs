using MelanieComprasParcial2.Modelo.DAO;
using MelanieComprasParcial2.Modelo.DTO;
using MelanieComprasParcial2.Vista.Encabezado;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelanieComprasParcial2.Controlador
{
    class ControladorAgregarEncabezado
    {
        private AgregarEncabezado mantinsertar = null;

        public ControladorAgregarEncabezado(AgregarEncabezado Mantenimiento)
        {
            mantinsertar = Mantenimiento;
            mantinsertar.btnInsertarDetalle.Click += BtnInsertarDetalle_Click; ;
        }

        private void BtnInsertarDetalle_Click(object sender, EventArgs e)
        {
            DAOComprasEncabezado modeloAgregar = new DAOComprasEncabezado();
            DTOComprasEncabezado modelo = new DTOComprasEncabezado();
            modelo.documento_compraenca = mantinsertar.txtCodigoEncabezado.Text;
            modelo.codigo_proveedor = mantinsertar.txtCodigoProveedor.Text;
            modelo.total_compraenca = float.Parse(mantinsertar.txtTotal.Text, CultureInfo.InvariantCulture.NumberFormat);
            modelo.estatus_compraenca = mantinsertar.txtEncEstatus.Text;

            modeloAgregar.AgregarDetalle(modelo);
        }
    }
}