using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilidades
{
    public partial class maskedTexbox : System.Windows.Forms.MaskedTextBox
    {
        public bool Validar { set; get; }
        public maskedTexbox()
        {
            InitializeComponent();
        }

        public maskedTexbox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void maskedTexbox_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                SendKeys.Send("{tab}");
        }
    }
}
