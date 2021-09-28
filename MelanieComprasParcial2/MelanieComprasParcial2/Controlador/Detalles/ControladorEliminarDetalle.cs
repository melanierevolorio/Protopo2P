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
    class ControladorEliminarDetalle
    {
        private EliminarDetalle manteliminar = null;

        public ControladorEliminarDetalle(EliminarDetalle EliminarDetalle)
        {
            manteliminar = EliminarDetalle;
            manteliminar.btnEliminarDetalle.Click += BtnEliminarDetalle_Click; ;
            manteliminar.DGVDetalles.CellClick += DGVDetalles_CellClick; ; ;

            DAOComprasDetalle ver = new DAOComprasDetalle();
            var list = ver.MostrarDetalles();
            var bindingList = new BindingList<DTOComprasDetalle>(list);
            var source = new BindingSource(bindingList, null);
            manteliminar.DGVDetalles.DataSource = source;
        }

        private void DGVDetalles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            manteliminar.txtEliminarEncabezado.Text = manteliminar.DGVDetalles.SelectedRows[0].Cells[0].Value.ToString();
            manteliminar.txtEliminarProducto.Text = manteliminar.DGVDetalles.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void BtnEliminarDetalle_Click(object sender, EventArgs e)
        {
            DAOComprasDetalle modeloactualizar = new DAOComprasDetalle();
            DTOComprasDetalle modelo = new DTOComprasDetalle();

            modelo.documento_compraenca = manteliminar.txtEliminarEncabezado.Text;
            modelo.codigo_producto = manteliminar.txtEliminarProducto.Text;

            modeloactualizar.EliminarDetalle(modelo);

            var list = modeloactualizar.MostrarDetalles();
            var bindingList = new BindingList<DTOComprasDetalle>(list);
            var source = new BindingSource(bindingList, null);
            manteliminar.DGVDetalles.DataSource = source;
        }
    }
}