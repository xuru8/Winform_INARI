using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj禾悅烘焙訂購
{
    public struct user  //這邊的變數等到訂單結帳確認後，再一併匯進資料庫。(沒有結帳的話要存進購物車的table(之後再用))
    {
        //public static int orderID = 0;  //form load給個orderID，用static給其他form一起使用，才能抓到同一筆，最後訂單確認送出在進去資料庫。
        public static int customerID = 0;  //成功登入後，抓到ID值，以方便進到order table。
        public static int IsMember = 0;  //login成功後判定為1，以方便進到order table。
        public static string email;  //判定是否有註冊，有註冊則成功登入(email,pwd要相符合)
        public static string pwd;  //判定是否有註冊，有註冊則成功登入(email,pwd要相符合)

        public static string name;  //成功登入後，抓到值
        public static string phone;  //成功登入後，抓到值
        public static string address;  //成功登入後，抓到值
    }

    public struct visiter
    {
        public static string vName;
        public static string vPhone;
        public static string vEmail;
        public static string v地址;
    }

    public struct product
    {
        public static int p1Count = 0;
        public static int p1TotalAmount = 45 * p1Count;

        public static int p2Count = 0;
        public static int p2TotalAmount = 30 * p2Count;

        public static int p3Count = 0;
        public static int p3TotalAmount = 180 * p3Count;

        public static int p4Count = 0;
        public static int p4TotalAmount = 50 * p4Count;

        public static int p5Count = 0;
        public static int p5TotalAmount = 50 * p5Count;

        public static int p6Count = 0;
        public static int p6TotalAmount = 50 * p6Count;
        //public static int p7Count = 0;
        public static int p8Count = 0;
        public static int p8TotalAmount = 50 * p8Count;

        public static int p9Count = 0;
        public static int p9TotalAmount = 50 * p9Count;

        public static int totalPay = p1TotalAmount + p2TotalAmount + p3TotalAmount + p4TotalAmount + p5TotalAmount + p6TotalAmount + p8TotalAmount + p9TotalAmount;
    }
}
