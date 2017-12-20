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
    public partial class CambioFolio : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=SRV_SALUD_VINA;Initial Catalog=INGRESOLEY;User ID=sysmk;Password=qT1OVkF7;Integrated Security=false;");
     //    SqlConnection cn = new SqlConnection("Data Source=NORTE_0_73;Persist Security Info=True;Initial Catalog=INGRESOLEY;Integrated Security=true;");
        public CambioFolio()
        {
            InitializeComponent();
            groupBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (txtFolioOld.TextLength == 18)
            {

                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("select * from med_atencion  where fol_ate ='" + txtFolioOld.Text + "';", cn);
                    // SqlCommand cmd = new SqlCommand("select * from med_atencion  where fol_ate ='" + txtCargo.Text + "' and num_suc= '" + txtRut.Text + "';", cn);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        lblnom.Text = Convert.ToString(dr["GLS_NOM_PER"]);
                        lblfolio.Text = Convert.ToString(dr["fol_ate"]);
                        groupBox1.Enabled = true;
                        MessageBox.Show("Atencion encontrada");
                    }
                    else
                    {
                        MessageBox.Show("Folio no encontrado");
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



       
            else
            {
                MessageBox.Show("Folio incorrecto!! revisar largo debe ser igual a 18");
            }



           
         }

        private void button2_Click(object sender, EventArgs e)
        {
            string indrei = "";
            string tipate = "";
            string gls = "";
            if (radioButton1.Checked)

            {

                indrei = "1";
                tipate = "2";
                gls = "Se cambio a Reingreso";
            }

            if (radioButton2.Checked)

            {

                indrei = "2";
                tipate = "1";
                gls = "Se cambio a Ingreso";
            }

            try
            {
                if (tipate == "")
                {
                    MessageBox.Show("Debe seleccionar Ingreso o Reingreso");
                    radioButton1.Focus();

                }
                if (txtfolioNew.TextLength == 18)
                {
                 
            
                    try
                    {
                        cn.Open();
                        SqlCommand cmde = new SqlCommand("update med_atencion set fol_ate = '" + txtfolioNew.Text + "', ind_tip_ate=" + tipate + ", ind_rei=" + indrei + ", gls_ori_pac='" + gls + "',ID_USUARIO_ULT_MODIF_REG='" + Globales.gbUsuario + "',FEC_ULT_MODIF_REG='" + DateTime.Today.ToString("yyyy-MM-dd hh:mm:ss") + "' where fol_ate ='" + txtFolioOld.Text + "';",cn);


                         cmde.ExecuteNonQuery();

                        cn.Close();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("No existe registro en tabla Med_atencion para actualizar");
                        cn.Close();
                    }
                    try
                    {
                        cn.Open();
                        SqlCommand cmde = new SqlCommand("update med_altas set fol_ate = '" + txtfolioNew.Text + "',ID_USUARIO_ULT_MODIF_REG='" + Globales.gbUsuario + "',FEC_ULT_MODIF_REG='" + DateTime.Today.ToString("yyyy-MM-dd hh:mm:ss") + "' where fol_ate ='" + txtFolioOld.Text + "';", cn);


                        cmde.ExecuteNonQuery();

                        cn.Close();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("No existe registro en tabla Med_altas para actualizar");
                        cn.Close();
                    }
                    try
                    {
                        cn.Open();
                        SqlCommand cmde = new SqlCommand("update MED_DIAGNOSTICO set fol_ate = '" + txtfolioNew.Text + "',ID_USUARIO_ULT_MODIF_REG='" + Globales.gbUsuario + "',FEC_ULT_MODIF_REG='" + DateTime.Today.ToString("yyyy-MM-dd hh:mm:ss") + "' where fol_ate ='" + txtFolioOld.Text + "';", cn);


                        cmde.ExecuteNonQuery();

                        cn.Close();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("No existe registro en tabla MED_DIAGNOSTICO para actualizar");
                        cn.Close();
                    }
                    try
                    {
                        cn.Open();
                        SqlCommand cmde = new SqlCommand("update med_atencion_ane set fol_ate = '" + txtfolioNew.Text + "',ID_USUARIO_ULT_MODIF_REG='" + Globales.gbUsuario + "',FEC_ULT_MODIF_REG='" + DateTime.Today.ToString("yyyy-MM-dd hh:mm:ss") + "' where fol_ate ='" + txtFolioOld.Text + "';", cn);


                        cmde.ExecuteNonQuery();

                        cn.Close();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("No existe registro en tabla med_atencion_ane para actualizar");
                        cn.Close();
                    }
                    try
                    {
                        cn.Open();
                        SqlCommand cmde = new SqlCommand("update med_atencion_sisesat set fol_ate = '" + txtfolioNew.Text + "' where fol_ate ='" + txtFolioOld.Text + "';", cn);


                        cmde.ExecuteNonQuery();

                        cn.Close();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("No existe registro en tabla med_atencion_sisesat para actualizar");
                        cn.Close();
                    }
                    try
                    {
                        cn.Open();
                        SqlCommand cmde = new SqlCommand(" update med_diat set fol_ate = '" + txtfolioNew.Text + "' where fol_ate ='" + txtFolioOld.Text + "';", cn);


                        cmde.ExecuteNonQuery();

                        cn.Close();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("No existe registro en tabla med_diat para actualizar");
                        cn.Close();
                    }
                    try
                    {
                        cn.Open();
                        SqlCommand cmde = new SqlCommand(" update med_diep set fol_ate = '" + txtfolioNew.Text + "',ID_USUARIO_ULT_MODIF_REG='" + Globales.gbUsuario + "',FEC_ULT_MODIF_REG='" + DateTime.Today.ToString("yyyy-MM-dd hh:mm:ss") + "' where fol_ate ='" + txtFolioOld.Text + "';", cn);


                        cmde.ExecuteNonQuery();

                        cn.Close();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("No existe registro en tabla med_diep para actualizar");
                        cn.Close();
                    }
                    try
                    {
                        cn.Open();
                        SqlCommand cmde = new SqlCommand(" update med_doc_dep set fol_ate = '" + txtfolioNew.Text + "',ID_USUARIO_ULT_MODIF_REG='" + Globales.gbUsuario + "',FEC_ULT_MODIF_REG='" + DateTime.Today.ToString("yyyy-MM-dd hh:mm:ss") + "' where fol_ate ='" + txtFolioOld.Text + "';", cn);


                        cmde.ExecuteNonQuery();

                        cn.Close();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("No existe registro en tabla med_doc_dep para actualizar");
                        cn.Close();
                    }
                    try
                    {
                        cn.Open();
                        SqlCommand cmde = new SqlCommand(" update med_doc_diat set fol_ate = '" + txtfolioNew.Text + "',ID_USUARIO_ULT_MODIF_REG='" + Globales.gbUsuario + "',FEC_ULT_MODIF_REG='" + DateTime.Today.ToString("yyyy-MM-dd hh:mm:ss") + "' where fol_ate ='" + txtFolioOld.Text + "';", cn);


                        cmde.ExecuteNonQuery();

                        cn.Close();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("No existe registro en tabla med_doc_diat para actualizar");
                        cn.Close();
                    }
                    try
                    {
                        cn.Open();
                        SqlCommand cmde = new SqlCommand("update med_doc_licencia_77 set fol_ate = '" + txtfolioNew.Text + "',ID_USUARIO_ULT_MODIF_REG='" + Globales.gbUsuario + "',FEC_ULT_MODIF_REG='" + DateTime.Today.ToString("yyyy-MM-dd hh:mm:ss") + "' where fol_ate ='" + txtFolioOld.Text + "';", cn);


                        cmde.ExecuteNonQuery();

                        cn.Close();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("No existe registro en tabla med_doc_licencia_77 para actualizar");
                        cn.Close();
                    }
                    try
                    {
                        cn.Open();
                        SqlCommand cmde = new SqlCommand("update med_atencion_txt set fol_ate = '" + txtfolioNew.Text + "',ID_USUARIO_ULT_MODIF_REG='" + Globales.gbUsuario + "',FEC_ULT_MODIF_REG='" + DateTime.Today.ToString("yyyy-MM-dd hh:mm:ss") + "' where fol_ate ='" + txtFolioOld.Text + "';", cn);


                        cmde.ExecuteNonQuery();

                        cn.Close();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("No existe registro en tabla med_atencion_txt para actualizar");
                        cn.Close();
                    }
                  

                    MessageBox.Show("Folio Modificado");

                }
                else
                {
                    MessageBox.Show("Folio nuevo es menor o superior a 18 caracteres" );

                }



            }
            catch (Exception ex)
            {

                MessageBox.Show("error" + ex);
                cn.Close();
            }

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

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
