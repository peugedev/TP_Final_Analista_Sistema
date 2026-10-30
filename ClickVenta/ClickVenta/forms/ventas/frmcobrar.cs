using BusinessEntities.Dtos.cobrar;
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

namespace ClickVenta.forms.ventas
{
    public partial class frmcobrar : Form
    {
        public frmcobrar(CobrarDTO dto)
        {
            InitializeComponent();
            this.lbltotal.Text = dto.Total;
        }

        private void frmcobrar_Load(object sender, EventArgs e)
        {
            radiusform.GetRadius(this);
        }
    }
}
