
namespace prj禾悅烘焙訂購
{
    partial class formSearchOrder
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listView商品展示 = new System.Windows.Forms.ListView();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Khaki;
            this.groupBox4.BackgroundImage = global::prj禾悅烘焙訂購.Resource1.背景2;
            this.groupBox4.Controls.Add(this.listView商品展示);
            this.groupBox4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(928, 459);
            this.groupBox4.TabIndex = 34;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "訂單查詢";
            // 
            // listView商品展示
            // 
            this.listView商品展示.BackColor = System.Drawing.Color.White;
            this.listView商品展示.HideSelection = false;
            this.listView商品展示.Location = new System.Drawing.Point(9, 21);
            this.listView商品展示.Margin = new System.Windows.Forms.Padding(2);
            this.listView商品展示.Name = "listView商品展示";
            this.listView商品展示.Size = new System.Drawing.Size(910, 431);
            this.listView商品展示.TabIndex = 1;
            this.listView商品展示.UseCompatibleStateImageBehavior = false;
            // 
            // formSearchOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 514);
            this.Controls.Add(this.groupBox4);
            this.Name = "formSearchOrder";
            this.Text = "formSearchOrder";
            this.Load += new System.EventHandler(this.formSearchOrder_Load);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView listView商品展示;
    }
}