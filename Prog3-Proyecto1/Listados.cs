using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prog3_Proyecto1
{
    public partial class Listados : Form
    {

        public Listados()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cliDGV.Rows.Clear();
            vehiDGV.Visible = false;
            alqDGV.Visible = false;
            cliDGV.Visible = true;

            foreach (C_CLIENTES cli in ppl.listas.listaClientes)
                cliDGV.Rows.Add(cli.datos());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            vehiDGV.Rows.Clear();
            cliDGV.Visible = false;
            alqDGV.Visible = false;
            vehiDGV.Visible = true;

            foreach (C_VEHICULOS vehi in ppl.listas.listaVehiculos)
                vehiDGV.Rows.Add(vehi.datos());
        }

        private void alq_btn_Click(object sender, EventArgs e)
        {
            alqDGV.Rows.Clear();
            cliDGV.Visible = false;
            vehiDGV.Visible = false;
            alqDGV.Visible = true;

            foreach (C_ALQUILER alq in ppl.listas.listaAlquiler)
                alqDGV.Rows.Add(alq.datos());
        }
    }
}
