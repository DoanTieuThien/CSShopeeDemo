namespace CPShopee
{
    partial class FormShopUrl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShopUrl));
            this.txtShopUrl = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lbLinkShopee = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtShopUrl
            // 
            this.txtShopUrl.Location = new System.Drawing.Point(104, 12);
            this.txtShopUrl.Name = "txtShopUrl";
            this.txtShopUrl.Size = new System.Drawing.Size(334, 26);
            this.txtShopUrl.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoad.Location = new System.Drawing.Point(300, 44);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(138, 29);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Tải thông tin";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lbLinkShopee
            // 
            this.lbLinkShopee.AutoSize = true;
            this.lbLinkShopee.Location = new System.Drawing.Point(12, 21);
            this.lbLinkShopee.Name = "lbLinkShopee";
            this.lbLinkShopee.Size = new System.Drawing.Size(86, 19);
            this.lbLinkShopee.TabIndex = 2;
            this.lbLinkShopee.Text = "Link shopee:";
            // 
            // FormShopUrl
            // 
            this.AcceptButton = this.btnLoad;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 83);
            this.Controls.Add(this.lbLinkShopee);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtShopUrl);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormShopUrl";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đường link tói shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtShopUrl;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lbLinkShopee;
    }
}