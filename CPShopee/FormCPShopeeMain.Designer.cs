namespace CPShopee
{
    partial class FormCPShopeeMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCPShopeeMain));
            this.statusToolbar = new System.Windows.Forms.StatusStrip();
            this.toolStatusMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnCoppyShop = new System.Windows.Forms.Button();
            this.grpShopInfo = new System.Windows.Forms.GroupBox();
            this.lbShopId = new System.Windows.Forms.Label();
            this.lbRatting = new System.Windows.Forms.Label();
            this.lbPeopleFollow = new System.Windows.Forms.Label();
            this.lbReplyTime = new System.Windows.Forms.Label();
            this.lbFollow = new System.Windows.Forms.Label();
            this.lbPrepareTime = new System.Windows.Forms.Label();
            this.lbProductInfo = new System.Windows.Forms.Label();
            this.toolMain = new System.Windows.Forms.ToolStrip();
            this.toolBtnLoadShopInfo = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabelShopName = new System.Windows.Forms.ToolStripLabel();
            this.toolStripBtnReload = new System.Windows.Forms.ToolStripButton();
            this.panelBody = new System.Windows.Forms.Panel();
            this.panelBodyFooter = new System.Windows.Forms.Panel();
            this.lbPage = new System.Windows.Forms.Label();
            this.cbbPage = new System.Windows.Forms.ComboBox();
            this.toolStripDownloadImage = new System.Windows.Forms.ToolStripButton();
            this.statusToolbar.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.grpShopInfo.SuspendLayout();
            this.toolMain.SuspendLayout();
            this.panelBodyFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusToolbar
            // 
            this.statusToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStatusMain});
            this.statusToolbar.Location = new System.Drawing.Point(0, 476);
            this.statusToolbar.Name = "statusToolbar";
            this.statusToolbar.Size = new System.Drawing.Size(1070, 22);
            this.statusToolbar.TabIndex = 0;
            this.statusToolbar.Text = "statusStrip1";
            // 
            // toolStatusMain
            // 
            this.toolStatusMain.BackColor = System.Drawing.SystemColors.Control;
            this.toolStatusMain.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStatusMain.Name = "toolStatusMain";
            this.toolStatusMain.Size = new System.Drawing.Size(66, 17);
            this.toolStatusMain.Text = "Trạng thái:";
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.SystemColors.Control;
            this.panelLeft.Controls.Add(this.btnCoppyShop);
            this.panelLeft.Controls.Add(this.grpShopInfo);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(319, 476);
            this.panelLeft.TabIndex = 1;
            // 
            // btnCoppyShop
            // 
            this.btnCoppyShop.Enabled = false;
            this.btnCoppyShop.Image = ((System.Drawing.Image)(resources.GetObject("btnCoppyShop.Image")));
            this.btnCoppyShop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCoppyShop.Location = new System.Drawing.Point(3, 278);
            this.btnCoppyShop.Name = "btnCoppyShop";
            this.btnCoppyShop.Size = new System.Drawing.Size(313, 33);
            this.btnCoppyShop.TabIndex = 1;
            this.btnCoppyShop.Text = "Sao chép shop";
            this.btnCoppyShop.UseVisualStyleBackColor = true;
            // 
            // grpShopInfo
            // 
            this.grpShopInfo.BackColor = System.Drawing.SystemColors.Control;
            this.grpShopInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpShopInfo.Controls.Add(this.lbShopId);
            this.grpShopInfo.Controls.Add(this.lbRatting);
            this.grpShopInfo.Controls.Add(this.lbPeopleFollow);
            this.grpShopInfo.Controls.Add(this.lbReplyTime);
            this.grpShopInfo.Controls.Add(this.lbFollow);
            this.grpShopInfo.Controls.Add(this.lbPrepareTime);
            this.grpShopInfo.Controls.Add(this.lbProductInfo);
            this.grpShopInfo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grpShopInfo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpShopInfo.Location = new System.Drawing.Point(3, 27);
            this.grpShopInfo.Name = "grpShopInfo";
            this.grpShopInfo.Size = new System.Drawing.Size(313, 245);
            this.grpShopInfo.TabIndex = 0;
            this.grpShopInfo.TabStop = false;
            this.grpShopInfo.Text = "Thông tin shop";
            // 
            // lbShopId
            // 
            this.lbShopId.AutoSize = true;
            this.lbShopId.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShopId.Location = new System.Drawing.Point(9, 218);
            this.lbShopId.Name = "lbShopId";
            this.lbShopId.Size = new System.Drawing.Size(80, 15);
            this.lbShopId.TabIndex = 6;
            this.lbShopId.Text = "Mã cửa hàng:";
            // 
            // lbRatting
            // 
            this.lbRatting.AutoSize = true;
            this.lbRatting.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRatting.Location = new System.Drawing.Point(9, 190);
            this.lbRatting.Name = "lbRatting";
            this.lbRatting.Size = new System.Drawing.Size(58, 15);
            this.lbRatting.TabIndex = 5;
            this.lbRatting.Text = "Đánh giá:";
            // 
            // lbPeopleFollow
            // 
            this.lbPeopleFollow.AutoSize = true;
            this.lbPeopleFollow.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPeopleFollow.Location = new System.Drawing.Point(9, 162);
            this.lbPeopleFollow.Name = "lbPeopleFollow";
            this.lbPeopleFollow.Size = new System.Drawing.Size(90, 15);
            this.lbPeopleFollow.TabIndex = 4;
            this.lbPeopleFollow.Text = "Người theo dõi:";
            // 
            // lbReplyTime
            // 
            this.lbReplyTime.AutoSize = true;
            this.lbReplyTime.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReplyTime.Location = new System.Drawing.Point(9, 133);
            this.lbReplyTime.Name = "lbReplyTime";
            this.lbReplyTime.Size = new System.Drawing.Size(113, 15);
            this.lbReplyTime.TabIndex = 3;
            this.lbReplyTime.Text = "Tỷ lệ phản hồi chat:";
            // 
            // lbFollow
            // 
            this.lbFollow.AutoSize = true;
            this.lbFollow.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFollow.Location = new System.Drawing.Point(9, 102);
            this.lbFollow.Name = "lbFollow";
            this.lbFollow.Size = new System.Drawing.Size(86, 15);
            this.lbFollow.TabIndex = 2;
            this.lbFollow.Text = "Đang theo dõi:";
            // 
            // lbPrepareTime
            // 
            this.lbPrepareTime.AutoSize = true;
            this.lbPrepareTime.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrepareTime.Location = new System.Drawing.Point(9, 64);
            this.lbPrepareTime.Name = "lbPrepareTime";
            this.lbPrepareTime.Size = new System.Drawing.Size(140, 15);
            this.lbPrepareTime.TabIndex = 1;
            this.lbPrepareTime.Text = "Thời gian chuẩn bị hàng:";
            // 
            // lbProductInfo
            // 
            this.lbProductInfo.AutoSize = true;
            this.lbProductInfo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductInfo.Location = new System.Drawing.Point(9, 35);
            this.lbProductInfo.Name = "lbProductInfo";
            this.lbProductInfo.Size = new System.Drawing.Size(62, 15);
            this.lbProductInfo.TabIndex = 0;
            this.lbProductInfo.Text = "Sản phẩm:";
            // 
            // toolMain
            // 
            this.toolMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnLoadShopInfo,
            this.toolStripLabelShopName,
            this.toolStripBtnReload,
            this.toolStripDownloadImage});
            this.toolMain.Location = new System.Drawing.Point(319, 0);
            this.toolMain.Name = "toolMain";
            this.toolMain.Size = new System.Drawing.Size(751, 25);
            this.toolMain.TabIndex = 2;
            this.toolMain.Text = "toolStrip1";
            // 
            // toolBtnLoadShopInfo
            // 
            this.toolBtnLoadShopInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnLoadShopInfo.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnLoadShopInfo.Image")));
            this.toolBtnLoadShopInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnLoadShopInfo.Name = "toolBtnLoadShopInfo";
            this.toolBtnLoadShopInfo.Size = new System.Drawing.Size(23, 22);
            this.toolBtnLoadShopInfo.Text = "Tải thông tin shop nguồn";
            this.toolBtnLoadShopInfo.Click += new System.EventHandler(this.toolBtnLoadShopInfo_Click);
            // 
            // toolStripLabelShopName
            // 
            this.toolStripLabelShopName.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabelShopName.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabelShopName.Image")));
            this.toolStripLabelShopName.Name = "toolStripLabelShopName";
            this.toolStripLabelShopName.Size = new System.Drawing.Size(16, 22);
            this.toolStripLabelShopName.ToolTipText = "Tên cửa hàng";
            // 
            // toolStripBtnReload
            // 
            this.toolStripBtnReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnReload.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnReload.Image")));
            this.toolStripBtnReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnReload.Name = "toolStripBtnReload";
            this.toolStripBtnReload.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnReload.Text = "Tải lại thông tin shop";
            this.toolStripBtnReload.Click += new System.EventHandler(this.toolStripBtnReload_Click);
            // 
            // panelBody
            // 
            this.panelBody.AutoScroll = true;
            this.panelBody.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(319, 25);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(751, 451);
            this.panelBody.TabIndex = 3;
            // 
            // panelBodyFooter
            // 
            this.panelBodyFooter.BackColor = System.Drawing.SystemColors.Control;
            this.panelBodyFooter.Controls.Add(this.lbPage);
            this.panelBodyFooter.Controls.Add(this.cbbPage);
            this.panelBodyFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBodyFooter.Location = new System.Drawing.Point(319, 444);
            this.panelBodyFooter.Name = "panelBodyFooter";
            this.panelBodyFooter.Size = new System.Drawing.Size(751, 32);
            this.panelBodyFooter.TabIndex = 4;
            // 
            // lbPage
            // 
            this.lbPage.AutoSize = true;
            this.lbPage.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPage.Location = new System.Drawing.Point(6, 7);
            this.lbPage.Name = "lbPage";
            this.lbPage.Size = new System.Drawing.Size(42, 15);
            this.lbPage.TabIndex = 1;
            this.lbPage.Text = "Trang:";
            // 
            // cbbPage
            // 
            this.cbbPage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPage.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPage.FormattingEnabled = true;
            this.cbbPage.Location = new System.Drawing.Point(54, 4);
            this.cbbPage.Name = "cbbPage";
            this.cbbPage.Size = new System.Drawing.Size(100, 23);
            this.cbbPage.TabIndex = 0;
            this.cbbPage.SelectedIndexChanged += new System.EventHandler(this.cbbPage_SelectedIndexChanged);
            // 
            // toolStripDownloadImage
            // 
            this.toolStripDownloadImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDownloadImage.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDownloadImage.Image")));
            this.toolStripDownloadImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDownloadImage.Name = "toolStripDownloadImage";
            this.toolStripDownloadImage.Size = new System.Drawing.Size(23, 22);
            this.toolStripDownloadImage.Text = "Tải ảnh về máy";
            this.toolStripDownloadImage.Click += new System.EventHandler(this.toolStripDownloadImage_Click);
            // 
            // FormCPShopeeMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1070, 498);
            this.Controls.Add(this.panelBodyFooter);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.toolMain);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.statusToolbar);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCPShopeeMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CÔNG CỤ HỖ TRỢ SAO CHÉP SHOPEE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCPShopeeMain_FormClosing);
            this.Load += new System.EventHandler(this.FormCPShopeeMain_Load);
            this.statusToolbar.ResumeLayout(false);
            this.statusToolbar.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.grpShopInfo.ResumeLayout(false);
            this.grpShopInfo.PerformLayout();
            this.toolMain.ResumeLayout(false);
            this.toolMain.PerformLayout();
            this.panelBodyFooter.ResumeLayout(false);
            this.panelBodyFooter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusToolbar;
        private System.Windows.Forms.ToolStripStatusLabel toolStatusMain;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.ToolStrip toolMain;
        private System.Windows.Forms.ToolStripButton toolBtnLoadShopInfo;
        private System.Windows.Forms.GroupBox grpShopInfo;
        private System.Windows.Forms.Label lbShopId;
        private System.Windows.Forms.Label lbRatting;
        private System.Windows.Forms.Label lbPeopleFollow;
        private System.Windows.Forms.Label lbReplyTime;
        private System.Windows.Forms.Label lbFollow;
        private System.Windows.Forms.Label lbPrepareTime;
        private System.Windows.Forms.Label lbProductInfo;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.ToolStripLabel toolStripLabelShopName;
        private System.Windows.Forms.ToolStripButton toolStripBtnReload;
        private System.Windows.Forms.Button btnCoppyShop;
        private System.Windows.Forms.Panel panelBodyFooter;
        private System.Windows.Forms.ComboBox cbbPage;
        private System.Windows.Forms.Label lbPage;
        private System.Windows.Forms.ToolStripButton toolStripDownloadImage;
    }
}

