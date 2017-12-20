using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Data.SqlClient;

namespace Herramienta_Administrativa
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            Globales.Inicializar();
        }
        SqlConnection cn = new SqlConnection("Data Source=SRV_SALUD_VINA;Initial Catalog=BDIST;User ID=sysmk;Password=qT1OVkF7;Integrated Security=false;");
        OracleConnection con = new OracleConnection("User Id = nssprod_soporte; Password=sopo753159;Data Source = 170.110.40.19/ist1;");
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BtnIngreso_Click(object sender, EventArgs e)
        {
           txtUsuario.Text.ToUpper();
           
            if (txtUsuario.Text == "" && txtContra.Text == "")
            {

                MessageBox.Show("Debe ingresar Usuario y Contraseña");
                txtUsuario.Focus();
            }
            else
            {

                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM MAEPASSWORD WITH (NOLOCK) WHERE LOGIN='" + txtUsuario.Text + "' AND CLAVE = '" + txtContra.Text + "';", cn);
                    // SqlCommand cmd = new SqlCommand("select * from med_atencion  where fol_ate ='" + txtCargo.Text + "' and num_suc= '" + txtRut.Text + "';", cn);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        Globales.gbUsuario = Convert.ToString(dr["LOGIN"]);


                        MessageBox.Show("Bienvenido(a) " + Convert.ToString(dr["NOMBRE"]));

                        if (txtUsuario.Text.ToUpper() == "18266149-K"||txtUsuario.Text.ToUpper() == "15660194-2"||txtUsuario.Text.ToUpper() == "16260548-8")
                        {
                            MenuAdmin menu = new MenuAdmin();
                            menu.Show();
                            this.Hide();

                           
                        }
                        else
                        {
                            Menu men = new Menu();
                            men.Show();
                            this.Hide();


                        }


                    }
                    else
                    {
                        MessageBox.Show("Usuario MK no encontrado");

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


          
                  

                    // SELECT * FROM MAEPASSWORD WITH (NOLOCK) WHERE LOGIN='18266149-K' AND CLAVE = '6149'

                }


        private void button1_Click_1(object sender, EventArgs e)
        {

            //try
            //{
            //    con.Open();
            //    OracleCommand cm = new OracleCommand("SELECT * FROM MED_ATENCION WHERE FOL_aTE='20171100005673-000'", con);



            //    OracleDataReader dr = cm.ExecuteReader();
            //    if (dr.Read())
            //    {
            //        label2.Text = Convert.ToString(dr["FOL_ATE"]);
            //        label3.Text = Convert.ToString(dr["RUT_PER"]);

            //        con.Close();



            Application.Exit();
            //    }
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show("a"+ex);
            //}




        }

    }
}