﻿
using System.ComponentModel;
using System.Windows.Forms;

namespace Utilidades
{
    public partial class panel : Panel
    {
        public panel()
        {
            InitializeComponent();
        }

        public panel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
