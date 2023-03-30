
namespace QuanLyShopPV
{
    partial class fCTDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCTIDBill = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtIDProducts = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtCTQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtCTMoney = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvCTBill = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTBill)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(481, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi Tiết Hóa Đơn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(109, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(947, 168);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCTIDBill);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(25, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 44);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã đơn hàng:";
            // 
            // txtCTIDBill
            // 
            this.txtCTIDBill.Location = new System.Drawing.Point(113, 7);
            this.txtCTIDBill.Name = "txtCTIDBill";
            this.txtCTIDBill.Size = new System.Drawing.Size(235, 22);
            this.txtCTIDBill.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtIDProducts);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(25, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 44);
            this.panel2.TabIndex = 2;
            // 
            // txtIDProducts
            // 
            this.txtIDProducts.Location = new System.Drawing.Point(113, 7);
            this.txtIDProducts.Name = "txtIDProducts";
            this.txtIDProducts.Size = new System.Drawing.Size(235, 22);
            this.txtIDProducts.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã sản phẩm:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtCTQuantity);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(553, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(351, 44);
            this.panel3.TabIndex = 2;
            // 
            // txtCTQuantity
            // 
            this.txtCTQuantity.Location = new System.Drawing.Point(113, 7);
            this.txtCTQuantity.Name = "txtCTQuantity";
            this.txtCTQuantity.Size = new System.Drawing.Size(235, 22);
            this.txtCTQuantity.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số lượng:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtCTMoney);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(553, 90);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(351, 44);
            this.panel4.TabIndex = 2;
            // 
            // txtCTMoney
            // 
            this.txtCTMoney.Location = new System.Drawing.Point(113, 7);
            this.txtCTMoney.Name = "txtCTMoney";
            this.txtCTMoney.Size = new System.Drawing.Size(235, 22);
            this.txtCTMoney.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Đơn giá:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvCTBill);
            this.groupBox2.Location = new System.Drawing.Point(109, 346);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(947, 371);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi Tiết Đơn Hàng";
            // 
            // dgvCTBill
            // 
            this.dgvCTBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTBill.Location = new System.Drawing.Point(7, 22);
            this.dgvCTBill.Name = "dgvCTBill";
            this.dgvCTBill.RowHeadersWidth = 51;
            this.dgvCTBill.RowTemplate.Height = 24;
            this.dgvCTBill.Size = new System.Drawing.Size(934, 343);
            this.dgvCTBill.TabIndex = 0;
            this.dgvCTBill.DoubleClick += new System.EventHandler(this.dgvCTBill_DoubleClick);
            // 
            // fCTDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 742);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "fCTDetails";
            this.Text = "fCTDetails";
            this.Load += new System.EventHandler(this.fCTDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtCTMoney;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtCTQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtIDProducts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCTIDBill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvCTBill;
    }
}