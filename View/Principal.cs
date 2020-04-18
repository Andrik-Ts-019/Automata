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
        public Principal(string Nombre, string Apellido, string Matricula)
        {
            InitializeComponent();

            //Le asignamos a los textbox Nombre y Matricula los valores por default
            textBoxNombre.Text = Nombre;
            textBoxApellido.Text = Apellido;
            textBoxMatricula.Text = Matricula;

            //Creamos un objeto de tipo alfabeto_y _gramatica para acceder a sus funciones
            Alfabeto alf1 = new Alfabeto();
            labelMuestraAlfabeto.Text = "{ " + string.Join(",", alf1.obtenerAlfabeto(Nombre.ToLower() + Apellido.ToLower(), Matricula)) + " }";

            //Muestra las expresiones i, j, w, w^I
            Gramatica gram = new Gramatica();
            labelj.Text = "j={ " + string.Join(",", gram.obtenernombre(Nombre.ToLower())) + " }";
            labeli.Text = "i={ " + string.Join(",", gram.obtenerMatricula(Matricula)) + " }";
            labelw.Text = "w={ " + string.Join(",", gram.obteneriniciales(Apellido.ToLower(),1)) + " }";
            labelwi.Text = "w^I={ " + string.Join(",", gram.obteneriniciales(Apellido.ToLower(),2)) + " }";
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            //Validando que haya un dato deentrada en el textBoxNombre
            if (textBoxNombre.Text.Length == 0 || textBoxMatricula.Text.Length == 0 || textBoxApellido.Text.Length == 0)
            {
                MessageBox.Show("No se a ingresado nombre, apellido y/o matricula","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                Condiciones cond = new Condiciones();
                bool mat = cond.validadorMatricula(textBoxMatricula.Text);

                if (mat)
                {
                    //Creamos la lista que tendra a nuestro alfabeto
                    List<char> alfabeto = new List<char>();

                    Alfabeto alf2 = new Alfabeto();
                    alfabeto = alf2.obtenerAlfabeto(textBoxNombre.Text.ToLower() + textBoxApellido.Text.ToLower(), textBoxMatricula.Text);

                    labelMuestraAlfabeto.Text = "{ " + string.Join(",", alf2.obtenerAlfabeto(textBoxNombre.Text.ToLower() + textBoxApellido.Text.ToLower(), textBoxMatricula.Text)) + " }";

                    Gramatica gram2 = new Gramatica();
                    labelj.Text = "j={ " + string.Join(",", gram2.obtenernombre(textBoxNombre.Text.ToLower())) + " }";
                    labeli.Text = "i={ " + string.Join(",", gram2.obtenerMatricula(textBoxMatricula.Text)) + " }";
                    labelw.Text = "w={ " + string.Join(",", gram2.obteneriniciales(textBoxApellido.Text.ToLower(), 1)) + " }";
                    labelwi.Text = "w^I={ " + string.Join(",", gram2.obteneriniciales(textBoxApellido.Text.ToLower(), 2)) + " }";

                    ValidarExpresion vExp = new ValidarExpresion(textBoxNombre.Text,textBoxApellido.Text,textBoxMatricula.Text);

                    //variables booleanas para guardar el estado true false de algunas condiciones
                    bool SoloAlfabeto = cond.EnAlfabeto(textBoxExpresion.Text,alfabeto);
                    bool [] estados = vExp.validar(textBoxExpresion.Text);

                    if (textBoxExpresion.Text.Length != 0)
                    {
                        MessageBox.Show("Esta en alfabeto: " + SoloAlfabeto +
                                        "\nInicia con la matricula: " + estados[0]);
                    }
                    else
                    {
                        MessageBox.Show("USTED INGRESO NADA","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    
                }
                else
                {
                    MessageBox.Show("La matricula debe de tener únicamente números", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
