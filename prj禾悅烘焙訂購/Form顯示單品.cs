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
    public partial class Form顯示單品 : Form
    {
        public Form顯示單品()
        {
            InitializeComponent();
        }

        string myDBConnectionString = "";
        string image_dir = @"image\";
        string image_name = "";

        public static string itemName;
        public static int itemNumber = 0;
        public static int count = 0; //讓首頁每次點開資訊會同步更新
        public static int singletotal = 0;  //讓首頁每次點開資訊會同步更新

        private void Form顯示單品_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "myHW";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();

            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from Products where Pname = @SearchName ;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchName", itemName);
            SqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                txt產品名稱.Text = reader["Pname"].ToString();
                txt產品價格.Text = reader["Price"].ToString();
                txt商品描述.Text = reader["Pdesc"].ToString();
                image_name = reader["Pimage"].ToString();
                picProduct.BackgroundImage = Image.FromFile(image_dir + image_name);
            }
            reader.Close();
            con.Close();
            txtCount.Text = count.ToString();  //讓首頁每次點開資訊會同步更新
            txtSingleTotal.Text = singletotal.ToString();  //讓首頁每次點開資訊會同步更新
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(itemNumber == 1)
            {
                product.p1Count++;
                txtCount.Text = product.p1Count.ToString();
                int price = Convert.ToInt32(txt產品價格.Text);
                int singleTotal = price * product.p1Count;
                product.p1TotalAmount = singleTotal;
                txtSingleTotal.Text = singleTotal.ToString();
                //MessageBox.Show($"{product.p1TotalAmount}"); //檢查用
            }
            else if (itemNumber == 2)
            {
                product.p2Count++;
                txtCount.Text = product.p2Count.ToString();
                int price = Convert.ToInt32(txt產品價格.Text);
                int singleTotal = price * product.p2Count;
                product.p2TotalAmount = singleTotal;
                txtSingleTotal.Text = singleTotal.ToString();
            }
            else if (itemNumber == 3)
            {
                product.p3Count++;
                txtCount.Text = product.p3Count.ToString();
                int price = Convert.ToInt32(txt產品價格.Text);
                int singleTotal = price * product.p3Count;
                product.p3TotalAmount = singleTotal;
                txtSingleTotal.Text = singleTotal.ToString();
            }
            else if (itemNumber == 4)
            {
                product.p4Count++;
                txtCount.Text = product.p4Count.ToString();
                int price = Convert.ToInt32(txt產品價格.Text);
                int singleTotal = price * product.p4Count;
                product.p4TotalAmount = singleTotal;
                txtSingleTotal.Text = singleTotal.ToString();
            }
            else if (itemNumber == 5)
            {
                product.p5Count++;
                txtCount.Text = product.p5Count.ToString();
                int price = Convert.ToInt32(txt產品價格.Text);
                int singleTotal = price * product.p5Count;
                product.p5TotalAmount = singleTotal;
                txtSingleTotal.Text = singleTotal.ToString();
            }
            else if (itemNumber == 6)
            {
                product.p6Count++;
                txtCount.Text = product.p6Count.ToString();
                int price = Convert.ToInt32(txt產品價格.Text);
                int singleTotal = price * product.p6Count;
                product.p6TotalAmount = singleTotal;
                txtSingleTotal.Text = singleTotal.ToString();
            }
            else if (itemNumber == 8)
            {
                product.p8Count++;
                txtCount.Text = product.p8Count.ToString();
                int price = Convert.ToInt32(txt產品價格.Text);
                int singleTotal = price * product.p8Count;
                product.p8TotalAmount = singleTotal;
                txtSingleTotal.Text = singleTotal.ToString();
            }
            else if (itemNumber == 9)
            {
                product.p9Count++;
                txtCount.Text = product.p9Count.ToString();
                int price = Convert.ToInt32(txt產品價格.Text);
                int singleTotal = price * product.p9Count;
                product.p9TotalAmount = singleTotal;
                txtSingleTotal.Text = singleTotal.ToString();
            }
        }

        private void btnReduce_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(txtCount.Text);
            
            if (count < 2)
            {
                MessageBox.Show("商品數量不能小於1");
            }
            else
            {
                if (itemNumber == 1)
                {
                    product.p1Count--;
                    txtCount.Text = product.p1Count.ToString();
                    int price = Convert.ToInt32(txt產品價格.Text);
                    int singleTotal = price * product.p1Count;
                    product.p1TotalAmount = singleTotal;
                    txtSingleTotal.Text = singleTotal.ToString();
                }
                else if (itemNumber == 2)
                {
                    product.p2Count--;
                    txtCount.Text = product.p2Count.ToString();
                    int price = Convert.ToInt32(txt產品價格.Text);
                    int singleTotal = price * product.p2Count;
                    product.p2TotalAmount = singleTotal;
                    txtSingleTotal.Text = singleTotal.ToString();
                }
                else if (itemNumber == 3)
                {
                    product.p3Count--;
                    txtCount.Text = product.p3Count.ToString();
                    int price = Convert.ToInt32(txt產品價格.Text);
                    int singleTotal = price * product.p3Count;
                    product.p3TotalAmount = singleTotal;
                    txtSingleTotal.Text = singleTotal.ToString();
                }
                else if (itemNumber == 4)
                {
                    product.p4Count--;
                    txtCount.Text = product.p4Count.ToString();
                    int price = Convert.ToInt32(txt產品價格.Text);
                    int singleTotal = price * product.p4Count;
                    product.p4TotalAmount = singleTotal;
                    txtSingleTotal.Text = singleTotal.ToString();
                }
                else if (itemNumber == 5)
                {
                    product.p5Count--;
                    txtCount.Text = product.p5Count.ToString();
                    int price = Convert.ToInt32(txt產品價格.Text);
                    int singleTotal = price * product.p5Count;
                    product.p5TotalAmount = singleTotal;
                    txtSingleTotal.Text = singleTotal.ToString();
                }
                else if (itemNumber == 6)
                {
                    product.p6Count--;
                    txtCount.Text = product.p6Count.ToString();
                    int price = Convert.ToInt32(txt產品價格.Text);
                    int singleTotal = price * product.p6Count;
                    product.p6TotalAmount = singleTotal;
                    txtSingleTotal.Text = singleTotal.ToString();
                }
                else if (itemNumber == 8)
                {
                    product.p8Count--;
                    txtCount.Text = product.p8Count.ToString();
                    int price = Convert.ToInt32(txt產品價格.Text);
                    int singleTotal = price * product.p8Count;
                    product.p8TotalAmount = singleTotal;
                    txtSingleTotal.Text = singleTotal.ToString();
                }
                else if (itemNumber == 9)
                {
                    product.p9Count--;
                    txtCount.Text = product.p9Count.ToString();
                    int price = Convert.ToInt32(txt產品價格.Text);
                    int singleTotal = price * product.p9Count;
                    product.p9TotalAmount = singleTotal;
                    txtSingleTotal.Text = singleTotal.ToString();
                }
            }
        }

        //private void btnDelect_Click(object sender, EventArgs e)
        //{
        //    if (itemNumber == 1)
        //    {
        //        product.p1Count = 0;
        //        txtCount.Text = product.p1Count.ToString();
        //        int price = Convert.ToInt32(txt產品價格.Text);
        //        int singleTotal = price * product.p1Count;
        //        product.p1TotalAmount = singleTotal;
        //        txtSingleTotal.Text = singleTotal.ToString();
        //        prj首頁.Carcount = product.p1Count + product.p2Count + product.p3Count + product.p4Count + product.p5Count + product.p6Count + product.p8Count + product.p9Count;
        //        this.Close();
        //    }
        //    else if (itemNumber == 2)
        //    {
        //        product.p2Count++;
        //        txtCount.Text = product.p2Count.ToString();
        //        int price = Convert.ToInt32(txt產品價格.Text);
        //        int singleTotal = price * product.p2Count;
        //        product.p2TotalAmount = singleTotal;
        //        txtSingleTotal.Text = singleTotal.ToString();
        //        prj首頁.Carcount = product.p1Count + product.p2Count + product.p3Count + product.p4Count + product.p5Count + product.p6Count + product.p8Count + product.p9Count;

        //    }
        //    else if (itemNumber == 3)
        //    {
        //        product.p3Count++;
        //        txtCount.Text = product.p3Count.ToString();
        //        int price = Convert.ToInt32(txt產品價格.Text);
        //        int singleTotal = price * product.p3Count;
        //        product.p3TotalAmount = singleTotal;
        //        txtSingleTotal.Text = singleTotal.ToString();
        //        prj首頁.Carcount = product.p1Count + product.p2Count + product.p3Count + product.p4Count + product.p5Count + product.p6Count + product.p8Count + product.p9Count;

        //    }
        //    else if (itemNumber == 4)
        //    {
        //        product.p4Count++;
        //        txtCount.Text = product.p4Count.ToString();
        //        int price = Convert.ToInt32(txt產品價格.Text);
        //        int singleTotal = price * product.p4Count;
        //        product.p4TotalAmount = singleTotal;
        //        txtSingleTotal.Text = singleTotal.ToString();
        //        prj首頁.Carcount = product.p1Count + product.p2Count + product.p3Count + product.p4Count + product.p5Count + product.p6Count + product.p8Count + product.p9Count;

        //    }
        //    else if (itemNumber == 5)
        //    {
        //        product.p5Count++;
        //        txtCount.Text = product.p5Count.ToString();
        //        int price = Convert.ToInt32(txt產品價格.Text);
        //        int singleTotal = price * product.p5Count;
        //        product.p5TotalAmount = singleTotal;
        //        txtSingleTotal.Text = singleTotal.ToString();
        //        prj首頁.Carcount = product.p1Count + product.p2Count + product.p3Count + product.p4Count + product.p5Count + product.p6Count + product.p8Count + product.p9Count;

        //    }
        //    else if (itemNumber == 6)
        //    {
        //        product.p6Count++;
        //        txtCount.Text = product.p6Count.ToString();
        //        int price = Convert.ToInt32(txt產品價格.Text);
        //        int singleTotal = price * product.p6Count;
        //        product.p6TotalAmount = singleTotal;
        //        txtSingleTotal.Text = singleTotal.ToString();
        //        prj首頁.Carcount = product.p1Count + product.p2Count + product.p3Count + product.p4Count + product.p5Count + product.p6Count + product.p8Count + product.p9Count;

        //    }
        //    else if (itemNumber == 8)
        //    {
        //        product.p8Count++;
        //        txtCount.Text = product.p8Count.ToString();
        //        int price = Convert.ToInt32(txt產品價格.Text);
        //        int singleTotal = price * product.p8Count;
        //        product.p8TotalAmount = singleTotal;
        //        txtSingleTotal.Text = singleTotal.ToString();
        //        prj首頁.Carcount = product.p1Count + product.p2Count + product.p3Count + product.p4Count + product.p5Count + product.p6Count + product.p8Count + product.p9Count;

        //    }
        //    else if (itemNumber == 9)
        //    {
        //        product.p9Count++;
        //        txtCount.Text = product.p9Count.ToString();
        //        int price = Convert.ToInt32(txt產品價格.Text);
        //        int singleTotal = price * product.p9Count;
        //        product.p9TotalAmount = singleTotal;
        //        txtSingleTotal.Text = singleTotal.ToString();
        //        prj首頁.Carcount = product.p1Count + product.p2Count + product.p3Count + product.p4Count + product.p5Count + product.p6Count + product.p8Count + product.p9Count;

        //    }
        //}

        private void btnRevise_Click(object sender, EventArgs e)
        {
            try
            {
            if((user.IsMember  == 1) && (itemNumber == 1))
            {
                    SqlConnection con = new SqlConnection(myDBConnectionString);
                    con.Open();
                    string strSQL = "insert into ShoppingCar(CustomerID,ProductID,數量,金額,單價) values(@CustomerID,@ProductID,@數量,@金額,@單價); ";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@CustomerID", user.customerID);
                    cmd.Parameters.AddWithValue("@ProductID", itemNumber);
                    cmd.Parameters.AddWithValue("@數量", product.p1Count);
                    cmd.Parameters.AddWithValue("@金額", product.p1TotalAmount);
                    cmd.Parameters.AddWithValue("@單價", Convert.ToInt32(txt產品價格.Text));


                    int rows = cmd.ExecuteNonQuery();//只執行不查詢，只會回傳影響的資料筆數
                    con.Close();

                    MessageBox.Show($"成功加入購物車，{rows} 個資料列受到影響");

                    prj首頁.Carcount = prj首頁.Carcount + product.p1Count;
                    //formShoppingCar.totalMoney = formShoppingCar.totalMoney + product.p1TotalAmount;
                    this.Close();
                }
            else if((user.IsMember == 1) && (itemNumber == 2))
                {
                    SqlConnection con = new SqlConnection(myDBConnectionString);
                    con.Open();
                    string strSQL = "insert into ShoppingCar(CustomerID,ProductID,數量,金額,單價) values(@CustomerID,@ProductID,@數量,@金額,@單價); ";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@CustomerID", user.customerID);
                    cmd.Parameters.AddWithValue("@ProductID", itemNumber);
                    cmd.Parameters.AddWithValue("@數量", product.p2Count);
                    cmd.Parameters.AddWithValue("@金額", product.p2TotalAmount);
                    cmd.Parameters.AddWithValue("@單價", Convert.ToInt32(txt產品價格.Text));

                    int rows = cmd.ExecuteNonQuery();//只執行不查詢，只會回傳影響的資料筆數
                    con.Close();

                    MessageBox.Show($"成功加入購物車，{rows} 個資料列受到影響");

                    prj首頁.Carcount = prj首頁.Carcount + product.p2Count;
                    //formShoppingCar.totalMoney = formShoppingCar.totalMoney + product.p2TotalAmount;
                    this.Close();
                }
                else if ((user.IsMember == 1) && (itemNumber == 3))
                {
                    SqlConnection con = new SqlConnection(myDBConnectionString);
                    con.Open();
                    string strSQL = "insert into ShoppingCar(CustomerID,ProductID,數量,金額,單價) values(@CustomerID,@ProductID,@數量,@金額,@單價); ";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@CustomerID", user.customerID);
                    cmd.Parameters.AddWithValue("@ProductID", itemNumber);
                    cmd.Parameters.AddWithValue("@數量", product.p3Count);
                    cmd.Parameters.AddWithValue("@金額", product.p3TotalAmount);
                    cmd.Parameters.AddWithValue("@單價", Convert.ToInt32(txt產品價格.Text));

                    int rows = cmd.ExecuteNonQuery();//只執行不查詢，只會回傳影響的資料筆數
                    con.Close();

                    MessageBox.Show($"成功加入購物車，{rows} 個資料列受到影響");

                    prj首頁.Carcount = prj首頁.Carcount + product.p3Count;
                    //formShoppingCar.totalMoney = formShoppingCar.totalMoney + product.p3TotalAmount;
                    this.Close();
                }
                else if ((user.IsMember == 1) && (itemNumber == 4))
                {
                    SqlConnection con = new SqlConnection(myDBConnectionString);
                    con.Open();
                    string strSQL = "insert into ShoppingCar(CustomerID,ProductID,數量,金額,單價) values(@CustomerID,@ProductID,@數量,@金額,@單價); ";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@CustomerID", user.customerID);
                    cmd.Parameters.AddWithValue("@ProductID", itemNumber);
                    cmd.Parameters.AddWithValue("@數量", product.p4Count);
                    cmd.Parameters.AddWithValue("@金額", product.p4TotalAmount);
                    cmd.Parameters.AddWithValue("@單價", Convert.ToInt32(txt產品價格.Text));

                    int rows = cmd.ExecuteNonQuery();//只執行不查詢，只會回傳影響的資料筆數
                    con.Close();

                    MessageBox.Show($"成功加入購物車，{rows} 個資料列受到影響");

                    prj首頁.Carcount = prj首頁.Carcount + product.p4Count;
                    //formShoppingCar.totalMoney = formShoppingCar.totalMoney + product.p4TotalAmount;
                    this.Close();
                }
                else if ((user.IsMember == 1) && (itemNumber == 5))
                {
                    SqlConnection con = new SqlConnection(myDBConnectionString);
                    con.Open();
                    string strSQL = "insert into ShoppingCar(CustomerID,ProductID,數量,金額,單價) values(@CustomerID,@ProductID,@數量,@金額,@單價); ";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@CustomerID", user.customerID);
                    cmd.Parameters.AddWithValue("@ProductID", itemNumber);
                    cmd.Parameters.AddWithValue("@數量", product.p5Count);
                    cmd.Parameters.AddWithValue("@金額", product.p5TotalAmount);
                    cmd.Parameters.AddWithValue("@單價", Convert.ToInt32(txt產品價格.Text));

                    int rows = cmd.ExecuteNonQuery();//只執行不查詢，只會回傳影響的資料筆數
                    con.Close();

                    MessageBox.Show($"成功加入購物車，{rows} 個資料列受到影響");

                    prj首頁.Carcount = prj首頁.Carcount + product.p5Count;
                    //formShoppingCar.totalMoney = formShoppingCar.totalMoney + product.p5TotalAmount;
                    this.Close();
                }
                else if ((user.IsMember == 1) && (itemNumber == 6))
                {
                    SqlConnection con = new SqlConnection(myDBConnectionString);
                    con.Open();
                    string strSQL = "insert into ShoppingCar(CustomerID,ProductID,數量,金額,單價) values(@CustomerID,@ProductID,@數量,@金額,@單價); ";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@CustomerID", user.customerID);
                    cmd.Parameters.AddWithValue("@ProductID", itemNumber);
                    cmd.Parameters.AddWithValue("@數量", product.p6Count);
                    cmd.Parameters.AddWithValue("@金額", product.p6TotalAmount);
                    cmd.Parameters.AddWithValue("@單價", Convert.ToInt32(txt產品價格.Text));

                    int rows = cmd.ExecuteNonQuery();//只執行不查詢，只會回傳影響的資料筆數
                    con.Close();

                    MessageBox.Show($"成功加入購物車，{rows} 個資料列受到影響");

                    prj首頁.Carcount = prj首頁.Carcount + product.p6Count;
                    //formShoppingCar.totalMoney = formShoppingCar.totalMoney + product.p6TotalAmount;
                    this.Close();
                }
                else if ((user.IsMember == 1) && (itemNumber == 8))
                {
                    SqlConnection con = new SqlConnection(myDBConnectionString);
                    con.Open();
                    string strSQL = "insert into ShoppingCar(CustomerID,ProductID,數量,金額,單價) values(@CustomerID,@ProductID,@數量,@金額,@單價); ";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@CustomerID", user.customerID);
                    cmd.Parameters.AddWithValue("@ProductID", itemNumber);
                    cmd.Parameters.AddWithValue("@數量", product.p8Count);
                    cmd.Parameters.AddWithValue("@金額", product.p8TotalAmount);
                    cmd.Parameters.AddWithValue("@單價", Convert.ToInt32(txt產品價格.Text));

                    int rows = cmd.ExecuteNonQuery();//只執行不查詢，只會回傳影響的資料筆數
                    con.Close();

                    MessageBox.Show($"成功加入購物車，{rows} 個資料列受到影響");

                    prj首頁.Carcount = prj首頁.Carcount + product.p8Count;
                    //formShoppingCar.totalMoney = formShoppingCar.totalMoney + product.p8TotalAmount;
                    this.Close();
                }
                else if ((user.IsMember == 1) && (itemNumber == 9))
                {
                    SqlConnection con = new SqlConnection(myDBConnectionString);
                    con.Open();
                    string strSQL = "insert into ShoppingCar(CustomerID,ProductID,數量,金額,單價) values(@CustomerID,@ProductID,@數量,@金額,@單價); ";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@CustomerID", user.customerID);
                    cmd.Parameters.AddWithValue("@ProductID", itemNumber);
                    cmd.Parameters.AddWithValue("@數量", product.p9Count);
                    cmd.Parameters.AddWithValue("@金額", product.p9TotalAmount);
                    cmd.Parameters.AddWithValue("@單價", Convert.ToInt32(txt產品價格.Text));

                    int rows = cmd.ExecuteNonQuery();//只執行不查詢，只會回傳影響的資料筆數
                    con.Close();

                    MessageBox.Show($"成功加入購物車，{rows} 個資料列受到影響");

                    prj首頁.Carcount = prj首頁.Carcount + product.p9Count;
                    //formShoppingCar.totalMoney = formShoppingCar.totalMoney + product.p9TotalAmount;
                    this.Close();
                }
                else
                        {
                product.p1Count = 0;
                product.p1TotalAmount = 0;
                product.p2Count = 0;
                product.p2TotalAmount = 0;
                product.p3Count = 0;
                product.p3TotalAmount = 0;
                product.p4Count = 0;
                product.p4TotalAmount = 0;
                product.p5Count = 0;
                product.p5TotalAmount = 0;
                product.p6Count = 0;
                product.p6TotalAmount = 0;
                product.p8Count = 0;
                product.p8TotalAmount = 0;
                product.p9Count = 0;
                product.p9TotalAmount = 0;
                MessageBox.Show("請登入會員。");
            }
            }
            catch
            {
                MessageBox.Show("此商品購物車已經有囉~");
            }

        }

        private void txtCount_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtCount.Text != "")
            {
                int count = Convert.ToInt32(txtCount.Text);

                if (count <= 0)
                {
                    MessageBox.Show("商品數量不能小於0");
                }
                else
                {
                    if (itemNumber == 1)
                    {
                        product.p1Count = count;
                        txtCount.Text = product.p1Count.ToString();
                        int price = Convert.ToInt32(txt產品價格.Text);
                        int singleTotal = price * product.p1Count;
                        product.p1TotalAmount = singleTotal;
                        txtSingleTotal.Text = singleTotal.ToString();
                    }
                    else if (itemNumber == 2)
                    {
                        product.p2Count--;
                        txtCount.Text = product.p2Count.ToString();
                        int price = Convert.ToInt32(txt產品價格.Text);
                        int singleTotal = price * product.p2Count;
                        product.p2TotalAmount = singleTotal;
                        txtSingleTotal.Text = singleTotal.ToString();
                    }
                    else if (itemNumber == 3)
                    {
                        product.p3Count--;
                        txtCount.Text = product.p3Count.ToString();
                        int price = Convert.ToInt32(txt產品價格.Text);
                        int singleTotal = price * product.p3Count;
                        product.p3TotalAmount = singleTotal;
                        txtSingleTotal.Text = singleTotal.ToString();
                    }
                    else if (itemNumber == 4)
                    {
                        product.p4Count--;
                        txtCount.Text = product.p4Count.ToString();
                        int price = Convert.ToInt32(txt產品價格.Text);
                        int singleTotal = price * product.p4Count;
                        product.p4TotalAmount = singleTotal;
                        txtSingleTotal.Text = singleTotal.ToString();
                    }
                    else if (itemNumber == 5)
                    {
                        product.p5Count--;
                        txtCount.Text = product.p5Count.ToString();
                        int price = Convert.ToInt32(txt產品價格.Text);
                        int singleTotal = price * product.p5Count;
                        product.p5TotalAmount = singleTotal;
                        txtSingleTotal.Text = singleTotal.ToString();
                    }
                    else if (itemNumber == 6)
                    {
                        product.p6Count--;
                        txtCount.Text = product.p6Count.ToString();
                        int price = Convert.ToInt32(txt產品價格.Text);
                        int singleTotal = price * product.p6Count;
                        product.p6TotalAmount = singleTotal;
                        txtSingleTotal.Text = singleTotal.ToString();
                    }
                    else if (itemNumber == 8)
                    {
                        product.p8Count--;
                        txtCount.Text = product.p8Count.ToString();
                        int price = Convert.ToInt32(txt產品價格.Text);
                        int singleTotal = price * product.p8Count;
                        product.p8TotalAmount = singleTotal;
                        txtSingleTotal.Text = singleTotal.ToString();
                    }
                    else if (itemNumber == 9)
                    {
                        product.p9Count--;
                        txtCount.Text = product.p9Count.ToString();
                        int price = Convert.ToInt32(txt產品價格.Text);
                        int singleTotal = price * product.p9Count;
                        product.p9TotalAmount = singleTotal;
                        txtSingleTotal.Text = singleTotal.ToString();
                    }
                }
            }

        }
    }
}
