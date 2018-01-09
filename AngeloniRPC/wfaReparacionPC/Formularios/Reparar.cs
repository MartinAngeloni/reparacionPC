using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaReparacionPC.Formularios
{
    public partial class Reparar : Form
    {
        public Reparar()
        {
            InitializeComponent();

            this.Width = 900; //anchura
            this.Height = 600; //altura
            label1.TextAlign = ContentAlignment.MiddleCenter;//titulo al centro

            DAOComputadora.obtenerComputadoraSinReparar(); //rellena dataTable
            dataGridView1.DataSource = DAOComputadora.computadoraSinReparar; //rellenar dataGridView pc sin reparar

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Reparar_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //sintaxis para busqueda en dataGridView
            //busca las columnas con alias
            DataView dataView = DAOComputadora.computadoraSinReparar.DefaultView;
            dataView.RowFilter = string.Format("Computadora like '%{0}%' or Marca like '%{0}%'", textBox1.Text); //busqueda por nombre o marca
            dataGridView1.DataSource = dataView;
        }
    }
}
