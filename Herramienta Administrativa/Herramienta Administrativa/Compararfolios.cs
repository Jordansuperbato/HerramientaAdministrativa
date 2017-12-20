using Oracle.ManagedDataAccess.Client;
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
    public partial class Compararfolios : Form
    {
        public Compararfolios()
        {
            InitializeComponent();
            dataGridView3.Columns.Add("Primary key", "encontrados");
            dataGridView3.Columns.Add("campo", "distinto");
     //       dataGridView2.Columns.Add("aca", "encontrados");
            btnupdate.Visible = false;
        }
      //  SqlConnection cn = new SqlConnection("Data Source=NORTE_0_73;Initial Catalog=INGRESOLEY3;User ID=sa;Password=jordan;Integrated Security=false;");
        OracleConnection con = new OracleConnection("User Id = nssprod_soporte; Password=sopo753159;Data Source = 170.110.40.19/ist1;");
        SqlConnection cn = new SqlConnection("Data Source=SRV_SALUD_VINA;Initial Catalog=INGRESOLEY;User ID=sysmk;Password=qT1OVkF7;Integrated Security=false;");
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
         

            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("select " + txtcolumna.Text + ","+PK.Text+"  from " + txttabla.Text + " WITH (NOLOCK)  where   estado_reg='V' and fec_ing_reg>='" + fecha.Text+"';", cn);
               // SqlCommand cmd = new SqlCommand("select " + txtcolumna.Text + "  from " + txttabla.Text + " WITH (NOLOCK)  where estado_reg='V' and fec_ing_reg>='" + fecha.Text + "';", cn);

             


                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
               
                dataGridView1.DataSource = dt;
                cn.Close();
                lblcontarley.Text = Convert.ToString((dataGridView1.Rows.Count-1));
            }
            catch (Exception ex)
            {

                MessageBox.Show("error" + ex);
                cn.Close();
            }

            try
            {
                con.Open();


                DateTime prepac = Convert.ToDateTime(fecha.Text);
                var fechaCorta = prepac.ToString("dd-MM-yyyy");

                OracleCommand cm = new OracleCommand("SELECT " + txtcolumna.Text + "," + PK.Text + "  from " + txttabla.Text + " WHERE  estado_reg='V' and  fec_ing_reg >= '" + fechaCorta + "'", con);
                // OracleCommand cm = new OracleCommand("SELECT " + txtcolumna.Text +"  from " + txttabla.Text + " WHERE ESTADO_REG='V' and fec_ing_reg >= '" + fechaCorta + "'", con);


                cm.CommandType = CommandType.Text;
                DataSet dss = new DataSet();
                OracleDataAdapter das = new OracleDataAdapter();
                das.SelectCommand = cm;
                das.Fill(dss);
                dataGridView2.DataSource = dss.Tables[0];
                con.Close();
                lblcontarnet.Text = Convert.ToString((dataGridView2.Rows.Count-1));
            }
            catch (Exception ex)
            {

                MessageBox.Show("error" + ex);
                con.Close();
            }

        }



        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void button3_Click(object sender, EventArgs e)
        {
            String var1 = "";
            String var2 = "";
            String sino = "";
            String tempo = "";
            String prima = "";
            String primary = "hola";
            for (int fila = 0; fila < dataGridView1.Rows.Count - 1; fila++)
            {


                var1 = dataGridView1.Rows[fila].Cells[0].Value + "".Trim();
                prima = dataGridView1.Rows[fila].Cells[1].Value + "".Trim();

                for (int fila2 = 0; fila2 < dataGridView2.Rows.Count - 1; fila2++)
                {


                    var2 = dataGridView2.Rows[fila2].Cells[0].Value + "".Trim();

                    if (var1 == var2 && prima == dataGridView2.Rows[fila2].Cells[1].Value + "".Trim())
                    {

                        sino = "S";
                        break;
                    }
                    else
                    {
                        sino = "N";
                        tempo = var2;//hace referencia al valor de .net del campo consultado
                        primary = prima;



                    }


                }
                if (sino == "N")
                {

                   dataGridView3.Rows.Add(tempo,primary);
                }

            }

            MessageBox.Show("Busqueda finalizada");
            btnupdate.Visible = true;
            label9.Text = Convert.ToString((dataGridView3.Rows.Count - 1));
        }


        
        private void button6_Click(object sender, EventArgs e)
        {
            


            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
           
            dataGridView3.DataSource = null;
          dataGridView3.Rows.Clear();
            lblcontarley.Text = "Numero Registros";
            lblcontarnet.Text = "Numero Registros";
            label9.Text = "";
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

            String var1 = "";
            String var2 = "";

            try
            {
                cn.Open();
            

                for (int fila = 0; fila < dataGridView3.Rows.Count - 1; fila++)
                {

                    var1 = dataGridView3.Rows[fila].Cells[0].Value + "".Trim();
                    var2 = dataGridView3.Rows[fila].Cells[1].Value + "".Trim();
                  //  MessageBox.Show("consulta es= " + "update  " + txttabla.Text + " set " + txtcolumna.Text + " = '" + var1 + "'" + " where " + PK.Text + " = '" + var2 + "';");
                    SqlCommand cmd = new SqlCommand("update  " + txttabla.Text + " set " + txtcolumna.Text + " = '"+var1+"'" + " where " + PK.Text + " = '"+var2+"';", cn);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Actualizacion completada");

                    cn.Close();
                }
            }

            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show("Error "+ex);

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            String var1 = "";
            String var2 = "";
            String sino = "";
            String tempo = "";
            String prima = "";
            String primary = "hola";
            for (int fila = 0; fila < dataGridView2.Rows.Count - 1; fila++)
            {


                var1 = dataGridView2.Rows[fila].Cells[0].Value + "".Trim();
                prima = dataGridView2.Rows[fila].Cells[1].Value + "".Trim();

                for (int fila2 = 0; fila2 < dataGridView1.Rows.Count - 1; fila2++)
                {


                    var2 = dataGridView1.Rows[fila2].Cells[0].Value + "".Trim();

                    if (var1 == var2 && prima == dataGridView1.Rows[fila2].Cells[1].Value + "".Trim())
                    {

                        sino = "S";
                        break;
                    }
                    else
                    {
                        sino = "N";
                        tempo = var1;// hace referencia al valor del campo de net
                        primary = prima;



                    }


                }
                if (sino == "N")
                {

                    dataGridView3.Rows.Add(tempo,primary);
                }

            }

            MessageBox.Show("Busqueda finalizada");
            btnupdate.Visible = true;
            label9.Text= Convert.ToString((dataGridView3.Rows.Count - 1));

        }

        private void button4_Click(object sender, EventArgs e)
        {
            String var1 = "";
            String var2 = "";
            String sino = "";
            String tempo = "";
            String prima = "";
            String primary = "hola";
            dataGridView2.DataSource = null;
            for (int fila = 0; fila < dataGridView3.Rows.Count - 1; fila++)
            {

                var1 = dataGridView3.Rows[fila].Cells[0].Value + "".Trim();
                prima = dataGridView3.Rows[fila].Cells[1].Value + "".Trim();


                OracleCommand cm = new OracleCommand("SELECT * from "+txttabla.Text+" where "+PK.Text+" ='"+ var1 + "'", con);
                // OracleCommand cm = new OracleCommand("SELECT " + txtcolumna.Text +"  from " + txttabla.Text + " WHERE ESTADO_REG='V' and fec_ing_reg >= '" + fechaCorta + "'", con);



                cm.CommandType = CommandType.Text;
                DataSet dss = new DataSet();
                OracleDataAdapter das = new OracleDataAdapter();
                das.SelectCommand = cm;
                das.Fill(dss);
                dataGridView2.DataSource = dss.Tables[0];
                
              //  dataGridView2.Rows.Add(das.Fill(dss.Tables[0]));
                con.Close();
                lblcontarnet.Text = Convert.ToString((dataGridView2.Rows.Count - 1));



            }

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



            //        // Application.Exit();
            //    }
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show("a" + ex);
            //}



        }
    }
 }

