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
    public partial class formSearchOrder : Form
    {
        public formSearchOrder()
        {
            InitializeComponent();
        }
        string myDBConnectionString = "";

        List<int> listOrderID = new List<int>();
        List<string> listName = new List<string>();
        List<int> listPrice = new List<int>();
        List<int> listCount = new List<int>();
        List<int> listSingleTotal = new List<int>();
        List<int> listTotalAmount = new List<int>();
        List<string> list收件人 = new List<string>();
        List<string> list電話 = new List<string>();
        List<string> listEmail = new List<string>();
        List<string> list地址 = new List<string>();
        List<string> listNote = new List<string>();
        List<string> listTime = new List<string>();

        private void formSearchOrder_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "myHW";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();

            讀取資料庫();
            listView列表模式();

        }

        void 讀取資料庫()   //用在form load
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select Orders.OrderID as 訂單編號,Products.Pname as 商品名稱,數量,單價,金額,總金額 as 訂單總金額,收件人,電話,Email,地址,Orderdate as 訂購時間,備註 from(OrderDetailTest INNER JOIN Products ON OrderDetailTest.ProductID = Products.ProductID) inner join Orders on OrderDetailTest.OrderID = Orders.OrderID where Orders.CustomerID = 5 and Orders.OrderID = (select top 1 Orders.OrderID from Orders where Orders.CustomerID = @SearchCustomerID order by OrderID desc) order by Orders.OrderID desc;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchCustomerID", user.customerID);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                listOrderID.Add(Convert.ToInt32(reader["訂單編號"]));
                listName.Add(Convert.ToString(reader["商品名稱"]));
                listPrice.Add(Convert.ToInt32(reader["單價"]));
                listCount.Add(Convert.ToInt32(reader["數量"]));
                listSingleTotal.Add(Convert.ToInt32(reader["金額"]));
                listTotalAmount.Add(Convert.ToInt32(reader["訂單總金額"]));
                list收件人.Add(Convert.ToString(reader["收件人"]));
                list電話.Add(Convert.ToString(reader["電話"]));
                listEmail.Add(Convert.ToString(reader["Email"]));
                list地址.Add(Convert.ToString(reader["地址"]));
                listNote.Add(Convert.ToString(reader["備註"]));
                listTime.Add(Convert.ToString(reader["訂購時間"]));
            }
            reader.Close();
            con.Close();
        }

        void listView列表模式()
        {
            listView商品展示.LargeImageList = null;
            listView商品展示.SmallImageList = null;
            listView商品展示.View = View.Details;
            listView商品展示.Columns.Add("訂單編號", 100);
            listView商品展示.Columns.Add("商品名稱", 250);
            listView商品展示.Columns.Add("單價", 100);
            listView商品展示.Columns.Add("數量", 100);
            listView商品展示.Columns.Add("金額", 150);
            listView商品展示.Columns.Add("訂單總金額", 150);
            listView商品展示.Columns.Add("收件人", 100);
            listView商品展示.Columns.Add("電話", 200);
            listView商品展示.Columns.Add("Email", 200);
            listView商品展示.Columns.Add("地址", 200);
            listView商品展示.Columns.Add("備註", 200);
            listView商品展示.Columns.Add("訂購時間", 250);
            listView商品展示.FullRowSelect = true;
            listView商品展示.GridLines = true;

            for (int i = 0; i < listOrderID.Count; i += 1)
            {
                ListViewItem item = new ListViewItem();
                item.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                item.Text = listOrderID[i].ToString();
                item.SubItems.Add(listName[i].ToString());
                item.SubItems.Add(listPrice[i].ToString());
                item.SubItems.Add(listCount[i].ToString());
                item.SubItems.Add(listSingleTotal[i].ToString());
                item.SubItems.Add(listTotalAmount[i].ToString());
                item.SubItems.Add(list收件人[i].ToString());
                item.SubItems.Add(list電話[i].ToString());
                item.SubItems.Add(listEmail[i].ToString());
                item.SubItems.Add(list地址[i].ToString());
                item.SubItems.Add(listNote[i].ToString());
                item.SubItems.Add(listTime[i].ToString());
                item.Tag = listOrderID[i];
                listView商品展示.Items.Add(item);
            }
        }

    }
}
