using System;
using System.Windows.Forms;

namespace Selector
{
    public partial class Form2 : Form
    {
        int resultado = 0 ;
    
        public Form2()
        {
            InitializeComponent();
            textBox1.Text = "Bienvenido " + Form1.usrName; //Texto de bienvenida, cargado al iniciar el formulario.
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); //Cerrar programa.
        }

        private void btnSalir(object sender, EventArgs e)
        {
            if (MessageBox.Show(Form1.usrName+", ¿seguro que quieres salir y cerrar el programa?", "Confirmación de salida", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Application.Exit(); // Si el usuario eligió "Sí", cerrar aplicación.
            }

        }

        private void btnEvaluar(object sender, EventArgs e) //Evaluación de resultados.
        {
            if (radioButton1.Checked) { resultado = resultado + 1; } //Asignando valores a los botones tipo radio.
            if (radioButton2.Checked) { resultado = resultado + 2; }
            if (radioButton3.Checked) { resultado = resultado + 3; }

            if (radioButton4.Checked) { resultado = resultado + 1; }
            if (radioButton5.Checked) { resultado = resultado + 2; }
            if (radioButton6.Checked) { resultado = resultado + 3; }

            if (radioButton7.Checked) { resultado = resultado + 1; }
            if (radioButton8.Checked) { resultado = resultado + 2; }
            if (radioButton9.Checked) { resultado = resultado + 3; }

            if (radioButton10.Checked) { resultado = resultado + 1; }
            if (radioButton11.Checked) { resultado = resultado + 2; }
            if (radioButton12.Checked) { resultado = resultado + 3; }


            if (resultado == 0)
            { 
                MessageBox.Show(Form1.usrName + ", asegúrate de contestar todas las preguntas primero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                resultado = 0;
            }

            if (resultado == 4)
            {
                MessageBox.Show(Form1.usrName + ", quizás deberías tocar los bongós.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                resultado = 0;
            }

            if (resultado == 5)
            {
                MessageBox.Show(Form1.usrName + ", quizás serías bueno tocando el bajo eléctrico.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                resultado = 0;
            }

            if (resultado == 6)
            {
                MessageBox.Show(Form1.usrName + ", quizás podrías tocar el acordeón.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                resultado = 0;
            }

            if (resultado == 7)
            {
                MessageBox.Show(Form1.usrName + ", quizás serías ágil tocando el Cello.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                resultado = 0;
            }

            if (resultado == 8)
            {
                MessageBox.Show(Form1.usrName + ", quizás deberías tocar la guitarra.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                resultado = 0;
            }

            if (resultado == 9)
            {
                MessageBox.Show(Form1.usrName + ", quizás serías bueno tocando el piano.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                resultado = 0;
            }

            if (resultado == 10)
            {
                MessageBox.Show(Form1.usrName + ", quizás serías ágil tocando la batería.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                resultado = 0;
            }

            if (resultado == 11)
            {
                MessageBox.Show(Form1.usrName + ", quizás serías ágil tocando la trompeta.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                resultado = 0;
            }

            if (resultado == 12)
            {
                MessageBox.Show(Form1.usrName + ", quizás serías ágil tocando la flauta.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                resultado = 0;
            }

        }


        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //Mostrar nombre de usuario en la etiqueta de texto
        {
            Form1 form1 = new Form1(); //Declaración de nuevo formulario.
            form1.Show(); //Mostrar Formulario 2
            this.Hide(); //Esconder formulario
        }

    }
}