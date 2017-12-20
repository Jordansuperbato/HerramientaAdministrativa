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
    public partial class InsertarEvocs : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=SRV_SALUD_VINA;Initial Catalog=INGRESOLEY;User ID=sysmk;Password=qT1OVkF7;Integrated Security=false;");
        SqlConnection con = new SqlConnection("Data Source=SRV_SALUD_VINA;Initial Catalog=BDIST;User ID=sysmk;Password=qT1OVkF7;Integrated Security=false;");
        //SqlConnection cn = new SqlConnection("Data Source=NORTE_0_73;Initial Catalog=INGRESOLEY;Integrated Security=true;");
        //SqlConnection con = new SqlConnection("Data Source=NORTE_0_73;Initial Catalog=BDIST;Integrated Security=true;");
      
        public InsertarEvocs()
        {
            InitializeComponent();
          //  groupBox1.Enabled = false;
            cn.Open();
            DataSet ds = new DataSet();
            //indicamos la consulta en SQL y conexion sql
            SqlDataAdapter da = new SqlDataAdapter("select * from PAR_UGA with(nolock) where estado_reg='V' AND DIVISION_MK IS NOT NULL;", cn);
            //se indica el nombre de la tabla
            da.Fill(ds, "Sucursal"); //cod_ugagls_descripcion
            comboBox2.DataSource = ds.Tables[0].DefaultView;
            //se especifica el campo de la tabla
            comboBox2.ValueMember = "gls_descripcion";
           
            cn.Close();

            con.Open();
            DataSet dse = new DataSet();
            //indicamos la consulta en SQL y conexion sql
            SqlDataAdapter das = new SqlDataAdapter("select DISTINCT NOMBRE from MAEPASSWORD with(nolock) where ESTADO='ACTIVO' AND CARGO IN (24,20,19,11,10,9,1,25);", con);
            //se indica el nombre de la tabla
            das.Fill(dse, "Sucursal"); //cod_ugagls_descripcion
            comboBox3.DataSource = dse.Tables[0].DefaultView;
            //se especifica el campo de la tabla
            comboBox3.ValueMember = "nombre";

            con.Close();

        }
       

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

     
        //private void ComboBox2_SelectedIndexChanged() //(object sender, EventArgs e)
        //{
        //    con.Open();
        //    DataSet ds = new DataSet();
        //    //indicamos la consulta en SQL y conexion sql
        //    SqlDataAdapter da = new SqlDataAdapter("select LOGIN,SUCURSAL,NOMBRE from MAEPASSWORD with(nolock) where ESTADO='ACTIVO';", con);
        //    //se indica el nombre de la tabla
        //    da.Fill(ds, "Sucursal"); //cod_ugagls_descripcion
        //    comboBox2.DataSource = ds.Tables[0].DefaultView;
        //    //se especifica el campo de la tabla
        //    comboBox2.ValueMember = "nombre";

        //   con.Close();


        //}

        private void button3_Click(object sender, EventArgs e)

        {


            string sucur = comboBox2.SelectedValue.ToString();

            string tipoevo;

            if (txtCargo.Equals(""))
            {
                MessageBox.Show("DEBE INGRESAR UN FOLIO");
                txtCargo.Focus();

            }

            if (textBox3.Equals(""))
            {
                MessageBox.Show("DEBE INGRESAR FECHA");
                textBox3.Focus();

            }



            if (textBox7.Equals(""))
            {
                MessageBox.Show("DEBE INGRESAR EVOLUCION");
                textBox7.Focus();

            }

            if (comboBox1.Text.Equals("URGENCIA"))
            {
                tipoevo = "4";

            }
            else if (comboBox1.Text.Equals("CONTROL"))
            {
                tipoevo = "20";

            }
            else
            {

                tipoevo = "21";

            }
            string cod_uga = "";
            string cod_comuna = "";
            string cod_mk = "";
            string login_medico = "";
            

           
               
        
           

         
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("select gls_descripcion,cod_uga,cod_comuna_ugg,division_mk from PAR_UGA with (nolock) where ESTADO_REG='V' AND DIVISION_MK IS NOT NULL and gls_descripcion='" + sucur.Trim() + "';", cn);
             
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    cod_uga = Convert.ToString(dr["cod_uga"]);
                    cod_comuna = Convert.ToString(dr["cod_comuna_ugg"]);
                    cod_mk= Convert.ToString(dr["DIVISION_MK"]);
                   cn.Close();
                    
                    try
                    {
                     
                        con.Open();
                        SqlCommand consulta = new SqlCommand("select LOGIN from MAEPASSWORD with(nolock) where  ESTADO='ACTIVO'  and nombre='" + comboBox3.Text.Trim()+"' AND SUCURSAL= '"+cod_mk+"';", con);
                      //  textBox7.Text = "CONSULTA select LOGIN from MAEPASSWORD with(nolock) where ESTADO = 'ACTIVO'  and nombre = '" + comboBox3.Text.Trim() + "' AND SUCURSAL = '" + cod_mk + "';";
                        SqlDataReader result = consulta.ExecuteReader();

                        if (result.Read())
                        {

                            login_medico = Convert.ToString(result["LOGIN"]);

                            String substring = login_medico.Substring(1, 7);

                            con.Close();



                            try
                            {

                                cn.Open();

                                SqlCommand cm = new SqlCommand("INSERT INTO MED_ATENCION_TXT (ID_ADM, FOL_ATE, FEC_TEX, COD_TIP_TEX, UGG_OFI_ATE, UGA_OFI_ATE, COD_UNI_SER, FOL_REC_MED, FOL_RES, TXT_GLS, ESTADO_REG,FEC_ESTADO_REG, FEC_ING_REG, ID_USUARIO_ING_REG, FEC_ULT_MODIF_REG, ID_USUARIO_ULT_MODIF_REG,ID_FUNCION_ULT_MODIF_REG) VALUES ('2','" + txtCargo.Text + "','" + textBox3.Text + "','EVO','" + cod_comuna + "','" + cod_uga + "','" + tipoevo + "',NULL,NULL,'" + textBox7.Text + "','V','" + textBox3.Text + "','" + textBox3.Text + "','" + login_medico + "','" + textBox3.Text+ "','" + Globales.gbUsuario + "','INGRESO.MANUAL');", cn);

                                SqlDataReader ds = cm.ExecuteReader();
                                MessageBox.Show("Evolucion ingresada");
                                cn.Close();
                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show("Error EN INSERTAR EVOLUCION" + ex);
                                cn.Close();
                            }




                        }
                        else
                        {
                            MessageBox.Show("Medico no encontrado en la division seleccionada");
                            con.Close();
                        }




                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("error" + ex);

                        con.Close();
                    }


                }
                else
                {
                    MessageBox.Show("Folio no encontrado");
                    cn.Close();

                }

               


            }
            catch (Exception ex)
            {

                MessageBox.Show("error" + ex);

                cn.Close();
            }


        }
    }
}
