using ClickVenta.forndesign;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickVenta.forms.Reportes
{
    public partial class frmreporte : Form
    {
        public frmreporte()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmreporte_Load(object sender, EventArgs e)
        {
            radiusform.GetRadius(this);
        }
    }
}
