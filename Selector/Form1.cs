using System;
using System.Windows.Forms;

namespace Selector
{
    public partial class Form1 : Form
    {       
        public static string usrName { get; set; } //Variable pública con el nombre de usuario.
        
        public Form1()
        {
            InitializeComponent(); //Iniciar componente de Windows.Forms
        }

        private void txtUsrName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Obligar a que sólo se introduzcan letras 
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
                {
                    e.Handled = false;
                }
                else
                {
                    //el resto de teclas pulsadas se desactivan 
                    e.Handled = true;
                }
        } 

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            usrName = txtUsrName.Text; //Cuadro de texto.



            if (usrName != "") //Si el nombre de usuario no esta vacío...
            {
                Form2 form2 = new Form2(); //Declaración de nuevo formulario.
                form2.Show(); //Mostrar Formulario 2
                this.Hide(); //Esconder este formulario (La aplicación continuará abierta.)
            }
            else //Si el cuadro "Nombre" está en blanco...
            {
                MessageBox.Show("Por favor ingresa tu nombre en el cuadro. \n(Recuerda no usar números)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Cerrar la aplicación.
        }

    }
}
