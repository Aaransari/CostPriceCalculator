
namespace CostPriceCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_shareSold = new System.Windows.Forms.TextBox();
            this.txt_salePrice = new System.Windows.Forms.TextBox();
            this.txt_SaleDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_costPriceRemShare = new System.Windows.Forms.Label();
            this.lbl_remShare = new System.Windows.Forms.Label();
            this.lbl_profitLoss = new System.Windows.Forms.Label();
            this.lbl_costPriceShareSold = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Share Sold";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sale Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sale Date";
            // 
            // txt_shareSold
            // 
            this.txt_shareSold.Location = new System.Drawing.Point(137, 31);
            this.txt_shareSold.Name = "txt_shareSold";
            this.txt_shareSold.Size = new System.Drawing.Size(100, 23);
            this.txt_shareSold.TabIndex = 3;
            this.txt_shareSold.Text = "120";
            // 
            // txt_salePrice
            // 
            this.txt_salePrice.Location = new System.Drawing.Point(137, 77);
            this.txt_salePrice.Name = "txt_salePrice";
            this.txt_salePrice.Size = new System.Drawing.Size(100, 23);
            this.txt_salePrice.TabIndex = 4;
            this.txt_salePrice.Text = "10.5";
            // 
            // txt_SaleDate
            // 
            this.txt_SaleDate.Location = new System.Drawing.Point(137, 129);
            this.txt_SaleDate.Name = "txt_SaleDate";
            this.txt_SaleDate.Size = new System.Drawing.Size(200, 23);
            this.txt_SaleDate.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(363, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Costing Type";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(388, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cost Price Of Share Sold";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Profit / Loss";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Shares Remaining";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 410);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Cost Price Of Remaining Shares";
            // 
            // lbl_costPriceRemShare
            // 
            this.lbl_costPriceRemShare.AutoSize = true;
            this.lbl_costPriceRemShare.Location = new System.Drawing.Point(297, 410);
            this.lbl_costPriceRemShare.Name = "lbl_costPriceRemShare";
            this.lbl_costPriceRemShare.Size = new System.Drawing.Size(0, 15);
            this.lbl_costPriceRemShare.TabIndex = 15;
            // 
            // lbl_remShare
            // 
            this.lbl_remShare.AutoSize = true;
            this.lbl_remShare.Location = new System.Drawing.Point(293, 366);
            this.lbl_remShare.Name = "lbl_remShare";
            this.lbl_remShare.Size = new System.Drawing.Size(0, 15);
            this.lbl_remShare.TabIndex = 14;
            // 
            // lbl_profitLoss
            // 
            this.lbl_profitLoss.AutoSize = true;
            this.lbl_profitLoss.Location = new System.Drawing.Point(293, 317);
            this.lbl_profitLoss.Name = "lbl_profitLoss";
            this.lbl_profitLoss.Size = new System.Drawing.Size(0, 15);
            this.lbl_profitLoss.TabIndex = 13;
            // 
            // lbl_costPriceShareSold
            // 
            this.lbl_costPriceShareSold.AutoSize = true;
            this.lbl_costPriceShareSold.Location = new System.Drawing.Point(293, 274);
            this.lbl_costPriceShareSold.Name = "lbl_costPriceShareSold";
            this.lbl_costPriceShareSold.Size = new System.Drawing.Size(0, 15);
            this.lbl_costPriceShareSold.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(474, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 16;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbl_costPriceRemShare);
            this.Controls.Add(this.lbl_remShare);
            this.Controls.Add(this.lbl_profitLoss);
            this.Controls.Add(this.lbl_costPriceShareSold);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_SaleDate);
            this.Controls.Add(this.txt_salePrice);
            this.Controls.Add(this.txt_shareSold);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculate";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_shareSold;
        private System.Windows.Forms.TextBox txt_salePrice;
        private System.Windows.Forms.DateTimePicker txt_SaleDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_costPriceRemShare;
        private System.Windows.Forms.Label lbl_remShare;
        private System.Windows.Forms.Label lbl_profitLoss;
        private System.Windows.Forms.Label lbl_costPriceShareSold;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

