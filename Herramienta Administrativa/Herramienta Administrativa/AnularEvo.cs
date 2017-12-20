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
    public partial class AnularEvo : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=SRV_SALUD_VINA;Initial Catalog=INGRESOLEY;User ID=sysmk;Password=qT1OVkF7;Integrated Security=false;");
        public AnularEvo()
        {
            InitializeComponent();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn.Open();

            SqlCommand cm = new SqlCommand("select GLS_NOM_PER from med_atencion  where fol_ate ='" + txtFol.Text + "';", cn);
            SqlDataReader dr = cm.ExecuteReader();

            if (dr.Read())
            {
                lblNombre.Text = Convert.ToString(dr["GLS_NOM_PER"]);
              
            }
            cn.Close();
            cn.Open();
            SqlCommand cmd = new SqlCommand("select fec_tex AS 'FECHA DE EVOLUCION',CASE COD_UNI_SER when '4' then 'Urgencia' when '20' then 'Centro Medico'when '21' then 'Hospitalizacion' end AS 'TIPO DE ATENCION', txt_gls AS 'TEXTO EVOLUCION' from MED_ATENCION_TXT WITH (NOLOCK)  where fol_ate ='" + txtFol.Text + "'and estado_reg='V' and COD_TIP_TEX='EVO';", cn);
      


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

          
          

            string fecha = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();

            string tipoatencion = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();

           DateTime finperiodo = Convert.ToDateTime(fecha);

            var fechaCorta = finperiodo.ToString("yyyy-MM-dd hh:mm:ss");

            string t = "";

          


            if (tipoatencion.Equals("Urgencia"))
            {
                t = "4";
            }
            if (tipoatencion.Equals("Centro Medico"))
            {
                t = "20";
            }
            if (tipoatencion.Equals("Hospitalizacion"))
            {
                t = "21";
            }

            try
            {
               // MessageBox.Show("fecha" + fechaCorta + "FECHA SIN FORMATO" + fecha + " FECHA DATETIME" + finperiodo);
                cn.Open();
                SqlCommand cm = new SqlCommand("Update med_atencion_txt set estado_reg='E',id_usuario_ult_modif_reg='" + Globales.gbUsuario + "',FEC_ULT_MODIF_REG='" + DateTime.Today.ToString("yyyy-MM-dd hh:mm:ss") + "' where fec_tex ='" + Convert.ToDateTime(fecha).ToString("yyyy-MM-dd HH:mm:ss") + "' and cod_uni_ser =" + t + ";", cn);
                SqlDataReader dr = cm.ExecuteReader();
                MessageBox.Show("Evolucion Modificada");
                cn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }





        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}
