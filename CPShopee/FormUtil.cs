using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CPShopee
{
    public class FormUtil
    {
        public static void CreateControlToolTip(Control c , String caption)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(c, caption);
        }
    }
}
