using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj禾悅烘焙訂購
{
    public partial class prj首頁 : Form    /*-------------總介面的form，產品圖片點擊跳出產品簡介的form，點擊加入購物車新增產品到對應產品到OrderDetail-------------*/
    {
        public prj首頁()                       /*-------------form load時新增orderID，並讓產品新增進OrderDetail時指定是這個OrderID-------------*/
        {
            InitializeComponent();
        }
        //SqlConnectionStringBuilder scsb;  //SQL連線字串建立器，新增資料來源的新增資料庫連線字串。
        string myDBConnectionString = "";

        int count = 0;  //圖片
        public static int Carcount = 0; //購物車數量
        public static string show = "您好，歡迎光臨~";  //用static讓登入時可以輸入使用者名稱並重新載入lbl顯示



        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if (count ==3)
            {
                groupShow.BackgroundImage = Resource1.grouppic;
            }
            else if (count==6)
            {
                groupShow.BackgroundImage = Resource1.grouppic2;
            }
            else if (count == 9)
            {
                groupShow.BackgroundImage = Resource1.grouppic3;
            }
            else if (count == 12)
            {
                groupShow.BackgroundImage = Resource1.grouppic5;
                count = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "myHW";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();

            timer1.Start();
            groupShow.BackgroundImage = Resource1.start;
        }

        private void picBoxLOGO_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            count = 0;
            timer1.Start();
            groupShow.BackgroundImage = Resource1.start;
        }

        private void btnDessert_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            groupShow.BackgroundImage = null;   
            panel2.Visible = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            prfRegister prfRegister = new prfRegister();
            prfRegister.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblLogin.Visible = false; //先關掉lbl顯示。
            lblCount.Visible = false;
            prjLogin prjLogin = new prjLogin();
            prjLogin.ShowDialog();
            lblLogin.Text = show;  //在Login登入成功後，利用static變數，讓lbl更新值。
            lblLogin.Visible = true; //並開啟顯示，一個重新載入的概念。
            lblCount.Text = Carcount.ToString();
            lblCount.Visible = true;
        }

        private void btnAddCar義式芒果奶酪_Click(object sender, EventArgs e) 
        {
            Form顯示單品.itemName = lbl義式芒果奶酪.Text;
            Form顯示單品.itemNumber = 1;
            Form顯示單品.count = product.p1Count;
            Form顯示單品.singletotal = product.p1TotalAmount;
            Form顯示單品 formShow = new Form顯示單品();
            formShow.ShowDialog();

            lblCount.Text = Convert.ToString(Carcount);
        }

        private void btnAddCar焦糖雞蛋布丁_Click(object sender, EventArgs e)
        {
            Form顯示單品.itemName = lbl焦糖雞蛋布丁.Text;
            Form顯示單品.itemNumber = 2;

            Form顯示單品.count = product.p2Count;
            Form顯示單品.singletotal = product.p2TotalAmount;

            Form顯示單品 formShow = new Form顯示單品();
            formShow.ShowDialog();

            lblCount.Text = Convert.ToString(Carcount);
        }

        private void btnAddCar酥皮奶醬蛋塔_Click(object sender, EventArgs e)
        {
            Form顯示單品.itemName = lbl酥皮奶醬蛋塔.Text;
            Form顯示單品.itemNumber = 3;

            Form顯示單品.count = product.p3Count;
            Form顯示單品.singletotal = product.p3TotalAmount;

            Form顯示單品 formShow = new Form顯示單品();
            formShow.ShowDialog();

            lblCount.Text = Convert.ToString(Carcount);
        }

        private void btnAddCar香草脆皮泡芙_Click(object sender, EventArgs e)
        {
            Form顯示單品.itemName = lbl香草脆皮泡芙.Text;
            Form顯示單品.itemNumber = 4;

            Form顯示單品.count = product.p4Count;
            Form顯示單品.singletotal = product.p4TotalAmount;

            Form顯示單品 formShow = new Form顯示單品();
            formShow.ShowDialog();

            lblCount.Text = Convert.ToString(Carcount);
        }

        private void btnAddCar抹茶脆皮泡芙_Click(object sender, EventArgs e)
        {
            Form顯示單品.itemName = lbl宇治抹茶脆皮泡芙.Text;
            Form顯示單品.itemNumber = 5;

            Form顯示單品.count = product.p5Count;
            Form顯示單品.singletotal = product.p5TotalAmount;

            Form顯示單品 formShow = new Form顯示單品();
            formShow.ShowDialog();

            lblCount.Text = Convert.ToString(Carcount);
        }

        private void btnAddCar巧克力脆皮泡芙_Click(object sender, EventArgs e)
        {
            Form顯示單品.itemName = lbl巧克力脆皮泡芙.Text;
            Form顯示單品.itemNumber = 6;

            Form顯示單品.count = product.p6Count;
            Form顯示單品.singletotal = product.p6TotalAmount;

            Form顯示單品 formShow = new Form顯示單品();
            formShow.ShowDialog();

            lblCount.Text = Convert.ToString(Carcount);
        }

        private void btnAddCar香草閃電泡芙_Click(object sender, EventArgs e)
        {
            Form顯示單品.itemName = lbl香草閃電泡芙.Text;
            Form顯示單品.itemNumber = 8;

            Form顯示單品.count = product.p8Count;
            Form顯示單品.singletotal = product.p8TotalAmount;

            Form顯示單品 formShow = new Form顯示單品();
            formShow.ShowDialog();

            lblCount.Text = Convert.ToString(Carcount);
        }

        private void btnAddCar香草脆皮閃電泡芙_Click(object sender, EventArgs e)
        {
            Form顯示單品.itemName = lbl香草脆皮閃電泡芙.Text;
            Form顯示單品.itemNumber = 9;

            Form顯示單品.count = product.p9Count;
            Form顯示單品.singletotal = product.p9TotalAmount;

            Form顯示單品 formShow = new Form顯示單品();
            formShow.ShowDialog();

            lblCount.Text = Convert.ToString(Carcount);
        }

        private void btnShoppingCar_Click(object sender, EventArgs e)
        {
            if(user.IsMember ==1)
            {
            lblCount.Visible = false;
            formShoppingCar shoppingCar = new formShoppingCar();
            shoppingCar.ShowDialog();
            lblCount.Text = Carcount.ToString();
            lblCount.Visible = true;
            }
            else
            {
                MessageBox.Show("請登入會員後再開啟");
            }
        }

        private void btnSearchOrder_Click(object sender, EventArgs e)
        {
            if (user.IsMember == 1)
            {
                formSearchOrder searchOrder = new formSearchOrder();
                searchOrder.ShowDialog();
            }
            else
            {
                MessageBox.Show("請登入會員後再開啟");
            }

        }
    }
}
