using ClickVenta.forms.usuario.single;
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

namespace ClickVenta.forms.usuario
{
    public partial class frmgestionusuario : Form
    {
        public frmgestionusuario()
        {
            InitializeComponent();
        }

        private void frmgestionusuario_Load(object sender, EventArgs e)
        {
            radiusform.GetRadius(this);
        }

        private void clickVentaButton4_Click(object sender, EventArgs e)
        {
            frmsingleusuario frm = new frmsingleusuario();
            frm.ShowDialog();
        }
    }
}
