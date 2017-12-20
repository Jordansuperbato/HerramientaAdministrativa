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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            button7.Visible = false;
            button7.Enabled = false;
        }
        private void BtnRevocar_Click(object sender, EventArgs e)
        {
            RevocacionAlta ja = new RevocacionAlta();

            ja.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

           // button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AnularEvo anu = new AnularEvo();
            anu.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CambiarFolio xx = new CambiarFolio();
            xx.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CambioFolio dd = new CambioFolio();
            dd.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 ini = new Form1();
            ini.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AnulacionAlta anu = new AnulacionAlta();
            anu.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            InsertarEvocs inse = new InsertarEvocs();
            inse.Show();
            this.Hide();
        }
    }
}
 