namespace LunchOrderForm
{
    partial class lunchOrderFrm
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
            this.subtotalLbl = new System.Windows.Forms.Label();
            this.taxLbl = new System.Windows.Forms.Label();
            this.orderTotalLbl = new System.Windows.Forms.Label();
            this.subtotalResultLbl = new System.Windows.Forms.Label();
            this.taxResultLbl = new System.Windows.Forms.Label();
            this.orderTotalResultLbl = new System.Windows.Forms.Label();
            this.placeOrderBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.addOn1Cbx = new System.Windows.Forms.CheckBox();
            this.addOn2Cbx = new System.Windows.Forms.CheckBox();
            this.addOn3Cbx = new System.Windows.Forms.CheckBox();
            this.mainCourseGpb = new System.Windows.Forms.GroupBox();
            this.saladRdo = new System.Windows.Forms.RadioButton();
            this.pizzaRdo = new System.Windows.Forms.RadioButton();
            this.hamburgerRdo = new System.Windows.Forms.RadioButton();
            this.addOnItemsGpb = new System.Windows.Forms.GroupBox();
            this.orderTotalGpb = new System.Windows.Forms.GroupBox();
            this.mainCourseGpb.SuspendLayout();
            this.addOnItemsGpb.SuspendLayout();
            this.orderTotalGpb.SuspendLayout();
            this.SuspendLayout();
            // 
            // subtotalLbl
            // 
            this.subtotalLbl.AutoSize = true;
            this.subtotalLbl.Location = new System.Drawing.Point(45, 29);
            this.subtotalLbl.Name = "subtotalLbl";
            this.subtotalLbl.Size = new System.Drawing.Size(46, 13);
            this.subtotalLbl.TabIndex = 3;
            this.subtotalLbl.Text = "Subtotal";
            // 
            // taxLbl
            // 
            this.taxLbl.AutoSize = true;
            this.taxLbl.Location = new System.Drawing.Point(25, 62);
            this.taxLbl.Name = "taxLbl";
            this.taxLbl.Size = new System.Drawing.Size(66, 13);
            this.taxLbl.TabIndex = 4;
            this.taxLbl.Text = "Tax (7.75%):";
            // 
            // orderTotalLbl
            // 
            this.orderTotalLbl.AutoSize = true;
            this.orderTotalLbl.Location = new System.Drawing.Point(31, 100);
            this.orderTotalLbl.Name = "orderTotalLbl";
            this.orderTotalLbl.Size = new System.Drawing.Size(60, 13);
            this.orderTotalLbl.TabIndex = 5;
            this.orderTotalLbl.Text = "OrderTotal:";
            // 
            // subtotalResultLbl
            // 
            this.subtotalResultLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.subtotalResultLbl.Location = new System.Drawing.Point(100, 28);
            this.subtotalResultLbl.Name = "subtotalResultLbl";
            this.subtotalResultLbl.Size = new System.Drawing.Size(100, 23);
            this.subtotalResultLbl.TabIndex = 6;
            // 
            // taxResultLbl
            // 
            this.taxResultLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.taxResultLbl.Location = new System.Drawing.Point(100, 62);
            this.taxResultLbl.Name = "taxResultLbl";
            this.taxResultLbl.Size = new System.Drawing.Size(100, 23);
            this.taxResultLbl.TabIndex = 7;
            // 
            // orderTotalResultLbl
            // 
            this.orderTotalResultLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.orderTotalResultLbl.Location = new System.Drawing.Point(100, 99);
            this.orderTotalResultLbl.Name = "orderTotalResultLbl";
            this.orderTotalResultLbl.Size = new System.Drawing.Size(100, 23);
            this.orderTotalResultLbl.TabIndex = 8;
            // 
            // placeOrderBtn
            // 
            this.placeOrderBtn.Location = new System.Drawing.Point(288, 198);
            this.placeOrderBtn.Name = "placeOrderBtn";
            this.placeOrderBtn.Size = new System.Drawing.Size(98, 23);
            this.placeOrderBtn.TabIndex = 9;
            this.placeOrderBtn.Text = "Place Order";
            this.placeOrderBtn.UseVisualStyleBackColor = true;
            this.placeOrderBtn.Click += new System.EventHandler(this.PlaceOrderBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBtn.Location = new System.Drawing.Point(288, 274);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(98, 23);
            this.exitBtn.TabIndex = 10;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // addOn1Cbx
            // 
            this.addOn1Cbx.AutoSize = true;
            this.addOn1Cbx.Location = new System.Drawing.Point(6, 19);
            this.addOn1Cbx.Name = "addOn1Cbx";
            this.addOn1Cbx.Size = new System.Drawing.Size(158, 17);
            this.addOn1Cbx.TabIndex = 11;
            this.addOn1Cbx.Text = "Lettuce, tomato, and onions";
            this.addOn1Cbx.UseVisualStyleBackColor = true;
            this.addOn1Cbx.Click += new System.EventHandler(this.ClearTotals);
            // 
            // addOn2Cbx
            // 
            this.addOn2Cbx.AutoSize = true;
            this.addOn2Cbx.Location = new System.Drawing.Point(6, 54);
            this.addOn2Cbx.Name = "addOn2Cbx";
            this.addOn2Cbx.Size = new System.Drawing.Size(161, 17);
            this.addOn2Cbx.TabIndex = 12;
            this.addOn2Cbx.Text = "Ketchup, mustard, and mayo";
            this.addOn2Cbx.UseVisualStyleBackColor = true;
            this.addOn2Cbx.Click += new System.EventHandler(this.ClearTotals);
            // 
            // addOn3Cbx
            // 
            this.addOn3Cbx.AutoSize = true;
            this.addOn3Cbx.Location = new System.Drawing.Point(6, 86);
            this.addOn3Cbx.Name = "addOn3Cbx";
            this.addOn3Cbx.Size = new System.Drawing.Size(84, 17);
            this.addOn3Cbx.TabIndex = 13;
            this.addOn3Cbx.Text = "French Fries";
            this.addOn3Cbx.UseVisualStyleBackColor = true;
            this.addOn3Cbx.Click += new System.EventHandler(this.ClearTotals);
            // 
            // mainCourseGpb
            // 
            this.mainCourseGpb.Controls.Add(this.saladRdo);
            this.mainCourseGpb.Controls.Add(this.pizzaRdo);
            this.mainCourseGpb.Controls.Add(this.hamburgerRdo);
            this.mainCourseGpb.Location = new System.Drawing.Point(21, 21);
            this.mainCourseGpb.Name = "mainCourseGpb";
            this.mainCourseGpb.Size = new System.Drawing.Size(144, 125);
            this.mainCourseGpb.TabIndex = 14;
            this.mainCourseGpb.TabStop = false;
            this.mainCourseGpb.Text = "Main Course";
            // 
            // saladRdo
            // 
            this.saladRdo.AutoSize = true;
            this.saladRdo.Location = new System.Drawing.Point(6, 85);
            this.saladRdo.Name = "saladRdo";
            this.saladRdo.Size = new System.Drawing.Size(88, 17);
            this.saladRdo.TabIndex = 2;
            this.saladRdo.Text = "Salad - $4.95";
            this.saladRdo.UseVisualStyleBackColor = true;
            this.saladRdo.CheckedChanged += new System.EventHandler(this.SaladRdo_CheckedChanged);
            this.saladRdo.Click += new System.EventHandler(this.ClearTotals);
            // 
            // pizzaRdo
            // 
            this.pizzaRdo.AutoSize = true;
            this.pizzaRdo.Location = new System.Drawing.Point(6, 53);
            this.pizzaRdo.Name = "pizzaRdo";
            this.pizzaRdo.Size = new System.Drawing.Size(86, 17);
            this.pizzaRdo.TabIndex = 1;
            this.pizzaRdo.Text = "Pizza - $5.95";
            this.pizzaRdo.UseVisualStyleBackColor = true;
            this.pizzaRdo.CheckedChanged += new System.EventHandler(this.PizzaRdo_CheckedChanged);
            this.pizzaRdo.Click += new System.EventHandler(this.ClearTotals);
            // 
            // hamburgerRdo
            // 
            this.hamburgerRdo.AutoSize = true;
            this.hamburgerRdo.Checked = true;
            this.hamburgerRdo.Location = new System.Drawing.Point(6, 18);
            this.hamburgerRdo.Name = "hamburgerRdo";
            this.hamburgerRdo.Size = new System.Drawing.Size(113, 17);
            this.hamburgerRdo.TabIndex = 0;
            this.hamburgerRdo.TabStop = true;
            this.hamburgerRdo.Text = "Hamburger - $6.95";
            this.hamburgerRdo.UseVisualStyleBackColor = true;
            this.hamburgerRdo.CheckedChanged += new System.EventHandler(this.HamburgerRdo_CheckedChanged);
            this.hamburgerRdo.Click += new System.EventHandler(this.ClearTotals);
            // 
            // addOnItemsGpb
            // 
            this.addOnItemsGpb.Controls.Add(this.addOn2Cbx);
            this.addOnItemsGpb.Controls.Add(this.addOn1Cbx);
            this.addOnItemsGpb.Controls.Add(this.addOn3Cbx);
            this.addOnItemsGpb.Location = new System.Drawing.Point(218, 21);
            this.addOnItemsGpb.Name = "addOnItemsGpb";
            this.addOnItemsGpb.Size = new System.Drawing.Size(168, 125);
            this.addOnItemsGpb.TabIndex = 15;
            this.addOnItemsGpb.TabStop = false;
            this.addOnItemsGpb.Text = "Add-on items ($.75/each)";
            // 
            // orderTotalGpb
            // 
            this.orderTotalGpb.Controls.Add(this.taxLbl);
            this.orderTotalGpb.Controls.Add(this.subtotalLbl);
            this.orderTotalGpb.Controls.Add(this.orderTotalLbl);
            this.orderTotalGpb.Controls.Add(this.subtotalResultLbl);
            this.orderTotalGpb.Controls.Add(this.taxResultLbl);
            this.orderTotalGpb.Controls.Add(this.orderTotalResultLbl);
            this.orderTotalGpb.Location = new System.Drawing.Point(27, 179);
            this.orderTotalGpb.Name = "orderTotalGpb";
            this.orderTotalGpb.Size = new System.Drawing.Size(236, 147);
            this.orderTotalGpb.TabIndex = 16;
            this.orderTotalGpb.TabStop = false;
            this.orderTotalGpb.Text = "Order Total";
            // 
            // lunchOrderFrm
            // 
            this.AcceptButton = this.placeOrderBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(439, 338);
            this.Controls.Add(this.orderTotalGpb);
            this.Controls.Add(this.addOnItemsGpb);
            this.Controls.Add(this.mainCourseGpb);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.placeOrderBtn);
            this.Name = "lunchOrderFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lunch Order";
            this.mainCourseGpb.ResumeLayout(false);
            this.mainCourseGpb.PerformLayout();
            this.addOnItemsGpb.ResumeLayout(false);
            this.addOnItemsGpb.PerformLayout();
            this.orderTotalGpb.ResumeLayout(false);
            this.orderTotalGpb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label subtotalLbl;
        private System.Windows.Forms.Label taxLbl;
        private System.Windows.Forms.Label orderTotalLbl;
        private System.Windows.Forms.Label subtotalResultLbl;
        private System.Windows.Forms.Label taxResultLbl;
        private System.Windows.Forms.Label orderTotalResultLbl;
        private System.Windows.Forms.Button placeOrderBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.CheckBox addOn1Cbx;
        private System.Windows.Forms.CheckBox addOn2Cbx;
        private System.Windows.Forms.CheckBox addOn3Cbx;
        private System.Windows.Forms.GroupBox mainCourseGpb;
        private System.Windows.Forms.GroupBox addOnItemsGpb;
        private System.Windows.Forms.GroupBox orderTotalGpb;
        private System.Windows.Forms.RadioButton saladRdo;
        private System.Windows.Forms.RadioButton pizzaRdo;
        private System.Windows.Forms.RadioButton hamburgerRdo;
    }
}

