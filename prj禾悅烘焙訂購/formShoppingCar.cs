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
    public partial class formShoppingCar : Form    
    {
        /*-------------左邊如果有登入會員就自動帶Customers的相關資料，右邊用列表顯示OrderDetail的商品名稱,數量,金額-------------*/
        /*-------------右邊用列表顯示購物車table(會員,非會員)(if判斷user.IsMember)的商品名稱,數量,金額-------------*/
        public formShoppingCar()
        {
            InitializeComponent();
        }

        string myDBConnectionString = "";
        public static int totalMoney = 0; //總金額
        public int orderID = 0;

        string image_dir = @"image\";
        string image_name = "";

        public int customerID = 0;
        public int productNumber = 0;
        public int productCount = 0;
        public int productPrice = 0;
        public int productSingleTotal = 0;

        public string pid = "";
        List<string> listName = new List<string>();
        List<int> listPrice = new List<int>();
        List<int> listCount = new List<int>();
        List<int> listSingleTotal = new List<int>();
        List<int> listProductID = new List<int>();




        private void formShoppingCar_Load(object sender, EventArgs e)
        {
            //成功登入會員後，自動帶入資料。(右邊帶入會員購物車資料(先用表格的就好))，(好像可以把每個商品用panel包起來在像pos機那樣加入在表單裡?)
            //在load這邊把static資料帶入購物車資料庫。左邊用static帶資料(或是直接帶SQL?)，右邊的購物車資訊用SQL帶入
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "myHW";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();

            讀取資料庫();
            listView列表模式();

            if (user.IsMember ==1) 
            {
                txtName.Text = user.name;
                //txtName.ReadOnly = true;
                txtPhone.Text = user.phone;
                //txtPhone.ReadOnly = true;
                txtEmail.Text = user.email;
                //txtEmail.ReadOnly = true;
                txtAddress.Text = user.address;
                //txtAddress.ReadOnly = true;
            }
        }

        void 讀取資料庫()   //用在form load
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "SELECT ShoppingCar.ProductID,Products.Pname,Products.Price, ShoppingCar.數量 ,ShoppingCar.金額 FROM ShoppingCar INNER JOIN Products ON ShoppingCar.ProductID = Products.ProductID where ShoppingCar.CustomerID = @SearchCustomerID;"; 
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchCustomerID", user.customerID);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                listProductID.Add(Convert.ToInt32(reader["ProductID"]));
                listName.Add(Convert.ToString(reader["Pname"]));
                listPrice.Add(Convert.ToInt32(reader["Price"]));
                listCount.Add(Convert.ToInt32(reader["數量"]));
                listSingleTotal.Add(Convert.ToInt32(reader["金額"]));
            }
            reader.Close();

            SqlCommand cmd1 = new SqlCommand("select sum(金額)as 總金額 from ShoppingCar where CustomerID=@SearchCustomerID", con);
            cmd1.Parameters.AddWithValue("@SearchCustomerID", user.customerID);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                try
                {
                    formShoppingCar.totalMoney = Convert.ToInt32(reader1[0]); //帶入購物車table的總金額
                }
                catch
                {
                    formShoppingCar.totalMoney = 0;
                }
            }
            reader1.Close();
            lblTotal.Text = totalMoney.ToString();

            con.Close();
        }

        void listView列表模式()
        {
            listView商品展示.LargeImageList = null;
            listView商品展示.SmallImageList = null;
            listView商品展示.View = View.Details;
            listView商品展示.Columns.Add("商品名稱", 200);
            listView商品展示.Columns.Add("單價", 100);
            listView商品展示.Columns.Add("數量", 100);
            listView商品展示.Columns.Add("金額", 150);
            listView商品展示.FullRowSelect = true;
            listView商品展示.GridLines = true;

            for (int i = 0; i < listName.Count; i += 1)
            {
                ListViewItem item = new ListViewItem();
                item.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                item.Text = listName[i].ToString();
                item.SubItems.Add(listPrice[i].ToString());
                item.SubItems.Add(listCount[i].ToString());
                item.SubItems.Add(listSingleTotal[i].ToString());
                item.Tag = listName[i];

                listView商品展示.Items.Add(item);
            }
        }

        private void listView商品展示_ItemActivate(object sender, EventArgs e)
        {
            pid = Convert.ToString(listView商品展示.SelectedItems[0].Tag);

            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "SELECT ShoppingCar.CustomerID,ShoppingCar.ProductID,Products.Pname,Products.Pdesc,Products.Price, ShoppingCar.數量 ,ShoppingCar.金額,Products.Pimage FROM ShoppingCar INNER JOIN Products ON ShoppingCar.ProductID = Products.ProductID where ShoppingCar.CustomerID = @SearchCustomerID and Products.Pname=@SearchName;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchCustomerID", user.customerID);
            cmd.Parameters.AddWithValue("@SearchName", pid);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                customerID = Convert.ToInt32(reader["CustomerID"]);
                productNumber = Convert.ToInt32(reader["ProductID"]);
                txt產品名稱.Text = reader["Pname"].ToString();
                txt商品描述.Text = reader["Pdesc"].ToString();
                txt產品價格.Text = reader["Price"].ToString();
                productPrice = Convert.ToInt32(reader["Price"]);
                txtCount.Text = reader["數量"].ToString();
                productCount = Convert.ToInt32(reader["數量"]);
                txtSingleTotal.Text = reader["金額"].ToString();
                productSingleTotal = Convert.ToInt32(reader["金額"]);
                image_name = reader["Pimage"].ToString();
                picProduct.BackgroundImage = Image.FromFile(image_dir + image_name);
            }
            reader.Close();
            con.Close();

        }

        //void renewTotalAmount()
        //{
        //    SqlCommand cmd1 = new SqlCommand("select sum(金額)as 總金額 from ShoppingCar where CustomerID=@SearchCustomerID", con);
        //    cmd1.Parameters.AddWithValue("@SearchCustomerID", user.customerID);
        //    SqlDataReader reader1 = cmd1.ExecuteReader();
        //    while (reader1.Read())
        //    {
        //        try
        //        {
        //            formShoppingCar.totalMoney = Convert.ToInt32(reader1[0]); //帶入購物車table的總金額
        //        }
        //        catch
        //        {
        //            formShoppingCar.totalMoney = 0;
        //        }
        //    }
        //    reader1.Close();
        //}

        private void btnAdd_Click(object sender, EventArgs e)
        {
            productCount++;
            txtCount.Text = productCount.ToString();
            productSingleTotal = productPrice * productCount;
            txtSingleTotal.Text = productSingleTotal.ToString();
        }

        private void btnReduce_Click(object sender, EventArgs e)
        {
            if (productCount < 2)
            {
                MessageBox.Show("商品數量不能小於1");
            }
            else
            {
            productCount--;
            txtCount.Text = productCount.ToString();
            productSingleTotal = productPrice * productCount;
            txtSingleTotal.Text = productSingleTotal.ToString();
            }
        }


        private void txtCount_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtCount.Text != "")
            {
                productCount = Convert.ToInt32(txtCount.Text);

                if (productCount <= 0)
                {
                    MessageBox.Show("商品數量不能小於0");
                }
                else
                {
                    productSingleTotal = productPrice * productCount;
                    txtSingleTotal.Text = productSingleTotal.ToString();
                }
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "update ShoppingCar set 數量=@Search數量,金額=@Search金額  where CustomerID=@SearchCustomerID and ProductID=@SearchProductID; ";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@Search數量", productCount);
            cmd.Parameters.AddWithValue("@Search金額", productSingleTotal);
            cmd.Parameters.AddWithValue("@SearchCustomerID", customerID);
            cmd.Parameters.AddWithValue("@SearchProductID", productNumber);

            int rows = cmd.ExecuteNonQuery();//只執行不查詢，只會回傳影響的資料筆數

            SqlCommand cmd1 = new SqlCommand("select sum(金額)as 總金額 from ShoppingCar where CustomerID=@SearchCustomerID", con);
            cmd1.Parameters.AddWithValue("@SearchCustomerID", user.customerID);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                try
                {
                    formShoppingCar.totalMoney = Convert.ToInt32(reader1[0]); //帶入購物車table的總金額
                }
                catch
                {
                    formShoppingCar.totalMoney = 0;
                }
            }
            reader1.Close();

            SqlCommand cmd2 = new SqlCommand("select sum(數量) from ShoppingCar where CustomerID=@SearchCustomerID", con);
            cmd2.Parameters.AddWithValue("@SearchCustomerID", user.customerID);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                try
                {
                    prj首頁.Carcount = Convert.ToInt32(reader2[0]); //登入時，購物車數量帶入購物車table的數量
                }
                catch
                {
                    prj首頁.Carcount = 0;
                }
            }

            reader2.Close();
            con.Close();

            MessageBox.Show($"成功更改購物車，{rows} 個資料列受到影響");
            lblTotal.Text = totalMoney.ToString();
            listView商品展示.Clear();
            listName.Clear();
            listPrice.Clear();
            listCount.Clear();
            listSingleTotal.Clear();
            讀取資料庫();
            listView列表模式();
        }

        private void btnDelect_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "delete from ShoppingCar where CustomerID=@SearchCustomerID and ProductID=@SearchProductID;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchCustomerID", customerID);
            cmd.Parameters.AddWithValue("@SearchProductID", productNumber);
            int rows = cmd.ExecuteNonQuery();//只執行不查詢，只會回傳影響的資料筆數

            SqlCommand cmd1 = new SqlCommand("select sum(金額)as 總金額 from ShoppingCar where CustomerID=@SearchCustomerID", con);
            cmd1.Parameters.AddWithValue("@SearchCustomerID", user.customerID);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                try
                {
                    formShoppingCar.totalMoney = Convert.ToInt32(reader1[0]); //帶入購物車table的總金額
                }
                catch
                {
                    formShoppingCar.totalMoney = 0;
                }
            }
            reader1.Close();

            SqlCommand cmd2 = new SqlCommand("select sum(數量) from ShoppingCar where CustomerID=@SearchCustomerID", con);
            cmd2.Parameters.AddWithValue("@SearchCustomerID", user.customerID);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                try
                {
                    prj首頁.Carcount = Convert.ToInt32(reader2[0]); //帶入購物車table的數量
                }
                catch
                {
                    prj首頁.Carcount = 0;
                }
            }

            reader2.Close();
            con.Close();

            MessageBox.Show($"成功從購物車刪除此商品，{rows} 個資料列受到影響");
            lblTotal.Text = totalMoney.ToString();
            listView商品展示.Clear();
            listName.Clear();
            listPrice.Clear();
            listCount.Clear();
            listSingleTotal.Clear();
            讀取資料庫();
            listView列表模式();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if((MessageBox.Show($"確認付款，總金額{totalMoney}", "確認付款金額!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "insert into Orders(CustomerID,是否為會員,收件人,電話,Email,地址,Orderdate,總金額,備註,訂單是否成立) values(@SearchCustomerID,1,@SearchName,@SearchPhone,@SearchEmail,@Search地址,GETDATE(),@SearchTotalAmount,@SearchNote,1); ";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchCustomerID", user.customerID);
                cmd.Parameters.AddWithValue("@SearchName", txtName.Text);
                cmd.Parameters.AddWithValue("@SearchPhone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@SearchEmail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Search地址", txtAddress.Text);
                cmd.Parameters.AddWithValue("@SearchTotalAmount",totalMoney );
                cmd.Parameters.AddWithValue("@SearchNote", textNote.Text);

                int rows = cmd.ExecuteNonQuery();//只執行不查詢，只會回傳影響的資料筆數
                MessageBox.Show($"訂單成立，{rows} 個資料列受到影響");
                /*---------------------------------------------------------------------------------------------------------------------------*/
                SqlCommand cmd1 = new SqlCommand("select top 1 OrderID from Orders order by OrderID desc;", con);
                SqlDataReader reader1 = cmd1.ExecuteReader();
                while (reader1.Read())
                {
                    try
                    {
                        orderID = Convert.ToInt32(reader1[0]); //抓到新增的orderID
                    }
                    catch
                    {
                        MessageBox.Show("找不到orderID");
                    }
                }
                reader1.Close();
                
                /*---------------------------------------------------------------------------------------------------------------------------*/
                for(int i =0; i<listProductID.Count;i++)
                {
                    SqlCommand cmd2 = new SqlCommand("insert into OrderDetailTest(OrderID,ProductID,數量,金額,單價) values(@SearchOrderID,@SearchProductID,(select 數量 from ShoppingCar where CustomerID =@CustomerID and ProductID=@SearchProductID),(select 金額 from ShoppingCar where CustomerID =@CustomerID and ProductID=@SearchProductID),(select 單價 from ShoppingCar where CustomerID =@CustomerID and ProductID=@SearchProductID));", con);
                    cmd2.Parameters.AddWithValue("@SearchOrderID", orderID);
                    cmd2.Parameters.AddWithValue("@SearchProductID", listProductID[i]);
                    cmd2.Parameters.AddWithValue("@CustomerID", user.customerID);
                    int rows1 = cmd2.ExecuteNonQuery();//只執行不查詢，只會回傳影響的資料筆數
                    MessageBox.Show($"orderdetail新增成功，{rows1} 個資料列受到影響");
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("繼續參觀選購~");
            }
        }
    }
}
