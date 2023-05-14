using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class calculadora : Form
    {

        double num1, num2, resul;
        string operaciones;

        public calculadora()
        {
            InitializeComponent();
        }
        

        private void btn_siete_Click(object sender, EventArgs e)
        {
            if (txt_pan1.Text.Length > 0)
            {
                if (txt_pan1.Text == "Error")
                {
                }
                else
                {
                    lst_rel.Items.Add(txt_pan1.Text + " = " + txt_pan2.Text);
                }
                txt_pan1.Clear();
                txt_pan2.Text = "7";
            }
            else
            {
                if (txt_pan2.Text == "0")
                {
                    txt_pan2.Clear();
                    txt_pan2.Text += "7";
                }
                else
                {
                    txt_pan2.Text += "7";
                }
            }
        }

        private void btn_ocho_Click(object sender, EventArgs e)
        {
            if (txt_pan1.Text.Length > 0)
            {
                if (txt_pan1.Text == "Error")
                {
                }
                else
                {
                    lst_rel.Items.Add(txt_pan1.Text + " = " + txt_pan2.Text);
                }
                txt_pan1.Clear();
                txt_pan2.Text = "8";
            }
            else
            {
                if (txt_pan2.Text == "0")
                {
                    txt_pan2.Clear();
                    txt_pan2.Text += "8";
                }
                else
                {
                    txt_pan2.Text += "8";
                }
            }
        }

        private void btn_nueve_Click(object sender, EventArgs e)
        {
            if (txt_pan1.Text.Length > 0)
            {
                if (txt_pan1.Text == "Error")
                {
                }
                else
                {
                    lst_rel.Items.Add(txt_pan1.Text + " = " + txt_pan2.Text);
                }
                txt_pan1.Clear();
                txt_pan2.Text = "9";
            }
            else
            {
                if (txt_pan2.Text == "0")
                {
                    txt_pan2.Clear();
                    txt_pan2.Text += "9";
                }
                else
                {
                    txt_pan2.Text += "9";
                }
            }
        }

        private void btn_cuatro_Click(object sender, EventArgs e)
        {
            if (txt_pan1.Text.Length > 0)
            {
                if (txt_pan1.Text == "Error")
                {
                }
                else
                {
                    lst_rel.Items.Add(txt_pan1.Text + " = " + txt_pan2.Text);
                }
                txt_pan1.Clear();
                txt_pan2.Text = "4";
            }
            else
            {
                if (txt_pan2.Text == "0")
                {
                    txt_pan2.Clear();
                    txt_pan2.Text += "4";
                }
                else
                {
                    txt_pan2.Text += "4";
                }
            }
        }

        private void btn_cinco_Click(object sender, EventArgs e)
        {
            if (txt_pan1.Text.Length > 0)
            {
                if (txt_pan1.Text == "Error")
                {
                }
                else
                {
                    lst_rel.Items.Add(txt_pan1.Text + " = " + txt_pan2.Text);
                }
                txt_pan1.Clear();
                txt_pan2.Text = "5";
            }
            else
            {
                if (txt_pan2.Text == "0")
                {
                    txt_pan2.Clear();
                    txt_pan2.Text += "5";
                }
                else
                {
                    txt_pan2.Text += "5";
                }
            }
        }

        private void btn_seis_Click(object sender, EventArgs e)
        {
            if (txt_pan1.Text.Length > 0)
            {
                if (txt_pan1.Text == "Error")
                {
                }
                else
                {
                    lst_rel.Items.Add(txt_pan1.Text + " = " + txt_pan2.Text);
                }
                txt_pan1.Clear();
                txt_pan2.Text = "6";
            }
            else
            {
                if (txt_pan2.Text == "0")
                {
                    txt_pan2.Clear();
                    txt_pan2.Text += "6";
                }
                else
                {
                    txt_pan2.Text += "6";
                }
            }
        }

        private void btn_uno_Click(object sender, EventArgs e)
        {
            if (txt_pan1.Text.Length > 0)
            {
                if (txt_pan1.Text == "Error")
                {
                }
                else
                {
                    lst_rel.Items.Add(txt_pan1.Text + " = " + txt_pan2.Text);
                }
                txt_pan1.Clear();
                txt_pan2.Text = "1";
            }
            else
            {
                if (txt_pan2.Text == "0")
                {
                    txt_pan2.Clear();
                    txt_pan2.Text += "1";
                }
                else
                {
                    txt_pan2.Text += "1";
                }
            }
        }

        private void btn_dos_Click(object sender, EventArgs e)
        {
            if (txt_pan1.Text.Length > 0)
            {
                if (txt_pan1.Text == "Error")
                {
                }
                else
                {
                    lst_rel.Items.Add(txt_pan1.Text + " = " + txt_pan2.Text);
                }
                txt_pan1.Clear();
                txt_pan2.Text = "2";
            }
            else
            {
                if (txt_pan2.Text == "0")
                {
                    txt_pan2.Clear();
                    txt_pan2.Text += "2";
                }
                else
                {
                    txt_pan2.Text += "2";
                }
            }
        }

        private void btn_tres_Click(object sender, EventArgs e)
        {
            if (txt_pan1.Text.Length > 0)
            {
                if (txt_pan1.Text == "Error")
                {
                }
                else
                {
                    lst_rel.Items.Add(txt_pan1.Text + " = " + txt_pan2.Text);
                }
                txt_pan1.Clear();
                txt_pan2.Text = "3";
            }
            else
            {
                if (txt_pan2.Text == "0")
                {
                    txt_pan2.Clear();
                    txt_pan2.Text += "3";
                }
                else
                {
                    txt_pan2.Text += "3";
                }
            }
        }

        private void btn_cero_Click(object sender, EventArgs e)
        {
            if (txt_pan1.Text.Length > 0)
            {
                if (txt_pan1.Text == "Error")
                {
                }
                else
                {
                    lst_rel.Items.Add(txt_pan1.Text + " = " + txt_pan2.Text);
                }
                txt_pan1.Clear();
                txt_pan2.Text = "0";
            }
            else
            {
                if (txt_pan2.Text == "0")
                {
                    txt_pan2.Clear();
                    txt_pan2.Text += "0";
                }
                else
                {
                    txt_pan2.Text += "0";
                }
            }
        }
        

        private void btn_coma_Click(object sender, EventArgs e)
        {
            if (!txt_pan2.Text.Contains("."))
            {
                txt_pan2.Text += ".";
            }
        }

        private void btn_resultado_Click(object sender, EventArgs e)
        {
            if (txt_pan2.Text == "0")
                {
                }
                else if (txt_pan2.Text.Contains("+") || txt_pan2.Text.Contains("-") || txt_pan2.Text.Contains("*") || txt_pan2.Text.Contains("/"))
                {
                    try
                    {
                        txt_pan1.Text = txt_pan2.Text;
                        DataTable dt = new DataTable();
                        object resul = dt.Compute(txt_pan2.Text, null);
                        txt_pan2.Text = resul.ToString();
                        if (txt_pan2.Text == "∞")
                        {
                            txt_pan1.Text = "Error";
                            txt_pan2.Clear();
                        }
                    }
                    catch (Exception ex)
                    {
                        txt_pan1.Text = "Error";
                        txt_pan2.Clear();
                    }
                }
            
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (txt_pan1.Text.Length > 0)
            {
                if (txt_pan1.Text == "Error")
                {
                }
                else
                {
                    lst_rel.Items.Add(txt_pan1.Text + " = " + txt_pan2.Text);
                }
                txt_pan1.Clear();
                txt_pan2.Text = "0";
            }
            else //if(txt_pan2.Text.Length > 0)
            {
                txt_pan2.Text = txt_pan2.Text.Substring(0, txt_pan2.Text.Length - 1);
                if (txt_pan2.Text.Length == 0)
            {
                    txt_pan2.Text = "0";
            }
            }
        }

        private void btn_borrarall_Click(object sender, EventArgs e)
        {

            if (txt_pan1.Text.Length > 0)
            {
                if (txt_pan1.Text == "Error")
                {
                }
                else 
                { 
                    lst_rel.Items.Add(txt_pan1.Text + " = " + txt_pan2.Text);
                }
                txt_pan2.Clear();
                txt_pan1.Clear();
                txt_pan2.Text = "0";
            }
            else
            {
                txt_pan2.Clear();
                txt_pan2.Text = "0";
            }
        }
        
        private void btn_suma_Click(object sender, EventArgs e)
        {
            if (txt_pan1.Text.Length > 0)
            {
                if (txt_pan1.Text == "Error")
                {
                }
                else
                {
                    lst_rel.Items.Add(txt_pan1.Text + " = " + txt_pan2.Text);
                    txt_pan1.Clear();
                }
            }
            if (txt_pan2.Text == "0")
            {
            }
            else
            {
                txt_pan2.Text += "+";
            }
        }

        private void btn_resta_Click(object sender, EventArgs e)
        {
            if (txt_pan1.Text.Length > 0)
            {
                if (txt_pan1.Text == "Error")
                {
                }
                else
                {
                    lst_rel.Items.Add(txt_pan1.Text + " = " + txt_pan2.Text);
                    txt_pan1.Clear();
                }
            }
            if (txt_pan2.Text == "0")
            {
            }
            else
            {
                txt_pan2.Text += "-";
            }
        }

        private void btn_multi_Click(object sender, EventArgs e)
        {
            if (txt_pan1.Text.Length > 0)
            {
                if (txt_pan1.Text == "Error")
                {
                }
                else
                {
                    lst_rel.Items.Add(txt_pan1.Text + " = " + txt_pan2.Text);
                    txt_pan1.Clear();
                }
            }
            if (txt_pan2.Text == "0")
            {
            }
            else
            {
                txt_pan2.Text += "*";
            }
        }

        private void btn_divi_Click(object sender, EventArgs e)
        {
            if (txt_pan1.Text.Length > 0)
            {
                if (txt_pan1.Text == "Error")
                {
                }
                else
                {
                    lst_rel.Items.Add(txt_pan1.Text + " = " + txt_pan2.Text);
                    txt_pan1.Clear();
                }
            }
            if (txt_pan2.Text == "0")
            {
            }
            else
            {
                txt_pan2.Text += "/";
            }
        }

        private void txt_pan1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_pan2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
