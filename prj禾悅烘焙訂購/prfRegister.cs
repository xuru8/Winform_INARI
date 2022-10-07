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
    public partial class prfRegister : Form   /*-------------負責新增Customers資料的form-------------*/
    {
        public prfRegister()
        {
            InitializeComponent();
        }

        string myDBConnectionString = "";
        
        private void prfRegister_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "myHW";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            { 
            if ((txtName.Text != "") && (txtPhone.Text != "") && (txtAddress.Text != "") && (txtEmail.Text != "") && (txtPassword.Text !=""))   //電話,Email(帳號)，設定unique，用Email當帳號就好。
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "insert into Customers values(@NewName,@NewPhone,@NewEmail,@NewBirth,@NewAddress,@NewPassword,@NewPoint); ";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewName", txtName.Text);
                cmd.Parameters.AddWithValue("@NewPhone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@NewBirth", dtpBirth.Value);
                cmd.Parameters.AddWithValue("@NewAddress", txtAddress.Text);
                cmd.Parameters.AddWithValue("@NewPassword", txtPassword.Text);
                cmd.Parameters.AddWithValue("@NewPoint", 0);




                    int rows = cmd.ExecuteNonQuery();//只執行不查詢，只會回傳影響的資料筆數
                con.Close();

                MessageBox.Show($"會員註冊成功，{rows} 個資料列受到影響");
                this.Close();
                }
            else
            {
                MessageBox.Show("請填妥每個資料");
            }
            }
            catch
            {
                MessageBox.Show("Email或電話已重複申請。");
            }
        }
    }
}
