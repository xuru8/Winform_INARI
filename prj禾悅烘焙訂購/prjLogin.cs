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
    public partial class prjLogin : Form    /*-------------負責登入的form，並在成功登入後將CustomerID跟判定會員的bit傳入Orders裡面-------------*/
    {
        public prjLogin()                               /*-------------判定登入成功方法，要從Customers裡面抓帳號跟密碼的欄位資料出來比對，有一樣就成功登入-------------*/
        {
            InitializeComponent();
        }

        string myDBConnectionString = "";

        private void prjLogin_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "myHW";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool flagshow = false;  //讓這個判斷該使用者是否存在的布林變數當區域變數就好，這樣才可以每次都檢查。
            if ((txtAccount.Text != "") && (txtPassword.Text != ""))
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "select Email,密碼 from Customers; ";//參數式的代入
                SqlCommand cmd = new SqlCommand(strSQL, con);
                SqlDataReader reader = cmd.ExecuteReader(); //又讀又查

                while (reader.Read())//從資料庫讀取使用者資訊
                {
                    user.email = reader["Email"].ToString();
                    user.pwd = reader["密碼"].ToString();
                    //MessageBox.Show($"{user.email}"); //檢查有沒有吃到資料庫資料
                    //MessageBox.Show($"{user.pwd}"); //檢查有沒有吃到資料庫資料
                    if ((user.email.Trim() == txtAccount.Text) && (user.pwd.Trim() == txtPassword.Text))//不區分大小寫，且是否存在該使用者
                    {
                        flagshow = true;
                    }
                }
                reader.Close(); //查詢關閉

                if (flagshow == true)//判斷該使用者是否存在，存在進入下一介面
                {
                    SqlCommand cmd2 = new SqlCommand("select CustomerID,Name,Phone,住址 from Customers where Email=@SearchEmail", con);
                    cmd2.Parameters.AddWithValue("@SearchEmail", user.email);
                    SqlDataReader reader1 = cmd2.ExecuteReader();
                    while (reader1.Read())
                    {
                        //MessageBox.Show($"{reader1["CustomerID"]}");  //測試用
                        user.customerID = Convert.ToInt32(reader1["CustomerID"]);
                        user.IsMember = 1;
                        user.name = reader1["Name"].ToString();
                        user.phone = reader1["Phone"].ToString();
                        user.address = reader1["住址"].ToString();
                    }




                    reader1.Close();

                    SqlCommand cmd3 = new SqlCommand("select sum(數量) from ShoppingCar where CustomerID=@SearchCustomerID", con);
                    cmd3.Parameters.AddWithValue("@SearchCustomerID", user.customerID);
                    SqlDataReader reader2 = cmd3.ExecuteReader();
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

                    //SqlCommand cmd4 = new SqlCommand("select sum(金額)as 總金額 from ShoppingCar where CustomerID=@SearchCustomerID", con);
                    //cmd4.Parameters.AddWithValue("@SearchCustomerID", user.customerID);
                    //SqlDataReader reader3 = cmd4.ExecuteReader();
                    //while (reader3.Read())
                    //{
                    //    try
                    //    {
                    //        formShoppingCar.totalMoney = Convert.ToInt32(reader3[0]); //登入時，帶入購物車table的總金額
                    //    }
                    //    catch
                    //    {
                    //        formShoppingCar.totalMoney = 0;
                    //    }
                    //}
                    //reader3.Close();
                    con.Close(); //連線關閉

                    //MessageBox.Show($"{user.customerID}"); //測試用
                    prj首頁.show = $"{user.email}您好，歡迎光臨~";
                    this.Hide();//隱藏當前登入介面
                    
                }
                else
                {
                    MessageBox.Show("帳號不存在或密碼輸入錯誤！");
                    return;
                }

            }
            else
            {
                MessageBox.Show("請輸入帳號密碼");
            }
        }

        void clearSHOW()
        {
            txtAccount.Clear();
            txtPassword.Clear();
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            prfRegister prfRegister = new prfRegister();
            prfRegister.ShowDialog();
        }

        private void btnResetpassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("已寄送密碼重設郵件至您的信箱");
        }

    }
}
