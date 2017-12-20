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
    public partial class FolioVigente : Form
    {
        // SqlConnection cn = new SqlConnection("Data Source=NORTE_0_73;Persist Security Info=True;Initial Catalog=INGRESOLEY;Integrated Security=true;");
        SqlConnection cn = new SqlConnection("Data Source=SRV_SALUD_VINA;Initial Catalog=INGRESOLEY;User ID=sysmk;Password=qT1OVkF7;Integrated Security=false;");
        public FolioVigente()
        {
            InitializeComponent();
          
         

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

        private void BtnEliminar_Click(object sender, EventArgs e)

        {

       

            string folio = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();

         



        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("select a.FOL_ATE,a.FEC_ALT_PAC,a.RUT_PER,a.FEC_ATE_PAC from MED_ATENCION  a  with(nolock) WHERE a.ESTADO_REG='V' and a.FEC_ULT_MODIF_REG>='2017-02-20' and substring(a.FOL_ATE,15,18)='-000'  AND a.FEC_ALT_PAC is null and substring(a.FOL_ATE,1,14) in (select substring(b.FOL_ATE,1,14) from MED_ATENCION b with(nolock) WHERE b.ESTADO_REG='V' and b.FEC_ULT_MODIF_REG>='2017-02-20' and substring(b.FOL_ATE,15,18)<>'-000') order by a.FOL_ATE DESC;", cn);



                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                cn.Close();
               
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
                cn.Close();
            }
           
        }

       
    }
}

