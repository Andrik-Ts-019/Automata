using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    static class principalProgram
    {
        [STAThread]
        static void Main()
        {
            string Nombre = "Pablo Sebastian Ruiz Gallegos";
            string Matricula = "1798237"; 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Principal(Nombre,Matricula));
        }
    }
}
