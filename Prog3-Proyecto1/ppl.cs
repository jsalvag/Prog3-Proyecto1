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
    public partial class ppl : Form
    {
        C_LISTAS listas = new C_LISTAS();

        public ppl()
        {
            InitializeComponent();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            regCli_pan.Visible = true;
            ci_box.Focus();
        }

        private void ppl_Load(object sender, EventArgs e)
        {

        }

        private void registrar_btn_Click(object sender, EventArgs e)
        {
            if (listas.llenarListaCliente(new C_CLIENTES(ci_box.Text, nom_box.Text, ape_box.Text, dir_box.Text, telf_box.Text)))
            {
                regCli_pan.Visible = false;
                ci_box.Clear();
                nom_box.Clear();
                ape_box.Clear();
                dir_box.Clear();
                telf_box.Clear();
            }
            else
            {
                MessageBox.Show("EL Cliente ya esta registrado");
                ci_box.Focus();
            }
        }

        private void registrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            regVehi_pan.Visible = true;
            placa_box.Focus();
        }

        private void regVehi_btn_Click(object sender, EventArgs e)
        {
            if (listas.llenarListaVehiculos(new C_VEHICULOS(placa_box.Text, marca_box.Text, model_box.Text, condi_box.Text, km_box.Text, anio_box.Text)))
            {
                regVehi_pan.Visible = false;
                placa_box.Clear();
                marca_box.Clear();
                model_box.Clear();
                anio_box.Clear();
                condi_box.Clear();
                km_box.Clear();
            }
            else
            {
                MessageBox.Show("EL Automovil ya esta registrado");
                placa_box.Focus();
            }
        }
    }
}
