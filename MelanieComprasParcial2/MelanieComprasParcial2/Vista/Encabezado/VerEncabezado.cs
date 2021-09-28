using MelanieComprasParcial2.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MelanieComprasParcial2.Vista.Encabezado
{
    public partial class VerEncabezado : Form
    {
        public VerEncabezado()
        {
            InitializeComponent();
            ControladorVerEncabezado ControladorVerEncabezado = new ControladorVerEncabezado(this);
        }
    }
}