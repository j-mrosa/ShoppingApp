
namespace ShoppingApp
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
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.cboNames = new System.Windows.Forms.ComboBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblStudent = new System.Windows.Forms.Label();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btn2ndCard = new System.Windows.Forms.Button();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpProducts = new System.Windows.Forms.GroupBox();
            this.btnCompare = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.nudNumber = new System.Windows.Forms.NumericUpDown();
            this.cboProducts = new System.Windows.Forms.ComboBox();
            this.grpCart = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstCart = new System.Windows.Forms.ListBox();
            this.grpLogin.SuspendLayout();
            this.grpCustomer.SuspendLayout();
            this.grpProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).BeginInit();
            this.grpCart.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLogin
            // 
            this.grpLogin.BackColor = System.Drawing.SystemColors.Info;
            this.grpLogin.Controls.Add(this.cboNames);
            this.grpLogin.Controls.Add(this.btnLogin);
            this.grpLogin.Controls.Add(this.lblStudent);
            this.grpLogin.Location = new System.Drawing.Point(45, 38);
            this.grpLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpLogin.Size = new System.Drawing.Size(419, 186);
            this.grpLogin.TabIndex = 0;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "Login";
            // 
            // cboNames
            // 
            this.cboNames.FormattingEnabled = true;
            this.cboNames.Location = new System.Drawing.Point(149, 47);
            this.cboNames.Name = "cboNames";
            this.cboNames.Size = new System.Drawing.Size(240, 33);
            this.cboNames.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Location = new System.Drawing.Point(100, 115);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(229, 49);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Location = new System.Drawing.Point(24, 47);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(103, 25);
            this.lblStudent.TabIndex = 0;
            this.lblStudent.Text = "Last name";
            // 
            // grpCustomer
            // 
            this.grpCustomer.Controls.Add(this.btnCheckOut);
            this.grpCustomer.Controls.Add(this.btn2ndCard);
            this.grpCustomer.Controls.Add(this.lblLastName);
            this.grpCustomer.Controls.Add(this.lblFirstName);
            this.grpCustomer.Controls.Add(this.lblID);
            this.grpCustomer.Controls.Add(this.label2);
            this.grpCustomer.Controls.Add(this.label1);
            this.grpCustomer.Location = new System.Drawing.Point(52, 257);
            this.grpCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpCustomer.Size = new System.Drawing.Size(412, 206);
            this.grpCustomer.TabIndex = 1;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Costumer";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckOut.Location = new System.Drawing.Point(235, 137);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(154, 49);
            this.btnCheckOut.TabIndex = 6;
            this.btnCheckOut.Text = "&Checkout";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btn2ndCard
            // 
            this.btn2ndCard.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn2ndCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2ndCard.Location = new System.Drawing.Point(27, 137);
            this.btn2ndCard.Name = "btn2ndCard";
            this.btn2ndCard.Size = new System.Drawing.Size(154, 49);
            this.btn2ndCard.TabIndex = 5;
            this.btn2ndCard.Text = "&2nd Card";
            this.btn2ndCard.UseVisualStyleBackColor = false;
            this.btn2ndCard.Click += new System.EventHandler(this.btn2ndCard_Click);
            // 
            // lblLastName
            // 
            this.lblLastName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLastName.Location = new System.Drawing.Point(258, 91);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(131, 31);
            this.lblLastName.TabIndex = 4;
            // 
            // lblFirstName
            // 
            this.lblFirstName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFirstName.Location = new System.Drawing.Point(107, 91);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(124, 31);
            this.lblFirstName.TabIndex = 3;
            // 
            // lblID
            // 
            this.lblID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblID.Location = new System.Drawing.Point(107, 50);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(102, 31);
            this.lblID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // grpProducts
            // 
            this.grpProducts.Controls.Add(this.btnCompare);
            this.grpProducts.Controls.Add(this.btnAddToCart);
            this.grpProducts.Controls.Add(this.nudNumber);
            this.grpProducts.Controls.Add(this.cboProducts);
            this.grpProducts.Location = new System.Drawing.Point(516, 38);
            this.grpProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpProducts.Name = "grpProducts";
            this.grpProducts.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpProducts.Size = new System.Drawing.Size(909, 186);
            this.grpProducts.TabIndex = 2;
            this.grpProducts.TabStop = false;
            this.grpProducts.Text = "Products";
            // 
            // btnCompare
            // 
            this.btnCompare.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCompare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompare.Location = new System.Drawing.Point(644, 117);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(171, 47);
            this.btnCompare.TabIndex = 3;
            this.btnCompare.Text = "Com&pare";
            this.btnCompare.UseVisualStyleBackColor = false;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddToCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToCart.Location = new System.Drawing.Point(727, 31);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(149, 68);
            this.btnAddToCart.TabIndex = 2;
            this.btnAddToCart.Text = "&Add To Cart";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // nudNumber
            // 
            this.nudNumber.Location = new System.Drawing.Point(583, 48);
            this.nudNumber.Name = "nudNumber";
            this.nudNumber.Size = new System.Drawing.Size(115, 30);
            this.nudNumber.TabIndex = 1;
            // 
            // cboProducts
            // 
            this.cboProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboProducts.FormattingEnabled = true;
            this.cboProducts.Location = new System.Drawing.Point(51, 36);
            this.cboProducts.Name = "cboProducts";
            this.cboProducts.Size = new System.Drawing.Size(472, 127);
            this.cboProducts.TabIndex = 0;
            // 
            // grpCart
            // 
            this.grpCart.Controls.Add(this.label8);
            this.grpCart.Controls.Add(this.label7);
            this.grpCart.Controls.Add(this.label6);
            this.grpCart.Controls.Add(this.label5);
            this.grpCart.Controls.Add(this.label4);
            this.grpCart.Controls.Add(this.lstCart);
            this.grpCart.Location = new System.Drawing.Point(504, 257);
            this.grpCart.Margin = new System.Windows.Forms.Padding(4);
            this.grpCart.Name = "grpCart";
            this.grpCart.Padding = new System.Windows.Forms.Padding(4);
            this.grpCart.Size = new System.Drawing.Size(921, 206);
            this.grpCart.TabIndex = 10;
            this.grpCart.TabStop = false;
            this.grpCart.Text = "Cart";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(811, 27);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(651, 27);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(511, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Code";
            // 
            // lstCart
            // 
            this.lstCart.Font = new System.Drawing.Font("Courier New", 12F);
            this.lstCart.FormattingEnabled = true;
            this.lstCart.ItemHeight = 22;
            this.lstCart.Location = new System.Drawing.Point(18, 56);
            this.lstCart.Margin = new System.Windows.Forms.Padding(4);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(1088, 158);
            this.lstCart.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1472, 509);
            this.Controls.Add(this.grpCart);
            this.Controls.Add(this.grpProducts);
            this.Controls.Add(this.grpCustomer);
            this.Controls.Add(this.grpLogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Shopping App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.grpProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).EndInit();
            this.grpCart.ResumeLayout(false);
            this.grpCart.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.ComboBox cboNames;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btn2ndCard;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpProducts;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.NumericUpDown nudNumber;
        private System.Windows.Forms.ComboBox cboProducts;
        private System.Windows.Forms.GroupBox grpCart;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstCart;
    }
}

