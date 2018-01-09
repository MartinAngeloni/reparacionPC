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

namespace wfaReparacionPC.Formularios
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();

            

            this.Width = 700; //anchura
            this.Height = 500; //altura

            //agregamos las opciones en el combobox tipo PC
            comboTipo.Items.Add("Notebook");
            comboTipo.Items.Add("Netbook");
            comboTipo.Items.Add("PC Escritorio");

            label9.TextAlign = ContentAlignment.MiddleCenter; //titulo en el medio
            

    }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Cliente_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); //cerrar formulario
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Variables.conexion.Open(); //abrimos la conexion a bd
            SqlCommand cmd = Variables.conexion.CreateCommand(); //Crea y devuelve un objeto SqlCommand asociado a la conexión SqlConnection
            cmd.CommandType = CommandType.Text; //establece la instrucción de Transact-SQL
            int dni = 0;
            dni = Convert.ToInt32(textDNI.Text); //convertimos en entero el string del textbox

            SqlCommand cmd2 = Variables.conexion.CreateCommand(); //para la tabla computadora
            cmd2.CommandType = CommandType.Text;

            SqlCommand cmd3 = Variables.conexion.CreateCommand(); //para la tabla Reparacion
            cmd3.CommandType = CommandType.Text;

            string fecha = dateTimePicker1.Value.ToString("yyyy-MM-dd"); //fecha seleccionada

            try
            {
                cmd.CommandText = "insert into Cliente Values('" + dni + "','" + textNombre.Text + "','" + textApellido.Text + "','" + textTelefono.Text + "','" + textDireccion.Text + "')";
                cmd.ExecuteNonQuery();

                Object selectedItem = comboTipo.SelectedItem; //tipo pc seleccionado
                cmd2.CommandText = "insert into Computadora Values('"+ dni +"','"+ textMarca.Text +"','"+textModelo.Text+"','"+ selectedItem .ToString()+ "')";
                cmd2.ExecuteNonQuery();

                //obtenemos el id de la ultima fila agregada
                string query = @"select IDENT_CURRENT('Computadora')";
                SqlCommand cm = new SqlCommand(query, Variables.conexion);
                SqlDataReader drr = cm.ExecuteReader();
                drr.Read();
                int codigo_pc = Convert.ToInt32(drr[0]); //obtenemos la columna codigo_computadora
                drr.Close();


                //subconsulta para fk=pk
                cmd3.CommandText = string.Format("INSERT INTO Reparacion Values("+codigo_pc+",'"+null+"','"+null+"','"+null+"','"+ fecha + "','"+null+"','"+null+"','"+false+"')");
                cmd3.ExecuteNonQuery();

            

            Variables.conexion.Close();

                MessageBox.Show("Carga exitosa");
                textNombre.Clear();
                textApellido.Clear();
                textDNI.Clear();
                textTelefono.Clear();
                textDireccion.Clear();
                textMarca.Clear();
                textModelo.Clear();
               
            }
            catch (SqlException)
            {
                MessageBox.Show("Ha ocurrido un error. Por favor vuelve a intentarlo...");
            }

            


        }

        private void textDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }
    }
}
