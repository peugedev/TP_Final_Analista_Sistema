using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickVenta.Config
{
    public class ShareMethod
    {
        private static ShareMethod factory;
        public static ShareMethod GetInstance()
        {
            if (factory == null)
                factory = new ShareMethod();
            return factory;
        }

        public void goFirst()
        {
            SystemConstant.pageactual = Convert.ToInt32(1);
            SystemConstant.skipamount = Convert.ToInt32(1);
        }

        public void goNext()
        {
            SystemConstant.skipamount++;
            SystemConstant.pageactual++;
        }

        public void goLast(Int64 amount)
        {
            SystemConstant.pageamount = amount;
            SystemConstant.page = Math.Ceiling(SystemConstant.pageamount / SystemConstant.pagesize);
            SystemConstant.pageactual = Convert.ToInt32(SystemConstant.page);
            SystemConstant.skipamount = Convert.ToInt32(SystemConstant.page);
        }

        public void goPrevious()
        {
            SystemConstant.pageactual--;
            SystemConstant.skipamount--;
        }

        public void HabilitarBtnPagination(List<Button> btn, Boolean val)
        {
            foreach (var item in btn)
            {
                item.Enabled = val;
            }
        }

        public void HabilityTextBox(List<TextBox> txt, Boolean val)
        {
            foreach (var item in txt)
            {
                item.Enabled = val;
            }
        }

        public void HabilityComboBox(List<ComboBox> txt, Boolean val)
        {
            foreach (var item in txt)
            {
                item.Enabled = val;
            }
        }

        public void HabilityPagenation(List<Button> btn, List<Label> lbl, Boolean val)
        {
            if (btn.Count() > 0)
            {
                for (int I = 0; I < btn.Count(); I++)
                {
                    btn[I].Visible = val;
                    if (I < 3)
                        lbl[I].Visible = val;
                }
            }
            else
            {
                MessageBox.Show("Datos incorrectos", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
