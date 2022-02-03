
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.create = new System.Windows.Forms.Button();
            this.OrderNo = new System.Windows.Forms.TextBox();
            this.OrderDesc = new System.Windows.Forms.TextBox();
            this.OrderDate = new System.Windows.Forms.TextBox();
            this.OrderQuantity = new System.Windows.Forms.TextBox();
            this.OrderCreationDate = new System.Windows.Forms.TextBox();
            this.CreatedBy = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Order Desc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Order Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Order Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(520, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Order Creation Date";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(704, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "CreatedBy";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(316, 300);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(75, 23);
            this.create.TabIndex = 6;
            this.create.Text = "create";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.button1_Click);
            // 
            // OrderNo
            // 
            this.OrderNo.Location = new System.Drawing.Point(40, 108);
            this.OrderNo.Name = "OrderNo";
            this.OrderNo.Size = new System.Drawing.Size(43, 22);
            this.OrderNo.TabIndex = 7;
            // 
            // OrderDesc
            // 
            this.OrderDesc.Location = new System.Drawing.Point(145, 107);
            this.OrderDesc.Name = "OrderDesc";
            this.OrderDesc.Size = new System.Drawing.Size(52, 22);
            this.OrderDesc.TabIndex = 8;
            // 
            // OrderDate
            // 
            this.OrderDate.Location = new System.Drawing.Point(257, 107);
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.Size = new System.Drawing.Size(52, 22);
            this.OrderDate.TabIndex = 9;
            // 
            // OrderQuantity
            // 
            this.OrderQuantity.Location = new System.Drawing.Point(392, 107);
            this.OrderQuantity.Name = "OrderQuantity";
            this.OrderQuantity.Size = new System.Drawing.Size(58, 22);
            this.OrderQuantity.TabIndex = 10;
            // 
            // OrderCreationDate
            // 
            this.OrderCreationDate.Location = new System.Drawing.Point(568, 108);
            this.OrderCreationDate.Name = "OrderCreationDate";
            this.OrderCreationDate.Size = new System.Drawing.Size(43, 22);
            this.OrderCreationDate.TabIndex = 11;
            // 
            // CreatedBy
            // 
            this.CreatedBy.Location = new System.Drawing.Point(707, 108);
            this.CreatedBy.Name = "CreatedBy";
            this.CreatedBy.Size = new System.Drawing.Size(43, 22);
            this.CreatedBy.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CreatedBy);
            this.Controls.Add(this.OrderCreationDate);
            this.Controls.Add(this.OrderQuantity);
            this.Controls.Add(this.OrderDate);
            this.Controls.Add(this.OrderDesc);
            this.Controls.Add(this.OrderNo);
            this.Controls.Add(this.create);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.TextBox OrderNo;
        private System.Windows.Forms.TextBox OrderDesc;
        private System.Windows.Forms.TextBox OrderDate;
        private System.Windows.Forms.TextBox OrderQuantity;
        private System.Windows.Forms.TextBox OrderCreationDate;
        private System.Windows.Forms.TextBox CreatedBy;
    }
}

