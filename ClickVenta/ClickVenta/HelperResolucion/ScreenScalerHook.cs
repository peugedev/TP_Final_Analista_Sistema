using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickVenta.HelperResolucion
{
    public static class ScreenScalerHook
    {
        private static bool _installed;

        public static void Install()
        {
            if (_installed) return;
            _installed = true;

            // Cuando un form termina de mostrarse por primera vez, escalarlo.
            Application.Idle += OnIdle;
        }

        private static void OnIdle(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.IsDisposed) continue;
                if (f.Tag as string == "__scaled__") continue;

                // Marcar ANTES de escalar para no entrar en loop
                f.Tag = "__scaled__";
                ScreenScaler.Apply(f);
            }
        }
    }
}
