using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;

namespace View
{
    public partial class Principal : Form
    {

        public Principal(string Nombre, string Matricula)
        {
            InitializeComponent();

            //Le asignamos a los textbox Nombre y Matricula los valores por default
            textBoxNombre.Text = Nombre;
            textBoxMatricula.Text = Matricula;

            //Creamos un objeto de tipo alfabeto_y _gramatica para acceder a sus funciones
            Alfabeto alf1 = new Alfabeto();
            labelMuestraAlfabeto.Text = "{" + alf1.alfabetoVisible(Nombre,Matricula) + "}";
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            //Validando que haya un dato deentrada en el textBoxNombre
            if (textBoxNombre.Text.Length == 0 || textBoxMatricula.Text.Length == 0)
            {
                MessageBox.Show("No a ingresado algo en Nombre o matricula","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                Alfabeto alf2 = new Alfabeto();
                bool mat = alf2.validadorMatricula(textBoxMatricula.Text);

                if (mat == true)
                {
                    labelMuestraAlfabeto.Text = "{" + alf2.alfabetoVisible(textBoxNombre.Text, textBoxMatricula.Text) + "}";
                }
                else
                {
                    MessageBox.Show("La matricula debe tener puros números", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
