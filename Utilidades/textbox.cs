
using System.ComponentModel;
using System.Windows.Forms;

namespace Utilidades
{
    public partial class textbox : TextBox
    {
        public bool Validar { set; get; }
        
        public textbox()
        {
            InitializeComponent();
        }

        public textbox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                SendKeys.Send("{tab}");
        }
    }
}
