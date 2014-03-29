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
        public static C_LISTAS listas = new C_LISTAS();

        public ppl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listados rep = new Listados();
            rep.Show();
        }

        private void registrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            regCli_pan.Visible = false;
            regAalq_pan.Visible = false;
            regVehi_pan.Visible = true;
            placa_box.Focus();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            regVehi_pan.Visible = false;
            regAalq_pan.Visible = false;
            regCli_pan.Visible = true;
            ci_box.Focus();
        }

        private void alquilarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            regVehi_pan.Visible = false;
            regCli_pan.Visible = false;
            f_alq_dtp.Value = DateTime.Now;
            cli_cbox.Items.Clear();
            vehi_cbox.Items.Clear();

            foreach (C_CLIENTES cli in ppl.listas.listaClientes)
                cli_cbox.Items.Add(cli.datos()[0] + "-" + cli.datos()[2] + ", " + cli.datos()[1]);

            foreach (C_VEHICULOS vehi in ppl.listas.listaVehiculos)
                if(vehi.datos()[6]=="Disponible")
                    vehi_cbox.Items.Add(vehi.datos()[0]);

            regAalq_pan.Visible = true;
            cli_cbox.Focus();
        }

        private void registrar_btn_Click(object sender, EventArgs e)
        {
            if(ci_box.Text != "" && nom_box.Text != "" && ape_box.Text != "" && dir_box.Text != "" && telf_box.Text != "")
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
                    ci_box.SelectAll();
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos");
            }
        }

        private void regVehi_btn_Click(object sender, EventArgs e)
        {
            if (placa_box.Text != "" && marca_box.Text != "" && model_box.Text != "" && condi_box.Text != "" && km_box.Text != "" && anio_box.Text != "") {
                
            
                if (listas.llenarListaVehiculos(new C_VEHICULOS(placa_box.Text, marca_box.Text, model_box.Text, condi_box.Text, km_box.Text, anio_box.Text,dia_box.Text,seg_box.Text)))
                {
                    regVehi_pan.Visible = false;
                    placa_box.Clear();
                    marca_box.Clear();
                    model_box.Clear();
                    anio_box.Clear();
                    condi_box.Text = "";
                    km_box.Clear();
                    dia_box.Clear();
                    seg_box.Clear();

                    regAalq_pan.Visible = false;
                }
                else
                {
                    MessageBox.Show("EL Automovil ya esta registrado");
                    placa_box.Focus();
                    placa_box.SelectAll();
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos");
            }
        }

        private void regAlq_btn_Click(object sender, EventArgs e)
        {
            string ci;
            if(f_alq_dtp.Value >= DateTime.Today)
                if(cli_cbox.SelectedIndex >= 0)
                    if(Convert.ToInt16(dias_mbox.Text) >=1)
                        if (vehi_cbox.SelectedIndex >= 0)
                        {
                            ci = cli_cbox.Text.Split('-')[0];

                            if (listas.llenarListaAlquiler(new C_ALQUILER(ci, vehi_cbox.Text, f_alq_dtp.Value, Convert.ToDouble(monto_box.Text), Convert.ToInt16(dias_mbox.Text))))
                                regAalq_pan.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Debe seleccionar un vehiculo de la lista");
                            vehi_cbox.Focus();
                        }
                    else
                    {
                        MessageBox.Show("Los dias de alquiler deben ser al menos 1");
                        dias_mbox.Focus();
                    }

                else
                {
                    MessageBox.Show("Debe seleccionar un Cliente registrado");
                    regAalq_pan.Hide();
                    regCli_pan.Show();
                }
            else
            {
                MessageBox.Show("Debe seleccionar una fecha en el futuro");
                f_alq_dtp.Focus();
            }
        }

        private void clrCli_btn_Click(object sender, EventArgs e)
        {
            ci_box.Clear();
            nom_box.Clear();
            ape_box.Clear();
            dir_box.Clear();
            telf_box.Clear();

            ci_box.Focus();
        }

        private void clrVehi_btn_Click(object sender, EventArgs e)
        {
            placa_box.Clear();
            marca_box.Clear();
            model_box.Clear();
            anio_box.Clear();
            condi_box.Text = "";
            km_box.Clear();
            dia_box.Clear();
            seg_box.Clear();

            placa_box.Focus();
        }

        private void clrAlq_btn_Click(object sender, EventArgs e)
        {
            f_alq_dtp.Value = DateTime.Now;
            cli_cbox.Text = "";
            dias_mbox.Clear();
            vehi_cbox.Text = "";
            monto_box.Clear();

            cli_cbox.Focus();
        }

        private void calcMonto_btn_Click(object sender, EventArgs e)
        {
            string placa;

            if (dias_mbox.Text != "")
            {
                if (vehi_cbox.SelectedIndex >= 0)
                {
                    placa = vehi_cbox.Text.Split('-')[0];
                    C_VEHICULOS car = listas.listaVehiculos.Find(
                        delegate(C_VEHICULOS c)
                        {
                            return c.comaprarCarros(placa);
                        });
                    string[] d = car.datos();
                    //MessageBox.Show("placa "+d[0]+" marca"+d[1]);
                    monto_box.Text = Convert.ToString(Convert.ToInt16(dias_mbox.Text) *Convert.ToInt16(d[7]) + Convert.ToInt32(d[8]));
                    regAlq_btn.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un vehiculo registrado");
                    vehi_cbox.Focus();
                }
            }
            else
            {
                MessageBox.Show("Debe definir los dias de alquiler");
                dias_mbox.Focus();
            }
        }

    }
}
