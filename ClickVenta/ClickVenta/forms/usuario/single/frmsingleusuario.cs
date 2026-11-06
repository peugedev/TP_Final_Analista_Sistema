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

namespace ClickVenta.forms.usuario.single
{
    public partial class frmsingleusuario : Form
    {
        public frmsingleusuario()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmsingleusuario_Load(object sender, EventArgs e)
        {
            radiusform.GetRadius(this);
        }
    }
}
