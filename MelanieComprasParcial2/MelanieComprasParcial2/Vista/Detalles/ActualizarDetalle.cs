﻿using MelanieComprasParcial2.Controlador.Detalles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MelanieComprasParcial2.Vista.Detalles
{
    public partial class ActualizarDetalle : Form
    {
        public ActualizarDetalle()
        {
            InitializeComponent();
            ControladorActualizarDetalle ControladorActualizarDetalle = new ControladorActualizarDetalle();
        }
    }
}