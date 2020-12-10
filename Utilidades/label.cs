
using System.ComponentModel;

namespace Utilidades
{
    public partial class label : System.Windows.Forms.Label
    {
        public label()
        {
            InitializeComponent();
        }

        public label(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
