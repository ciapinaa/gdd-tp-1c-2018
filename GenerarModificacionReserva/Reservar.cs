﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.GenerarModificacionReserva
{
    public partial class Reservar : Form
    {
        private static Reservar instancia = null;

        public static Reservar obtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new Reservar();
            }
            return instancia;
        }

        private Reservar()
        {
            InitializeComponent();
        }
    }
}
