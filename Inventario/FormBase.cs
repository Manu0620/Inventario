using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Inventario
{
    public partial class FormBase : Form
    {
        public DataSet DS = new DataSet();
        public ReportViewer reporte = new ReportViewer();

        public bool PuedeSalvar { set; get; }
        public bool PuedeEliminar { set; get; }
        public bool PuedeConsultar { set; get; }
        public bool PuedeImprimir { set; get; }

        public FormBase()
        {
            InitializeComponent();
        }

        public virtual void Guardar()
        {
            
        }

        public virtual void Eliminar ()
        {
            
        }

        public virtual void Consultar()
        {
            
        }

        public virtual void Limpiar()
        {
            
        }

        public virtual void Imprimir()
        {
            
        }
    }
}
