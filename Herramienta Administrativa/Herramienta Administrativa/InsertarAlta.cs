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
    public partial class InsertarAlta : Form
    {
        public InsertarAlta()
        {
            InitializeComponent();
            groupBox1.Enabled = false;
            fecprepac.Visible = false;
          
        }
        SqlConnection cn = new SqlConnection("Data Source=SRV_SALUD_VINA;Initial Catalog=INGRESOLEY;User ID=sysmk;Password=qT1OVkF7;Integrated Security=false;");
        // SqlConnection cn = new SqlConnection("Data Source=NORTE_0_73;Initial Catalog=INGRESOLEY;Integrated Security=true;");


        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCargo.TextLength == 18)
            {

                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("select * from med_atencion with (nolock) where fol_ate ='" + txtCargo.Text + "';", cn);
                    // SqlCommand cmd = new SqlCommand("select * from med_atencion  where fol_ate ='" + txtCargo.Text + "' and num_suc= '" + txtRut.Text + "';", cn);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        lblnombrepac.Text = Convert.ToString(dr["GLS_NOM_PER"]);
                        fecprepac.Text = Convert.ToString(dr["fec_pre_pac"]);
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
            Application.Exit();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
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

        //private void RadioButton1_Click(object sender, EventArgs e)
        //{

        //        groupBox4.Visible = false;


        //}
        //private void radioButton2_IsChecked(object sender, EventArgs e)
        //{

        //        groupBox4.Visible = true;


        //}
        private void BtnFechaAlta_Click(object sender, EventArgs e)
        {
            string caususeso = "";
            string tippac = "";

            string tipate = "";

            string tipcausal = "";
            string ind_caralt = "";

            if (radioButton1.Checked)

            {

                tipate = "N";
                ind_caralt = "5";
            }

            if (radioButton2.Checked)

            {

                tipate = "S";
                ind_caralt = "1";
            }
          



            if (radioButton5.Checked)

            {

                tipcausal = "1";
              // caususeso = "1";
            }

            if (radioButton6.Checked)

            {

                tipcausal = "2";
                // caususeso = "2";
            }
            if (radioButton7.Checked)

            {

                tipcausal = "3";
                //  caususeso = "3";
            }

            if (radioButton3.Checked)

            {

                tippac = "1";
            }

            if (radioButton4.Checked)

            {

                tippac = "2";
            }

            string fecalt = "";
           
            if (tipate== "" || tipcausal=="" ||tippac=="")
            {
                MessageBox.Show("Debe seleccionar datos causal, clasificacion paciente y tipo paciente");
                radioButton1.Focus();
            }
            else
            {

           

            if (tippac == "1" && tipate == "N" && tipcausal == "1")
            {
                caususeso = "4";

            }
            if (tippac == "1" && tipate == "N" && tipcausal == "2")
            {
                caususeso = "9";

            }
            if (tippac == "1" && tipate == "N" && tipcausal == "3")
            {
                caususeso = "5";

            }
            if (tippac == "2" && tipcausal == "1" || tippac == "2" && tipcausal == "2")
            {
                caususeso = "6";

            }
            if (tippac == "2" && tipcausal == "3")
            {
                caususeso = "7";

            }
            if (tippac == "1" && tipate == "S" && tipcausal == "1")
            {
                caususeso = "1";

            }
            if (tippac == "1" && tipate == "S" && tipcausal == "2")
            {
                caususeso = "2";

            }
            if (tippac == "1" && tipate == "S" && tipcausal == "3")
            {
                caususeso = "3";

            }
               // MessageBox.Show("fecha no null");
               
                if (textBox1.Text == "")
                {


                    try
                    {
                        // MessageBox.Show("FECHA ALTA " + DateTime.Today);

                        cn.Open();
                        //SqlCommand cmd = new SqlCommand("update med_atencion set fec_alt_pac = NULL,ind_tip_pac='1',ind_est_ate=1,ind_cau_con='" + tipcausal + "',ID_USUARIO_ULT_MODIF_REG='SOPORTE007' where fol_ate ='" + txtCargo.Text + "';update med_atencion_sisesat set ind_cau_con_sisesat='" + tipcausal + "',ID_USUARIO_ULT_MODIF_REG='SOPORTE007' where fol_ate='" + txtCargo.Text + "';update med_altas set ind_ctp='" + tipate + "',fec_alt=NULL,FEC_INI_LAB=NULL,IND_CAR_ALT='" + ind_caralt + "',NUM_DIA_TRA=NULL,ID_USUARIO_ULT_MODIF_REG='SOPORTE007' where fol_ate='" + txtCargo.Text + "'; ", cn);
                        SqlCommand cmd = new SqlCommand("update med_atencion set fec_alt_pac = NULL,ind_tip_pac='1',ind_est_ate=1,ind_cau_con='" + tipcausal + "',FEC_ULT_MODIF_REG='" + DateTime.Today.ToString("yyyy-MM-dd hh:mm:ss") + "' where fol_ate ='" + txtCargo.Text + "';update med_atencion_sisesat set ind_cau_con_sisesat='" + tipcausal + "',FEC_ULT_MODIF_REG='" + DateTime.Today.ToString("yyyy-MM-dd hh:mm:ss") + "' where fol_ate='" + txtCargo.Text + "';update med_altas set ind_ctp=NULL,fec_alt=NULL,FEC_INI_LAB=NULL,IND_CAR_ALT=NULL,NUM_DIA_TRA=NULL,IND_CAU_ALT=NULL,FEC_ULT_MODIF_REG='" + DateTime.Today.ToString("yyyy-MM-dd hh:mm:ss") + "' where fol_ate='" + txtCargo.Text + "'; ", cn);
                        cmd.ExecuteNonQuery();

                        cn.Close();
                        MessageBox.Show("Alta de paciente modificada");


                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("error" + ex);
                    }

                }
                else
                {
                   

                    if (tipate == "N"&&tippac=="1")
                    {
                        fecalt = textBox1.Text + " 00:00:00";
                        //   MessageBox.Show("FECHA ALTA " + fecalt + " CAUCONSUSESO=" + caususeso + " IND CTP=" + tipate + "FECHA DIAS PERDIDOS=" + fecprepac);



                        DateTime prepac = Convert.ToDateTime(fecprepac.Text);
                        var fechaCorta = prepac.ToString("yyyy-MM-dd");
                        DateTime prepac2 = Convert.ToDateTime(fechaCorta);
                        DateTime fechaalta = Convert.ToDateTime(fecalt);
                        // MessageBox.Show("fecha inicio dias perdidos " + prepac2);
                        //MessageBox.Show("fecha alta " + fechaalta);
                        TimeSpan ts = fechaalta - prepac2;

                        int differenceInDays = ts.Days;

                        // MessageBox.Show("numero dias perdidos " + differenceInDays);



                        var fechaCorta2 = fechaalta.AddDays(1).ToString("yyyy-MM-dd hh:mm:ss");

                       // MessageBox.Show("fecha inicio labores : " + fechaCorta2);


                        try
                        {



                            cn.Open();
                            SqlCommand cmd = new SqlCommand("update med_atencion set fec_alt_pac ='" + fecalt + "',ind_tip_pac='" + tippac + "',ind_est_ate=2,ind_cau_con='" + tipcausal + "',FEC_ULT_MODIF_REG='" + DateTime.Today.ToString("yyyy-MM-dd hh:mm:ss") + "' where fol_ate ='" + txtCargo.Text + "';update med_atencion_sisesat set ind_cau_con_sisesat='" + caususeso + "',FEC_ULT_MODIF_REG='" + DateTime.Today.ToString("yyyy-MM-dd hh:mm:ss") + "' where fol_ate='" + txtCargo.Text + "';update med_altas set ind_ctp='" + tipate + "',fec_alt='" + fecalt + "',FEC_INI_LAB='" + fecalt + "',IND_CAR_ALT='" + ind_caralt + "',num_dia_tra='0',IND_CAU_ALT='1',FEC_ULT_MODIF_REG='" + DateTime.Today.ToString("yyyy-MM-dd hh:mm:ss") + "'where fol_ate='" + txtCargo.Text + "'; ", cn);
                            cmd.ExecuteNonQuery();

                            cn.Close();
                            MessageBox.Show("Alta de paciente modificada");


                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("error" + ex);
                            cn.Close();
                        }



                    }
                    if (tippac=="2")
                    {
                        fecalt = textBox1.Text + " 00:00:00";
                        //   MessageBox.Show("FECHA ALTA " + fecalt + " CAUCONSUSESO=" + caususeso + " IND CTP=" + tipate + "FECHA DIAS PERDIDOS=" + fecprepac);



                        DateTime prepac = Convert.ToDateTime(fecprepac.Text);
                        var fechaCorta = prepac.ToString("yyyy-MM-dd");
                        DateTime prepac2 = Convert.ToDateTime(fechaCorta);
                        DateTime fechaalta = Convert.ToDateTime(fecalt);
                        // MessageBox.Show("fecha inicio dias perdidos " + prepac2);
                        //MessageBox.Show("fecha alta " + fechaalta);
                        TimeSpan ts = fechaalta - prepac2;

                        int differenceInDays = ts.Days;

                        // MessageBox.Show("numero dias perdidos " + differenceInDays);



                        var fechaCorta2 = fechaalta.AddDays(1).ToString("yyyy-MM-dd");
                        fechaCorta2 = fechaCorta2 + " 00:00:00";

                        // MessageBox.Show("fecha inicio labores : " + fechaCorta2);


                        try
                        {



                            cn.Open();
                            SqlCommand cmd = new SqlCommand("update med_atencion set fec_alt_pac ='" + fecalt + "',ind_tip_pac='2',ind_est_ate=2,ind_cau_con='" + tipcausal + "',FEC_ULT_MODIF_REG='" + DateTime.Today.ToString("yyyy-MM-dd hh:mm:ss") + "' where fol_ate ='" + txtCargo.Text + "';update med_atencion_sisesat set ind_cau_con_sisesat='" + caususeso + "',FEC_ULT_MODIF_REG='" + DateTime.Today.ToString("yyyy-MM-dd hh:mm:ss") + "' where fol_ate='" + txtCargo.Text + "';update med_altas set ind_ctp='N',fec_alt='" + fecalt + "',FEC_INI_LAB='" + fecalt + "',IND_CAR_ALT='5',num_dia_tra='0',IND_CAU_ALT='1',FEC_ULT_MODIF_REG='" + DateTime.Today.ToString("yyyy-MM-dd hh:mm:ss") + "' where fol_ate='" + txtCargo.Text + "'; ", cn);
                            cmd.ExecuteNonQuery();

                            cn.Close();
                            MessageBox.Show("Alta de paciente modificada");


                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("error" + ex);
                            cn.Close();
                        }



                    }

                    if (tipate == "S" && tippac == "1")
                    {
                        fecalt = textBox1.Text + " 00:00:00";
                        //   MessageBox.Show("FECHA ALTA " + fecalt + " CAUCONSUSESO=" + caususeso + " IND CTP=" + tipate + "FECHA DIAS PERDIDOS=" + fecprepac);



                        DateTime prepac = Convert.ToDateTime(fecprepac.Text);
                        var fechaCorta = prepac.ToString("yyyy-MM-dd");
                        DateTime prepac2 = Convert.ToDateTime(fechaCorta);
                        DateTime fechaalta = Convert.ToDateTime(fecalt);
                        // MessageBox.Show("fecha inicio dias perdidos " + prepac2);
                        //MessageBox.Show("fecha alta " + fechaalta);
                        TimeSpan ts = fechaalta - prepac2;

                        int differenceInDays = ts.Days;
                        differenceInDays =differenceInDays+1;
                        // MessageBox.Show("numero dias perdidos " + differenceInDays);



                        var fechaCorta2 = fechaalta.AddDays(1).ToString("yyyy-MM-dd");
                        fechaCorta2 = fechaCorta2+" 00:00:00";

                        // MessageBox.Show("fecha inicio labores : " + fechaCorta2);


                        try
                        {



                            cn.Open();
                            SqlCommand cmd = new SqlCommand("update med_atencion set fec_alt_pac ='" + fecalt + "',ind_tip_pac='" + tippac + "',ind_est_ate=2,ind_cau_con='" + tipcausal + "',FEC_ULT_MODIF_REG='" + DateTime.Today.ToString("yyyy-MM-dd hh:mm:ss") + "' where fol_ate ='" + txtCargo.Text + "';update med_atencion_sisesat set ind_cau_con_sisesat='" + caususeso + "',FEC_ULT_MODIF_REG='" + DateTime.Today.ToString("yyyy-MM-dd hh:mm:ss") + "' where fol_ate='" + txtCargo.Text + "';update med_altas set ind_ctp='" + tipate + "',fec_alt='" + fecalt + "',FEC_INI_LAB='" + fechaCorta2 + "',IND_CAR_ALT='" + ind_caralt + "',num_dia_tra='" + differenceInDays + "',IND_CAU_ALT='1',FEC_ULT_MODIF_REG='" + DateTime.Today.ToString("yyyy-MM-dd hh:mm:ss") + "' where fol_ate='" + txtCargo.Text + "'; ", cn);
                            cmd.ExecuteNonQuery();

                            cn.Close();
                            MessageBox.Show("Alta de paciente modificada");


                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("error" + ex);
                            cn.Close();
                        }



                    }






               

                }


            }

        }
    }
   }
