
namespace prj禾悅烘焙訂購
{
    partial class Form顯示單品
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
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.txt商品描述 = new System.Windows.Forms.TextBox();
            this.txt產品價格 = new System.Windows.Forms.TextBox();
            this.txt產品名稱 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReduce = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRevise = new System.Windows.Forms.Button();
            this.txtSingleTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // picProduct
            // 
            this.picProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picProduct.Location = new System.Drawing.Point(12, 12);
            this.picProduct.Name = "picProduct";
            this.picProduct.Size = new System.Drawing.Size(249, 230);
            this.picProduct.TabIndex = 0;
            this.picProduct.TabStop = false;
            // 
            // txt商品描述
            // 
            this.txt商品描述.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt商品描述.Location = new System.Drawing.Point(388, 105);
            this.txt商品描述.Margin = new System.Windows.Forms.Padding(2);
            this.txt商品描述.Multiline = true;
            this.txt商品描述.Name = "txt商品描述";
            this.txt商品描述.ReadOnly = true;
            this.txt商品描述.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt商品描述.Size = new System.Drawing.Size(228, 177);
            this.txt商品描述.TabIndex = 14;
            // 
            // txt產品價格
            // 
            this.txt產品價格.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt產品價格.Location = new System.Drawing.Point(388, 57);
            this.txt產品價格.Margin = new System.Windows.Forms.Padding(2);
            this.txt產品價格.Name = "txt產品價格";
            this.txt產品價格.ReadOnly = true;
            this.txt產品價格.Size = new System.Drawing.Size(228, 36);
            this.txt產品價格.TabIndex = 13;
            // 
            // txt產品名稱
            // 
            this.txt產品名稱.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt產品名稱.Location = new System.Drawing.Point(388, 12);
            this.txt產品名稱.Margin = new System.Windows.Forms.Padding(2);
            this.txt產品名稱.Name = "txt產品名稱";
            this.txt產品名稱.ReadOnly = true;
            this.txt產品名稱.Size = new System.Drawing.Size(228, 36);
            this.txt產品名稱.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(281, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "商品價格";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(281, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "商品描述";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(281, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "商品名稱";
            // 
            // btnReduce
            // 
            this.btnReduce.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReduce.Location = new System.Drawing.Point(388, 303);
            this.btnReduce.Name = "btnReduce";
            this.btnReduce.Size = new System.Drawing.Size(26, 28);
            this.btnReduce.TabIndex = 36;
            this.btnReduce.Text = "-";
            this.btnReduce.UseVisualStyleBackColor = true;
            this.btnReduce.Click += new System.EventHandler(this.btnReduce_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(497, 302);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(26, 28);
            this.btnAdd.TabIndex = 35;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCount
            // 
            this.txtCount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCount.Location = new System.Drawing.Point(420, 302);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(71, 29);
            this.txtCount.TabIndex = 34;
            this.txtCount.Text = "0";
            this.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCount_KeyUp);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(281, 304);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 27);
            this.label10.TabIndex = 33;
            this.label10.Text = "商品數量";
            // 
            // btnRevise
            // 
            this.btnRevise.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRevise.Location = new System.Drawing.Point(233, 393);
            this.btnRevise.Name = "btnRevise";
            this.btnRevise.Size = new System.Drawing.Size(159, 42);
            this.btnRevise.TabIndex = 37;
            this.btnRevise.Text = "加入購物車";
            this.btnRevise.UseVisualStyleBackColor = true;
            this.btnRevise.Click += new System.EventHandler(this.btnRevise_Click);
            // 
            // txtSingleTotal
            // 
            this.txtSingleTotal.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSingleTotal.Location = new System.Drawing.Point(388, 343);
            this.txtSingleTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtSingleTotal.Name = "txtSingleTotal";
            this.txtSingleTotal.ReadOnly = true;
            this.txtSingleTotal.Size = new System.Drawing.Size(135, 36);
            this.txtSingleTotal.TabIndex = 39;
            this.txtSingleTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(281, 349);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 28);
            this.label1.TabIndex = 38;
            this.label1.Text = "金額";
            // 
            // Form顯示單品
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::prj禾悅烘焙訂購.Resource1.背景4;
            this.ClientSize = new System.Drawing.Size(639, 447);
            this.Controls.Add(this.txtSingleTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRevise);
            this.Controls.Add(this.btnReduce);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt商品描述);
            this.Controls.Add(this.txt產品價格);
            this.Controls.Add(this.txt產品名稱);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picProduct);
            this.Name = "Form顯示單品";
            this.Text = "Form顯示單品";
            this.Load += new System.EventHandler(this.Form顯示單品_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picProduct;
        private System.Windows.Forms.TextBox txt商品描述;
        private System.Windows.Forms.TextBox txt產品價格;
        private System.Windows.Forms.TextBox txt產品名稱;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReduce;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnRevise;
        private System.Windows.Forms.TextBox txtSingleTotal;
        private System.Windows.Forms.Label label1;
    }
}