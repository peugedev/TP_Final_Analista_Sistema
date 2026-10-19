using ClickVenta.HelperResolucion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickVenta.forms.basehelper
{
    public class baseform : Form
    {
        public baseform()
        {
            // Fuente común
            this.Font = new Font("Segoe UI", 9F);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = new Size(400, 300);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // ❗ Clave: si estamos en el diseñador de VS, no hacer nada.
            if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;

            // Aquí se aplica el escalado. Load corre DESPUÉS de que
            // WinForms ya hizo su escalado de DPI, así que partimos
            // del estado "final" del diseñador y solo lo ajustamos.
            ScreenScaler.Apply(this);
        }
    }
}
