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
    class ControladorEliminarEncabezado
    {
        private EliminarEncabezado manteliminar = null;

        public ControladorEliminarEncabezado(EliminarEncabezado EliminarDetalle)
        {
            manteliminar = EliminarDetalle;
            manteliminar.btnEliminarDetalle.Click += BtnEliminarDetalle_Click; ;
            manteliminar.DGVDetalles.CellClick += DGVDetalles_CellClick1; ;

            DAOComprasEncabezado ver = new DAOComprasEncabezado();
            var list = ver.MostrarDetalles();
            var bindingList = new BindingList<DTOComprasEncabezado>(list);
            var source = new BindingSource(bindingList, null);
            manteliminar.DGVDetalles.DataSource = source;
        }

        private void DGVDetalles_CellClick1(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            manteliminar.txtEliminarEncabezado.Text = manteliminar.DGVDetalles.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void BtnEliminarDetalle_Click(object sender, EventArgs e)
        {
            DAOComprasDetalle modeloactualizar = new DAOComprasDetalle();
            DTOComprasDetalle modelo = new DTOComprasDetalle();

            modelo.documento_compraenca = manteliminar.txtEliminarEncabezado.Text;

            modeloactualizar.EliminarDetalle(modelo);

            var list = modeloactualizar.MostrarDetalles();
            var bindingList = new BindingList<DTOComprasDetalle>(list);
            var source = new BindingSource(bindingList, null);
            manteliminar.DGVDetalles.DataSource = source;
        }
    }
}