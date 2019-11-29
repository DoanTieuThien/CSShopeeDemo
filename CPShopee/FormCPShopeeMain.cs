using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CPShopee
{
    public partial class FormCPShopeeMain : Form
    {
        //private ChromeDriver _chromeDriver = null;
        private Boolean isTheFirstLoadProduct = true;
        private int currentPage = 1;
        private List<String> mlsListImages = null;

        public FormCPShopeeMain()
        {
            InitializeComponent();
            //ChromeOptions chromeOptions = new ChromeOptions();
            //chromeOptions.AddArgument("headless");
            //var driverService = ChromeDriverService.CreateDefaultService();
            //driverService.HideCommandPromptWindow = true;
            //// @"E:\CSharp\CPShopee\packages\Selenium.WebDriver.ChromeDriver.77.0.3865.4000\driver\win32",
            //this._chromeDriver = new ChromeDriver( driverService, chromeOptions,TimeSpan.FromSeconds(120));
        }

        private void FormCPShopeeMain_Load(object sender, EventArgs e)
        {
            this.toolStatusMain.Text = buildStatusTool("Khởi động thành công");
        }

        private String httpGetRequest(String url, String shopName)
        {
            string html = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            request.AutomaticDecompression = DecompressionMethods.GZip;
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/77.0.3865.120 Safari/537.36";
            request.ReadWriteTimeout = 120 * 1000;
            if (shopName != null)
            {
                //header need when request
                request.Referer = "https://shopee.vn/" + shopName + "?smtt=0.0.9";
            }

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }
            return html;
        }

        private void toolBtnLoadShopInfo_Click(object sender, EventArgs e)
        {
            try
            {
                isTheFirstLoadProduct = true;
                this.toolStatusMain.Text = buildStatusTool("Đang đợi nhập đường dẫn shop");
                FormShopUrl formShopUrl = new FormShopUrl();
                formShopUrl.ShowDialog();
                if(formShopUrl.dialogResult == DialogResult.Cancel)
                {
                    this.toolStatusMain.Text = buildStatusTool("Đã hủy nhập đường dẫn shop");
                    return;
                }
                this.toolStripLabelShopName.Text = formShopUrl.shopUrl;
                this.toolStatusMain.Text = buildStatusTool("Đang tải thông tin về shop " + formShopUrl.shopUrl);
                //this._chromeDriver.Url = formShopUrl.shopUrl;
                //this._chromeDriver.Navigate();
                this.toolStatusMain.Text = buildStatusTool("Truy cập shop thành công");
                ShopInfoModule shopInfoModule = loadShopInfo(formShopUrl.shopUrl);

                if (shopInfoModule != null)
                {
                    loadShopProduct(shopInfoModule.shopId, formShopUrl.shopUrl);
                }
                this.toolStatusMain.Text = buildStatusTool("Hiện tại có " + this.panelBody.Controls.Count + " sản phẩm" );
                isTheFirstLoadProduct = false;
            }
            catch(Exception exp)
            {
                MessageBox.Show( "Lối thực hiện: " + exp.Message,"Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.toolStatusMain.Text = buildStatusTool("Lỗi thực hiện tải thông tin shop");
            }
        }

        private void FormCPShopeeMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if(this._chromeDriver != null)
            //{
            //    try
            //    {
            //        this._chromeDriver.Close();
            //    }
            //    catch(Exception exp)
            //    {
            //    }
            //}
        }

        private String buildStatusTool(String content)
        {
            return "Trạng thái: " + content;
        }

        private ShopInfoModule loadShopInfo(String shopName)
        {
            ShopInfoModule shopInfoModule = new ShopInfoModule();

            try
            {
                this.toolStatusMain.Text = buildStatusTool("Đang tải thông tin shop");
                //IWebElement elementCollection = this._chromeDriver.FindElementByClassName("shop-page__info");
                String data = httpGetRequest("https://shopee.vn/api/v2/shop/get?username=" + shopName, null);
                var values = JsonConvert.DeserializeObject<Dictionary<string, Object>>(data);

                if (values == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin shop, xin hãy kiểm tra lại đường dẫn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.toolStatusMain.Text = buildStatusTool("Không tìm thấy thông tin shop");
                    return null;
                }
                String errorMessage =  values["error_msg"] == null ? null : Convert.ToString(values["error_msg"]);

                if(errorMessage != null)
                {
                    MessageBox.Show("Lối thực hiện: " + errorMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.toolStatusMain.Text = buildStatusTool("Lỗi thực hiện tải thông tin shop");
                    return null;
                }

                var dataJson = (JObject)values["data"];

                if (dataJson == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin shop, xin hãy kiểm tra lại đường dẫn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.toolStatusMain.Text = buildStatusTool("Không tìm thấy thông tin shop");
                    return null;
                }
                String product = "Sản phẩm: " + Convert.ToString(dataJson["item_count"]);
                String prepareTime = "Thời gian chuẩn bị hàng: nhanh";
                String follow = "Đang theo dõi: " + Convert.ToString(((dataJson["account"]))["following_count"]);
                String replyPercent = "Tỷ lệ phản hồi chat: " +  Convert.ToString(dataJson["response_rate"]) + "%";
                String peopleFollow = "Người theo dõi: " + Convert.ToString(dataJson["follower_count"])  ;
                String ratting = "Đánh giá: " +  Convert.ToString(dataJson["rating_star"] + "(" + Convert.ToString(dataJson["rating_good"] + " Đánh giá)"));
                String startTime = "Mã cửa hàng: " + Convert.ToString(dataJson["shopid"]);

                shopInfoModule.shopId = Convert.ToString(dataJson["shopid"]);
                shopInfoModule.product = product;
                shopInfoModule.prepareTime = prepareTime;
                shopInfoModule.follow = follow;
                shopInfoModule.replyPercent = replyPercent;
                shopInfoModule.peopleFollow = peopleFollow;
                shopInfoModule.ratting = ratting;
                shopInfoModule.startTime = startTime;

                this.lbProductInfo.Text = product;
                this.lbPrepareTime.Text = prepareTime;
                this.lbFollow.Text = follow;
                this.lbReplyTime.Text = replyPercent;
                this.lbPeopleFollow.Text = peopleFollow;
                this.lbRatting.Text = ratting;
                this.lbShopId.Text = startTime;
                this.toolStatusMain.Text = buildStatusTool("Tải thông tin shop thành công");
            }
            catch (Exception exp)
            {
                MessageBox.Show("Lối thực hiện: " + exp.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.toolStatusMain.Text = buildStatusTool("Lỗi thực hiện tải thông tin shop");
            }
            return shopInfoModule;
        }

        private void loadShopProduct(String shopId, String shopName)
        {
            try
            {
                this.toolStatusMain.Text = buildStatusTool("Đang tải thông tin sản phẩm");
                String data = null;

                if (isTheFirstLoadProduct)
                {
                    data = httpGetRequest("https://shopee.vn/api/v2/search_items/?by=pop&limit=30&match_id=" + shopId + "&newest=0&order=desc&page_type=shop", shopName);
                }
                else
                {
                    int number = (Convert.ToInt32(this.cbbPage.Text) - 1) * 30;
                    data = httpGetRequest("https://shopee.vn/api/v2/search_items/?by=pop&limit=30&match_id=" + shopId + "&newest=" + number + "&order=desc&page_type=shop", shopName);
                }

                if (data == null || "".Equals(data))
                {
                    MessageBox.Show("Không tìm thấy thông tin sản phẩm, xin hãy kiểm tra lại đường dẫn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.toolStatusMain.Text = buildStatusTool("Không tìm thấy thông tin sản phẩm");
                    return;
                }
                var values = JsonConvert.DeserializeObject<Dictionary<string, Object>>(data);
                if (values == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin sản phẩm, xin hãy kiểm tra lại đường dẫn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.toolStatusMain.Text = buildStatusTool("Không tìm thấy thông tin sản phẩm");
                    return;
                }

                String errorMessage = values["error"] == null ? null : Convert.ToString(values["error"]);

                if (errorMessage != null)
                {
                    MessageBox.Show("Lối thực hiện: " + errorMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.toolStatusMain.Text = buildStatusTool("Lỗi thực hiện tải thông tin sản phẩm");
                    return;
                }

                if (this.isTheFirstLoadProduct)
                {
                    int totalCount = Convert.ToInt32(values["total_count"]);
                    int page = totalCount / 30 + 1;

                    this.cbbPage.Items.Clear();
                    for (int indexPage = 0; indexPage < page; indexPage++)
                    {
                        this.cbbPage.Items.Add(indexPage + 1);
                    }
                    this.cbbPage.SelectedIndex = 0;
                }
                currentPage = Convert.ToInt32(this.cbbPage.SelectedItem);
                JArray items = (JArray)values["items"];
                int productWith = this.panelBody.Width / 4 - 10;
                int productHeight = 200;
                int i = 0;
                int j = 0;
                CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
                this.panelBody.Controls.Clear();
                if(this.mlsListImages == null)
                {
                    this.mlsListImages = new List<string>();
                }
                else
                {
                    mlsListImages.Clear();
                }
                for (int index = 0; index < items.Count; index++)
                {
                    var item = items[index];
                    String urlImage = "https://cf.shopee.vn/file/" + item["image"] + "_tn";
                    Panel panel = new Panel();

                    panel.Name = "Product_" + index;
                    panel.Width = productWith;
                    panel.Height = productHeight;
                    panel.Left = i *( productWith + 5) + 5;
                    panel.Top = j * (productHeight + 5) + 5;
                    panel.Cursor = Cursors.Hand;
                    panel.BackColor = this.panelLeft.BackColor;
                    PictureBox pic = new PictureBox();
                    pic.Name = "pic_" + index;
                    pic.LoadAsync(urlImage);
                    pic.Dock = DockStyle.Top;
                    pic.Height = 150;
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    panel.Controls.Add(pic);

                    Label lb = new Label();

                    lb.Name = "lb_" + index;
                    lb.Left = 0;
                    lb.Top = 152;
                    lb.AutoSize = true;
                    this.mlsListImages.Add(urlImage);
                    String price =Convert.ToString(item["price"]);
                    if (price.Equals(""))
                    {
                        lb.Text = Convert.ToString(item["name"]) + "\r\n đ " + price;
                    }
                    else
                    {
                        price = price.Substring(0, price.Length - 5);
                        lb.Text = Convert.ToString(item["name"]) + "\r\n đ " + String.Format(cul.NumberFormat, "{0:c}", price);
                    }
                    panel.Controls.Add(lb);
                    this.panelBody.Controls.Add(panel);
                    i++;
                    if (i > 3)
                    {
                        i = 0;
                        j++;
                    }
                }
                this.toolStatusMain.Text = buildStatusTool("Tải thông tin sản phẩm thành công");
            }
            catch (Exception exp)
            {
                MessageBox.Show("Lối thực hiện: " + exp.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.toolStatusMain.Text = buildStatusTool("Lỗi thực hiện tải thông tin sản phẩm");
            }
        }

        private void toolStripBtnReload_Click(object sender, EventArgs e)
        {
            try
            {
                this.toolStatusMain.Text = buildStatusTool("Đang đợi nhập đường dẫn shop");
                this.toolStripLabelShopName.Text = this.toolStripLabelShopName.Text;
                this.toolStatusMain.Text = buildStatusTool("Đang tải thông tin về shop " + this.toolStripLabelShopName.Text);
                //this._chromeDriver.Url = formShopUrl.shopUrl;
                //this._chromeDriver.Navigate();
                this.toolStatusMain.Text = buildStatusTool("Truy cập shop thành công");
                ShopInfoModule shopInfoModule = loadShopInfo(this.toolStripLabelShopName.Text);

                if (shopInfoModule != null)
                {
                    loadShopProduct(shopInfoModule.shopId, this.toolStripLabelShopName.Text);
                }
                this.toolStatusMain.Text = buildStatusTool("Hiện tại có " + this.panelBody.Controls.Count + " sản phẩm");
            }
            catch (Exception exp)
            {
                MessageBox.Show("Lối thực hiện: " + exp.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.toolStatusMain.Text = buildStatusTool("Lỗi thực hiện tải thông tin shop");
            }
        }

        private void cbbPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Convert.ToInt32(this.cbbPage.SelectedItem) == this.currentPage)
            {
                return;
            }
            loadShopProduct(this.lbShopId.Text.Split(':')[1].Trim(), this.toolStripLabelShopName.Text);
        }

        private void toolStripDownloadImage_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult dialogResult = folderBrowserDialog.ShowDialog();
            String selectPath = folderBrowserDialog.SelectedPath;

            if(dialogResult == DialogResult.Cancel)
            {
                return;
            }
            if(selectPath == null || "".Equals(selectPath))
            {
                MessageBox.Show("Thư mục không tồn tại, xin hãy chọn lại.","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            try
            {
                if(this.mlsListImages == null)
                {
                    MessageBox.Show("Không tìm thấy ảnh, xin hãy chọn lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                WebClient webClient = new WebClient();
                int i = 0;
                foreach (String image in this.mlsListImages)
                {
                    webClient.DownloadFile(new Uri(image), selectPath +  "/image_" + i + ".png");
                    i++;
                }
                MessageBox.Show("Tải ảnh hoàn tất, xin hãy kiểm tra thư mục: " + selectPath, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception exp)
            {
                MessageBox.Show("Thực hiện lỗi, xin hãy thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
