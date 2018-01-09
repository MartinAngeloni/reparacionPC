using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfaReparacionPC.Formularios;

namespace wfaReparacionPC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            label1.TextAlign = ContentAlignment.MiddleCenter;
            DAOComputadora.obtenerComputadoraSinReparar(); //rellena dataTable
            dataGridView1.DataSource = DAOComputadora.computadoraSinReparar;//da contenido a dataGridView

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            c.ShowDialog();
        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            c.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reparar r = new Reparar();
            r.ShowDialog();
        }
    }
}
