using MelanieComprasParcial2.Vista.Detalles;
using MelanieComprasParcial2.Vista.Encabezado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MelanieComprasParcial2
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void btnCatalogoEncabezado_Click(object sender, EventArgs e)
        {
            abrirForm(new VerEncabezado());
        }

        private void abrirForm(Form frm)
        {
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnCatalogoDetalles_Click(object sender, EventArgs e)
        {
            abrirForm(new VerDetalle());
        }

        private void btnAgregarEncabezado_Click(object sender, EventArgs e)
        {
            abrirForm(new AgregarEncabezado());
        }

        private void btnEliminarEncabezado_Click(object sender, EventArgs e)
        {
            abrirForm(new EliminarEncabezado());
        }

        private void btnActualizarEncabezado_Click(object sender, EventArgs e)
        {
            abrirForm(new ActualizarEncabezado());
        }

        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {
            abrirForm(new AgregarDetalle());
        }

        private void btnEliminarDetalle_Click(object sender, EventArgs e)
        {
            abrirForm(new EliminarDetalle());
        }

        private void btnActualizarDetalle_Click(object sender, EventArgs e)
        {
            abrirForm(new ActualizarDetalle());
        }
    }
}