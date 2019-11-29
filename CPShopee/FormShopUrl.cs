using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPShopee
{
    public partial class FormShopUrl : Form
    {
        public DialogResult dialogResult
        {
            get;
            set;
        }
        public String shopUrl
        {
            get;
            set;
        }

        public FormShopUrl()
        {
            InitializeComponent();
            dialogResult = DialogResult.Cancel;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            this.shopUrl = this.txtShopUrl.Text.Trim();
            if(this.shopUrl.Equals(""))
            {
                MessageBox.Show("Link shop không được để trống, xin hãy thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
