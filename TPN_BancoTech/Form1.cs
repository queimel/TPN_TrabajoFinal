using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TPN_BancoTech
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Limpiar()
        {
            tb_montoPagar.Text = "";
            tb_descuento.Text = "";
            cb_dias.SelectedIndex = 0;
            tb_nmeses.Text = "";
            tb_pagoAdel.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Limpiar();
            l_mensajes.Text = "";
            tb_montoPagar.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb_montoPagar.Text = string.Empty;
            l_mensajes.Text = string.Empty;
            tb_montoPagar.Focus();
        }

        private void b_consultar_Click(object sender, EventArgs e)
        {
            l_mensajes.Text = "";


            if ("".Equals(tb_montoPagar.Text))
            {
                l_mensajes.Text = "Debe ingresar el monto a pagar";
                tb_montoPagar.Focus();
            }
            else
            {
                int montoPagar;

                if (int.TryParse(tb_montoPagar.Text, out montoPagar))
                {
                    if (montoPagar > 0)
                    {
                        float porcDes;
                        if(float.TryParse(tb_descuento.Text, out porcDes))
                        {
                            if(porcDes > 0)
                            {
                                if( cb_dias.SelectedIndex > 0)
                                {
                                    int numMeses;
                                    if(int.TryParse(tb_nmeses.Text, out numMeses))
                                    {
                                        if(numMeses > 0)
                                        {
                                            // Creo instancia de pagoAdelantado
                                             
                                        }
                                        else
                                        {
                                            l_mensajes.Text = "Debe ingresar un número de meses mayor a 0";
                                            tb_nmeses.Focus();
                                        }
                                    }
                                    else
                                    {
                                        l_mensajes.Text = " Debe ingresar un número de meses";
                                        tb_nmeses.Focus();
                                    }
                                }
                                else
                                {
                                    l_mensajes.Text = "Debe seleccionar la cantidad de días";
                                    cb_dias.Focus();
                                }
                            }
                            else
                            {
                                l_mensajes.Text = "Debe ingresar un numero mayor a 0";
                                tb_descuento.Focus();
                            }
                        }
                        else
                        {
                            l_mensajes.Text = "Debe ingresar un número real para el porcentaje de descuento";
                            tb_descuento.Focus();
                        }
                    }
                    else
                    {
                        l_mensajes.Text = " Debe ingresar un monto mayor a 0";
                        tb_montoPagar.Focus();
                    }
                }
                else
                {
                    l_mensajes.Text = "Debe ingresar un numero entero para el monto a pagar";
                }

            }
        }
    }
}
