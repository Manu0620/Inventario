
using System.ComponentModel;
using System.Windows.Forms;

namespace Utilidades
{
    public partial class boton : Button
    {
        public boton()
        {
            InitializeComponent();
        }

        public boton(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
