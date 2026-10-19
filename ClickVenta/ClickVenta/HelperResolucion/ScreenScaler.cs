using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace ClickVenta.HelperResolucion
{
    public static class ScreenScaler
    {
        private const float MinScale = 0.55f;
        private const float MaxScale = 1.40f;
        private const float ScreenUse = 0.95f;  // usa 95% del área útil
        private const float Threshold = 0.02f;

        // Estado original por formulario (una sola captura, la primera vez)
        private class CtrlState
        {
            public Control Ctrl;
            public Point Location;
            public Size Size;
            public float FontSize;
            public FontFamily FontFamily;
            public FontStyle FontStyle;
            public AnchorStyles Anchor;
            public DockStyle Dock;
            public bool AutoSize;
        }

        private class FormState
        {
            public Size DesignSize;
            public List<CtrlState> Controls = new List<CtrlState>();
        }

        private static readonly Dictionary<Form, FormState> _states
            = new Dictionary<Form, FormState>();

        /// <summary>
        /// Aplica escalado proporcional al formulario. Llamar UNA sola vez
        /// desde OnLoad (o desde OnShown) del form.
        /// </summary>
        public static void Apply(Form form)
        {
            if (form == null || form.IsDisposed) return;

            // ---------- 1) Neutralizar AutoScaleMode ----------
            // Evita que WinForms vuelva a escalar después nuestro y deshaga todo.
            form.AutoScaleMode = AutoScaleMode.None;

            // ---------- 2) Capturar estado original (solo la 1ra vez) ----------
            if (!_states.TryGetValue(form, out var state))
            {
                state = CaptureState(form);
                _states[form] = state;
                form.FormClosed += (s, e) => _states.Remove(form);
            }

            // ---------- 3) Calcular factor de escala ----------
            var screen = Screen.FromControl(form);
            var working = screen.WorkingArea;

            float availW = working.Width * ScreenUse;
            float availH = working.Height * ScreenUse;

            float scaleX = availW / state.DesignSize.Width;
            float scaleY = availH / state.DesignSize.Height;
            float scale = Math.Min(scaleX, scaleY);

            if (scale > MaxScale) scale = MaxScale;
            if (scale < MinScale) scale = MinScale;

            // ---------- 4) Aplicar (si hace falta) ----------
            form.SuspendLayout();

            // Quitar MinimumSize para permitir encoger
            form.MinimumSize = Size.Empty;

            // Redimensionar el form
            form.ClientSize = new Size(
                (int)Math.Round(state.DesignSize.Width * scale),
                (int)Math.Round(state.DesignSize.Height * scale)
            );

            foreach (var cs in state.Controls)
            {
                if (cs.Ctrl == null || cs.Ctrl.IsDisposed) continue;

                // Desactivar Anchor/Dock temporalmente para que no peleen
                cs.Ctrl.Anchor = AnchorStyles.None;
                cs.Ctrl.Dock = DockStyle.None;

                // AutoSize=true molesta en algunos controles al forzar Size
                bool prevAutoSize = cs.Ctrl.AutoSize;
                cs.Ctrl.AutoSize = false;

                // Posición y tamaño proporcional
                cs.Ctrl.Location = new Point(
                    (int)Math.Round(cs.Location.X * scale),
                    (int)Math.Round(cs.Location.Y * scale)
                );
                cs.Ctrl.Size = new Size(
                    (int)Math.Round(cs.Size.Width * scale),
                    (int)Math.Round(cs.Size.Height * scale)
                );

                // Restaurar AutoSize original
                cs.Ctrl.AutoSize = prevAutoSize;

                // Escalar fuente (así el texto crece con el form)
                try
                {
                    float fs = cs.FontSize * scale;
                    if (fs >= 1f && fs <= 72f)
                        cs.Ctrl.Font = new Font(cs.FontFamily, fs, cs.FontStyle);
                }
                catch { /* fuentes problemáticas se ignoran */ }

                // Restaurar Anchor/Dock ORIGINAL (para que sigan funcionando
                // si el usuario después redimensiona el form a mano)
                cs.Ctrl.Anchor = cs.Anchor;
                cs.Ctrl.Dock = cs.Dock;
            }

            form.ResumeLayout(true);
            form.PerformLayout();

            // ---------- 5) Centrar en el monitor donde está ----------
            form.StartPosition = FormStartPosition.Manual;
            var wa = screen.WorkingArea;
            form.Location = new Point(
                wa.Left + Math.Max(0, (wa.Width - form.Width) / 2),
                wa.Top + Math.Max(0, (wa.Height - form.Height) / 2)
            );
        }

        private static FormState CaptureState(Form form)
        {
            var st = new FormState { DesignSize = form.ClientSize };
            CaptureControls(form, st.Controls);
            return st;
        }

        private static void CaptureControls(Control parent, List<CtrlState> list)
        {
            foreach (Control c in parent.Controls)
            {
                list.Add(new CtrlState
                {
                    Ctrl = c,
                    Location = c.Location,
                    Size = c.Size,
                    FontSize = c.Font.Size,
                    FontFamily = c.Font.FontFamily,
                    FontStyle = c.Font.Style,
                    Anchor = c.Anchor,
                    Dock = c.Dock,
                    AutoSize = c.AutoSize
                });

                if (c.HasChildren)
                    CaptureControls(c, list);
            }
        }
    }
}
