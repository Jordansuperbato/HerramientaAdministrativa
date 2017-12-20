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
    public partial class AnulacionAlta : Form
    {
        public AnulacionAlta()
        {
            InitializeComponent();
            groupBox2.Enabled = false;
        }
        SqlConnection cn = new SqlConnection("Data Source=SRV_SALUD_VINA;Initial Catalog=INGRESOLEY;User ID=sysmk;Password=qT1OVkF7;Integrated Security=false;");
       //  SqlConnection cn = new SqlConnection("Data Source=NORTE_0_73;Initial Catalog=INGRESOLEY;Integrated Security=true;");
        private void button1_Click(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtCargo.TextLength == 18)
            {

                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("GLS_NOM_PER,rut_per,fec_ate_pac,FEC_ACC_PAC,FEC_PRE_PAC,FEC_ALT_PAC,RUT_EMP,GLS_NOM_EMP from med_atencion with (nolock) where fol_ate ='" + txtCargo.Text + "';", cn);
                    // SqlCommand cmd = new SqlCommand("select * from med_atencion  where fol_ate ='" + txtCargo.Text + "' and num_suc= '" + txtRut.Text + "';", cn);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                       lblnomper.Text = Convert.ToString(dr["GLS_NOM_PER"]);
                        lblrut.Text = Convert.ToString(dr["RUT_PER"]);
                        lblfecprepac.Text = Convert.ToString(dr["fec_pre_pac"]);
                        lblfecacc.Text = Convert.ToString(dr["FEC_ACC_PAC"]);
                        lblfecalt.Text = Convert.ToString(dr["FEC_ALT_PAC"]);
                        lblfecate.Text = Convert.ToString(dr["FEC_ATE_PAC"]);

                        groupBox2.Enabled = true;
                        MessageBox.Show("Atencion encontrada");
                    }
                    else
                    {
                        MessageBox.Show("Folio no encontrado");
                        groupBox2.Enabled = false;
                    }

                    cn.Close();


                }
                catch (Exception ex)
                {

                    MessageBox.Show("error" + ex);
                    groupBox2.Enabled = false;
                    cn.Close();
                }
            }

            else
            {
                MessageBox.Show("Folio incorrecto!! revisar largo debe ser igual a 18");
                txtCargo.Focus();
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {


            if (textBox1.Text=="")
            {
                MessageBox.Show("Debe ingresar motivo de la anulacion");
                textBox1.Focus();
            }
            else
            {
                try
                {
                   

                    cn.Open();
                    //SqlCommand cmd = new SqlCommand("update med_atencion set fec_alt_pac = NULL,ind_tip_pac='1',ind_est_ate=1,ind_cau_con='" + tipcausal + "',ID_USUARIO_ULT_MODIF_REG='SOPORTE007' where fol_ate ='" + txtCargo.Text + "';update med_atencion_sisesat set ind_cau_con_sisesat='" + tipcausal + "',ID_USUARIO_ULT_MODIF_REG='SOPORTE007' where fol_ate='" + txtCargo.Text + "';update med_altas set ind_ctp='" + tipate + "',fec_alt=NULL,FEC_INI_LAB=NULL,IND_CAR_ALT='" + ind_caralt + "',NUM_DIA_TRA=NULL,ID_USUARIO_ULT_MODIF_REG='SOPORTE007' where fol_ate='" + txtCargo.Text + "'; ", cn);
                    SqlCommand cmd = new SqlCommand("update med_atencion set fec_alt_pac = NULL,ind_tip_pac='1',ind_est_ate=1,ID_USUARIO_ULT_MODIF_REG='" + Globales.gbUsuario + "',FEC_ULT_MODIF_REG='" + DateTime.Today.ToString("yyyy-MM-dd hh:mm:ss") + "' where fol_ate ='" + txtCargo.Text + "';update med_altas set ind_ctp=NULL,fec_alt=NULL,FEC_INI_LAB=NULL,IND_CAR_ALT=NULL,NUM_DIA_TRA=NULL,IND_CAU_ALT=NULL,GLS_OBS_ALT='"+textBox1.Text +"',ID_USUARIO_ULT_MODIF_REG='" + Globales.gbUsuario + "',FEC_ULT_MODIF_REG='" + DateTime.Today.ToString("yyyy-MM-dd hh:mm:ss") + "' where fol_ate='" + txtCargo.Text + "'; ", cn);
                    cmd.ExecuteNonQuery();

                    cn.Close();
                    MessageBox.Show("Alta de paciente modificada");


                }
                catch (Exception ex)
                {

                    MessageBox.Show("error" + ex);
                }
            }

        }
    }
}
