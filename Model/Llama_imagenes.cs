using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class createImg
    {
        public Image imagenprueba
        {
            set { this.imagenprueba = Images.img_test; }

            get { return imagenprueba; }
        }

        public string nombre
        {
            set { this.nombre = "Andrik"; }

            get { return nombre; }
        }
    }
}
