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
    public partial class RevocacionAlta : Form

    
    {
        SqlConnection cn = new SqlConnection("Data Source=SRV_SALUD_VINA;Initial Catalog=BDIST;User ID=sysmk;Password=qT1OVkF7;Integrated Security=false;");
       // SqlConnection cn = new SqlConnection("Data Source=NORTE_0_73;Initial Catalog=INGRESOLEY;Integrated Security=true;");

        InterfaceAMC.InterfaceAMCSoapClient anular = new InterfaceAMC.InterfaceAMCSoapClient();
        public RevocacionAlta()
        {
            InitializeComponent();
            panel2.Enabled = false;
        }
       
        private void RevocacionAlta_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            if(Globales.gbUsuario== "18266149-K" || Globales.gbUsuario == "15660194-2" || Globales.gbUsuario == "16260548-8")
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

        private void BtnRevocar_Click(object sender, EventArgs e)
        {
            if(txtFolio.Text.Equals(""))
            {
                MessageBox.Show("DEBE INGRESAR EL FOLIO PARA REVOCAR ALTA DE ISTPROD");
                txtFolio.Focus();
            }
            else
            {
                try
                {

                    DateTime hoy = DateTime.Now;

                    string miVariable = hoy.ToString("dd/MM/yyyy");

                    
             
                    anular.AnularALTA("", txtFolio.Text, miVariable);

                    MessageBox.Show("Se ha dejado vigente la atencion de ISTProd");

                }
                catch (Exception ex)
                {

                    MessageBox.Show("error al anular alta de NET" + ex);
                }
            }
           
           



        }

    

        private void RevocacionAlta_Load(object sender, EventArgs e)
        {

        }

        private void BtnActualizarTipoPac_Click(object sender, EventArgs e)
        {
            int tippac=0;
           

          
                if (radioButton3.Checked)

                {
                    
                    tippac = 1;
                }

                if (radioButton4.Checked)

                {
                   
                    tippac = 2;
                }
                try
                {
                    if (tippac==0)
                    {
                        MessageBox.Show("Debe seleccionar el tipo de paciente ('LEY', 'NO LEY')");

                    }
                    else
                    {
                        // MessageBox.Show("tipo paciente" + tippac);
                        cn.Open();
                        SqlCommand cmd = new SqlCommand("update ingreso_fichaCmed set Nue_tipopac = '" + tippac + "' where cargo ='" + txtCargo.Text + "';", cn);
                        cmd.ExecuteNonQuery();

                        cn.Close();
                        MessageBox.Show("Tipo paciente modificado");
                    }



                }
                catch (Exception ex)
                {

                    MessageBox.Show("error" + ex);
                }

            


        }

        private void BtnActualizarTipoAtencion_Click(object sender, EventArgs e)
        {
            string tipate ="";


          
                if (radioButton1.Checked)

                {

                    tipate = "STP";
                }

                if (radioButton2.Checked)

                {

                    tipate = "CTP";
                }
                try
                {
                    if (tipate == "")
                    {
                        MessageBox.Show("Debe seleccionar el tipo de Atencion ('STP', 'CTP')");

                    }
                    else
                    {
                        //  MessageBox.Show("tipo paciente" + tipate);
                        cn.Open();
                        SqlCommand cmd = new SqlCommand("update ingreso_fichaCmed set ctpstp_ws = '" + tipate + "' where cargo ='" + txtCargo.Text + "';", cn);
                        cmd.ExecuteNonQuery();

                        cn.Close();
                        MessageBox.Show("Tipo Atencion del paciente modificada");
                    }



                }
                catch (Exception ex)
                {

                    MessageBox.Show("error" + ex);
                }

            
        }

        private void BtnCausal_Click(object sender, EventArgs e)
        {

            string tipcausal = "";


           
                if (radioButton5.Checked)

                {

                    tipcausal = "Accidente de Trabajo";
                }

                if (radioButton6.Checked)

                {

                    tipcausal = "Accidente de Trayecto";
                }
                if (radioButton7.Checked)

                {

                    tipcausal = "Enfermedad Prof.";
                }

                try
                {
                    if (tipcausal == "")
                    {
                        MessageBox.Show("Debe seleccionar el tipo de Causal ('Accidente de Trabajo', 'Accidente de Trayecto', 'Enfermedad Profesional')");

                    }
                    else
                    {
                      //  MessageBox.Show("tipo paciente" + tipcausal);
                        cn.Open();
                        SqlCommand cmd = new SqlCommand("update ingreso_fichaCmed set causal_ws = '" + tipcausal + "',nue_causal='"+tipcausal+"' where cargo ='" + txtCargo.Text + "';", cn);
                        cmd.ExecuteNonQuery();

                        cn.Close();
                        MessageBox.Show("Tipo causal del paciente modificada");

                    }



                }
                catch (Exception ex)
                {

                    MessageBox.Show("error" + ex);
                }

            
        }

        private void BtnFechaAlta_Click(object sender, EventArgs e)
        {

            string fecalt = "";

         

            if (Txtfecalta.Text == "")
            {

                try
                {

                    //   MessageBox.Show("tipo paciente" + fecalt);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("update ingreso_fichaCmed set fecha_alta_ws = NULL where cargo ='" + txtCargo.Text + "';", cn);
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
                fecalt = Txtfecalta.Text + " 00:00:00";

                try
                {


                    //MessageBox.Show("tipo paciente" + fecalt);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("update ingreso_fichaCmed set fecha_alta_ws = '" + fecalt + "' where cargo ='" + txtCargo.Text + "';", cn);
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

        private void BtnDestinoPac_Click(object sender, EventArgs e)
        {


            string tipdest = "";


           
                if (radioButton8.Checked)

                {

                    tipdest = "1";
                }

                if (radioButton9.Checked)

                {

                    tipdest = "2";
                }
             

                try
                {
                    if (tipdest == "")
                    {
                        MessageBox.Show("Debe seleccionar el tipo de Destino del paciente ('Alta', 'Reposo')");

                    }
                    else
                    {
                       // MessageBox.Show("tipo paciente" + tipdest);
                        cn.Open();
                        SqlCommand cmd = new SqlCommand("update ingreso_fichaCmed set nue_alta = '" + tipdest + "',nue_destino= '" + tipdest + "' where cargo ='" + txtCargo.Text + "';", cn);
                        cmd.ExecuteNonQuery();

                        cn.Close();
                        MessageBox.Show("Tipo destino paciente modificado");
                    }




                }
                catch (Exception ex)
                {

                    MessageBox.Show("error" + ex);
                }

            


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


            if (txtCargo.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar cargo de centro medico");
                txtCargo.Focus();

            }
            else if (txtRut.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar rut paciente");
                txtCargo.Focus();
            }
            else

            {
                txtRut.Text = FormatearRut(txtRut.Text);

        //    MessageBox.Show("nuevo rut" + txtRut.Text);



                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("select * from ingreso_fichaCmed with (nolock)  where cargo ='" + txtCargo.Text + "'and rut='" + txtRut.Text + "';", cn);
                    // SqlCommand cmd = new SqlCommand("select * from med_atencion  where fol_ate ='" + txtCargo.Text + "' and num_suc= '" + txtRut.Text + "';", cn);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        lblNombre.Text = Convert.ToString(dr["PACIENTE"]);
                        panel2.Enabled = true;
                        MessageBox.Show("Control Medico encontrado");
                    }
                    else
                    {
                        MessageBox.Show("No se a presionado Guardar al control Medico o No concuerda el Correlativo del Control con el Rut del Paciente");
                        panel2.Enabled = false;
                    }

                    cn.Close();


                }
                catch (Exception ex)
                {

                    MessageBox.Show("error" + ex);
                    panel2.Enabled = false;
                    cn.Close();
                }



            }


           


        }
    }
}
