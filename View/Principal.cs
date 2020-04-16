using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class Principal : Form
    {
        public Principal(string Nombre, string Matricula)
        {
            InitializeComponent();
            textBoxNombre.Text = Nombre;
            textBoxMatricula.Text = Matricula;
        }
    }
}
