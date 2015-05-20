using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Selector
{
    public partial class Form3 : Form
    {               
        MySqlCommand Query = new MySqlCommand();
        MySqlConnection Conexion;
        MySqlDataReader consultar;
        public string sql = "server=localhost; user id=root; password = BIONICLE4012; persistsecurityinfo=True; database=datos";

        
        

        public Form3()
        {            
            InitializeComponent();
            
            textUsr.Text =  Form1.usrName+", este es el instrumento que quizás podrías tocar:"; //Texto de bienvenida, cargado al iniciar el formulario.

            try //Intentar consulta.
            {
                Conexion = new MySqlConnection();
                Conexion.ConnectionString = sql;
                Conexion.Open();
                Query.CommandText = "SELECT * FROM datos.instrumentos WHERE idinstrumentos="+Form2.idInstrumento;
                Query.Connection = Conexion;
                consultar = Query.ExecuteReader();
                
                while (consultar.Read()) //Mientras ocurra la lectura, imprimir datos en las cajas de texto correspondientes.
                {
                    string nombre = consultar.GetString(1);
                    string descripcion = consultar.GetString(2);
                    string imagen = consultar.GetString(3);

                    txtNombre.Text = nombre;
                    txtDesc.Text = descripcion;                    
                    pictureBox1.ImageLocation = imagen;
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }

                Conexion.Close();
            }

            catch (MySqlException ex) //Reacción en caso de error.
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Form1.usrName+", ¿seguro que quieres salir y cerrar el programa?", "Confirmación de salida", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Application.Exit(); // Si el usuario eligió "Sí", cerrar aplicación.
            }        
        }

        public void btnCerrar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            
            this.Close();
        }
       
    }
}
