using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herramienta_Administrativa
{
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void BtnRevocar_Click(object sender, EventArgs e)
        {
            RevocacionAlta revo = new RevocacionAlta();
            revo.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CambiarFolio cambi = new CambiarFolio();
            cambi.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CambioFolio cambo = new CambioFolio();
            cambo.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AnularEvo anu = new AnularEvo();
            anu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FolioVigente fol = new FolioVigente();
            fol.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FolioTraslapados tras = new FolioTraslapados();
            tras.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 fors = new Form1();
            fors.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Compararfolios com = new Compararfolios();
            com.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            InsertarAlta a = new InsertarAlta();
            a.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            InsertarEvocs insertt = new InsertarEvocs();
            insertt.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AnulacionAlta anu = new AnulacionAlta();
            anu.Show();
            this.Hide();
           
        }

        private void button12_Click(object sender, EventArgs e)
        {
            InsertarCotPlanillaNom vd = new InsertarCotPlanillaNom();
            vd.Show();
            this.Hide();
        }
    }
}
