using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herramienta_Administrativa
{
    public partial class CambiarFolio : Form
    {

        SqlConnection cn = new SqlConnection("Data Source=SRV_SALUD_VINA;Initial Catalog=BDIST;User ID=sysmk;Password=qT1OVkF7;Integrated Security=false;");

        public CambiarFolio()
        {
            InitializeComponent();
            groupBox1.Enabled = false;
        }
        public string FormatearRut(string rut)
        {
            int cont = 0;
            string format;
            if (rut.Length == 0)
            {
                return "";
            }
            else
            {
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                format = "-" + rut.Substring(rut.Length - 1);
                for (int i = rut.Length - 2; i >= 0; i--)
                {
                    format = rut.Substring(i, 1) + format;
                    cont++;
                    if (cont == 3 && i != 0)
                    {
                        format = "." + format;
                        cont = 0;
                    }
                }
                return format;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string tippac ="";



            if (radioButton1.Checked)

            {

                tippac = "U";
            }

            if (radioButton2.Checked)

            {

                tippac = "C";
            }


            if (txtCargo.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar cargo valido");
                txtCargo.Focus();

            }
         
            if (tippac.Equals(""))
            {
                MessageBox.Show("Debe seleccionar Urgencia o Centro Medico");
                radioButton1.Focus();
            }
            if (txtRut.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar rut paciente");
                txtCargo.Focus();
            }
            else

             


            {
                try
                {
                    txtRut.Text = FormatearRut(txtRut.Text);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("select * from ingresocomercialudca with (nolock)  where cargo ='" + txtCargo.Text + "'and rut='" + txtRut.Text + "'and tipo='"+tippac+"';", cn);
                    // SqlCommand cmd = new SqlCommand("select * from med_atencion  where fol_ate ='" + txtCargo.Text + "' and num_suc= '" + txtRut.Text + "';", cn);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        lblNombre.Text = Convert.ToString(dr["PACIENTE"]);
                        lblfolio.Text = Convert.ToString(dr["atencion_net"]);
                        groupBox1.Enabled = true;
                        MessageBox.Show("Atencion encontrada");
                    }
                    else
                    {
                        MessageBox.Show("No concuerda el Correlativo con el Rut del Paciente");
                        groupBox1.Enabled = false;
                    }

                    cn.Close();


                }
                catch (Exception ex)
                {

                    MessageBox.Show("error" + ex);
                    groupBox1.Enabled = false;
                    cn.Close();
                }
            }
    }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Globales.gbUsuario == "18266149-K" || Globales.gbUsuario == "15660194-2" || Globales.gbUsuario == "16260548-8")
            {
                MenuAdmin ad = new MenuAdmin();
                ad.Show();
                this.Hide();
            }
            else
            {
                Menu a = new Menu();
                a.Show();
                this.Hide();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //  select Cargo, Tipo, RUT, Paciente, atencion_net, codreserva from ingresocomercialudca with (nolock)
            //               where cargo = 888986

            string tippac = "";



            if (radioButton1.Checked)

            {

                tippac = "U";
            }

            if (radioButton2.Checked)

            {

                tippac = "C";
            }
            if (txtfolio.TextLength==18)
            {
                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("update ingresocomercialudca set atencion_net = '" + txtfolio.Text + "' where cargo ='" + txtCargo.Text + "'and rut='" + txtRut.Text + "'and tipo='" +tippac  + "';", cn);
                    cmd.ExecuteNonQuery();

                    cn.Close();
                    MessageBox.Show("Folio del cargo modificado");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error" + ex);
                }
            



            }
            else
            {
                MessageBox.Show("Folio incorrecto!! revisar largo debe ser igual a 18");
            }
        }
    }
}
