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
            
            listas.llenarListaCliente(new C_CLIENTES("16825525", "Jose", "Guevara", "Porlamar", "04168995399"));
            listas.llenarListaCliente(new C_CLIENTES("3489436", "Maria", "Marcano", "Porlamar", "04168885555"));
            listas.llenarListaCliente(new C_CLIENTES("13655092", "Claudia", "Muñoz", "La Asumcion", "04145554433"));
            listas.llenarListaCliente(new C_CLIENTES("11111111", "Luis", "Contreras", "Juangriego", "02951112233"));
            listas.llenarListaCliente(new C_CLIENTES("65432187", "Pedro", "Perez", "Pampatar", "04126543298"));

            listas.llenarListaVehiculos(new C_VEHICULOS("654asd", "Toyota", "Yaris", "Nuevo", "0", "2014", "1000", "6000"));
            listas.llenarListaVehiculos(new C_VEHICULOS("321qwe", "Toyota", "Corolla", "Nuevo", "0", "2014", "1500", "9000"));
            listas.llenarListaVehiculos(new C_VEHICULOS("987zxc", "Toyota", "Yaris", "Bueno", "100000", "2006", "600", "4000"));
            listas.llenarListaVehiculos(new C_VEHICULOS("963qaz", "Chevrolet", "Corsa", "Exelente", "60000", "2010", "800", "4000"));
            listas.llenarListaVehiculos(new C_VEHICULOS("852wsx", "Chevrolet", "Aveo", "Nuevo", "0", "2014", "1000", "6000"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listados rep = new Listados();
            rep.Show();
        }

        private void registrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            regCli_pan.Hide();
            regAalq_pan.Hide();
            recib_pan.Hide();
            regVehi_pan.Show();
            placa_box.Focus();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            regVehi_pan.Hide();
            regAalq_pan.Hide();
            recib_pan.Hide();
            regCli_pan.Show();
            ci_box.Focus();
        }

        private void alquilarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            regVehi_pan.Hide();
            regCli_pan.Hide();
            recib_pan.Hide();
            f_alq_dtp.Value = DateTime.Now;
            cli_cbox.Items.Clear();
            vehi_cbox.Items.Clear();

            foreach (C_CLIENTES cli in ppl.listas.listaClientes)
                cli_cbox.Items.Add(cli.datos()[0] + "-" + cli.datos()[2] + ", " + cli.datos()[1]);

            foreach (C_VEHICULOS vehi in ppl.listas.listaVehiculos)
                if(vehi.datos()[6]=="Disponible")
                    vehi_cbox.Items.Add(vehi.datos()[0]);

            regAalq_pan.Show();
            cli_cbox.Focus();
        }

        private void recibirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            regVehi_pan.Hide();
            regCli_pan.Hide();
            regAalq_pan.Hide();
            recVehi_cbox.Items.Clear();
            recVehi_cbox.Text = "";
            recib_pan.Show();
            foreach (C_VEHICULOS vehi in ppl.listas.listaVehiculos)
                if (vehi.datos()[6] == "En Alquiler")
                    recVehi_cbox.Items.Add(vehi.datos()[0]);
        }

        private void registrar_btn_Click(object sender, EventArgs e)
        {
            if(ci_box.Text != "" && nom_box.Text != "" && ape_box.Text != "" && dir_box.Text != "" && telf_box.Text != "")
            {
                if (listas.llenarListaCliente(new C_CLIENTES(ci_box.Text, nom_box.Text, ape_box.Text, dir_box.Text, telf_box.Text)))
                {
                    regCli_pan.Hide();
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
                    regVehi_pan.Hide();
                    placa_box.Clear();
                    marca_box.Clear();
                    model_box.Clear();
                    anio_box.Clear();
                    condi_box.Text = "";
                    km_box.Clear();
                    dia_box.Clear();
                    seg_box.Clear();

                    regAalq_pan.Hide();
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
                if (cli_cbox.SelectedIndex >= 0)
                    if(Convert.ToInt16(dias_mbox.Text) > 0)
                        if (vehi_cbox.SelectedIndex >= 0)
                        {
                            ci = cli_cbox.Text.Split('-')[0];
                            //if(listas.listaClientes.Contains(
                            if (listas.llenarListaAlquiler(new C_ALQUILER(ci, vehi_cbox.Text, f_alq_dtp.Value, Convert.ToDouble(monto_box.Text), Convert.ToInt16(dias_mbox.Text))))
                            {
                                C_VEHICULOS ent = listas.listaVehiculos.FirstOrDefault(o => o.getPlaca() == vehi_cbox.Text); //otro metodo para buscar un objeto conparando propiedades
                                ent.setEstado(false);
                                regAalq_pan.Hide();
                                f_alq_dtp.Value = DateTime.Today;
                                cli_cbox.Text = "";
                                dias_mbox.Clear();
                                vehi_cbox.Text = "";
                                monto_box.Clear();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Debe seleccionar un vehículo de la lista");
                            regAalq_pan.Hide();
                            regVehi_pan.Show();
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
            f_alq_dtp.Value = DateTime.Today;
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
                    MessageBox.Show("Debe seleccionar un vehículo registrado");
                    vehi_cbox.Focus();
                }
            }
            else
            {
                MessageBox.Show("Debe definir los dias de alquiler");
                dias_mbox.Focus();
            }
        }

        private void recVehi_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (recFecha_dtp.Value >= DateTime.Today)
            {
                C_ALQUILER ent = listas.listaAlquiler.Where(o => (o.getPlaca() == recVehi_cbox.Text) && (o.getStat())).First();
                C_CLIENTES cli = listas.listaClientes.FirstOrDefault(c => c.datos()[0] == ent.datos()[0]);
                C_VEHICULOS vei = listas.listaVehiculos.First(v => v.datos()[0] == ent.datos()[1]);
                recNom_box.Text = cli.datos()[0] + "- " + cli.datos()[1] + " " + cli.datos()[2];
                recDias_box.Text = Convert.ToString(recFecha_dtp.Value.Date - ent.getFecha().Date).Split('.')[0];
                if (recDias_box.Text == "00:00:00")
                    recDias_box.Text = "0";
                recMonto_box.Text = Convert.ToString((Convert.ToDouble(vei.datos()[7]) * Convert.ToInt16(recDias_box.Text)) + Convert.ToDouble(vei.datos()[8]));
                recKm_box.Text = vei.datos()[4];

                recib_btn.Enabled = true;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fecha válida");
                recFecha_dtp.Value = DateTime.Today;
                recFecha_dtp.Focus();
            }
        }

        private void recib_btn_Click(object sender, EventArgs e)
        {
            C_ALQUILER ent = listas.listaAlquiler.FirstOrDefault(o => o.getPlaca() == recVehi_cbox.Text);
            C_VEHICULOS vei = listas.listaVehiculos.First(v => v.datos()[0] == ent.datos()[1]);
            ent.setDias(Convert.ToInt16(recDias_box.Text));
            ent.setMonto(Convert.ToDouble(recMonto_box.Text));
            ent.setStat(false);
            vei.setEstado(true);
            vei.setKm(Convert.ToDouble(recKm_box.Text));
            recib_pan.Hide();

            recFecha_dtp.Value = DateTime.Today;
            recVehi_cbox.Items.Clear();
            recNom_box.Clear();
            recDias_box.Clear();
            recMonto_box.Clear();
            recKm_box.Clear();
        }

        private void clrRec_btn_Click(object sender, EventArgs e)
        {
            recFecha_dtp.Value = DateTime.Today;
            recVehi_cbox.Text = "";
            recNom_box.Clear();
            recDias_box.Clear();
            recMonto_box.Clear();
            recKm_box.Clear();

            recVehi_cbox.Focus();
        }

        private void recKm_box_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
