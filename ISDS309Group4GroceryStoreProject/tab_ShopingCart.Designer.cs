﻿namespace ISDS309Group4GroceryStoreProject
{
    partial class tab_ShopingCart
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
            label1 = new Label();
            button1 = new Button();
            listOfItemsInCart = new ListBox();
            listOfPricesinCart = new ListBox();
            listOfQuantInCart = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(547, 14);
            label1.Name = "label1";
            label1.Size = new Size(175, 28);
            label1.TabIndex = 2;
            label1.Text = "Shopping Cart";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(10, 9);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(151, 39);
            button1.TabIndex = 1;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listOfItemsInCart
            // 
            listOfItemsInCart.BackColor = SystemColors.AppWorkspace;
            listOfItemsInCart.FormattingEnabled = true;
            listOfItemsInCart.ItemHeight = 15;
            listOfItemsInCart.Location = new Point(219, 254);
            listOfItemsInCart.Name = "listOfItemsInCart";
            listOfItemsInCart.Size = new Size(198, 184);
            listOfItemsInCart.TabIndex = 4;
            listOfItemsInCart.SelectedIndexChanged += listOfItemsInCart_SelectedIndexChanged;
            // 
            // listOfPricesinCart
            // 
            listOfPricesinCart.BackColor = SystemColors.AppWorkspace;
            listOfPricesinCart.FormattingEnabled = true;
            listOfPricesinCart.ItemHeight = 15;
            listOfPricesinCart.Location = new Point(423, 254);
            listOfPricesinCart.Name = "listOfPricesinCart";
            listOfPricesinCart.Size = new Size(76, 184);
            listOfPricesinCart.TabIndex = 6;
            listOfPricesinCart.SelectedIndexChanged += listOfPricesinCart_SelectedIndexChanged;
            // 
            // listOfQuantInCart
            // 
            listOfQuantInCart.BackColor = SystemColors.AppWorkspace;
            listOfQuantInCart.FormattingEnabled = true;
            listOfQuantInCart.ItemHeight = 15;
            listOfQuantInCart.Location = new Point(505, 254);
            listOfQuantInCart.Name = "listOfQuantInCart";
            listOfQuantInCart.Size = new Size(76, 184);
            listOfQuantInCart.TabIndex = 7;
            listOfQuantInCart.SelectedIndexChanged += listOfQuantInCart_SelectedIndexChanged;
            // 
            // tab_ShopingCart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 653);
            Controls.Add(listOfQuantInCart);
            Controls.Add(listOfPricesinCart);
            Controls.Add(listOfItemsInCart);
            Controls.Add(button1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(1208, 692);
            MinimumSize = new Size(1208, 692);
            Name = "tab_ShopingCart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Shopping Cart";
            FormClosed += tab_ShopingCart_FormClosed;
            Load += tab_ShopingCart_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
        private ListBox listOfItemsInCart;
        private ListBox listOfPricesinCart;
        private ListBox listOfQuantInCart;
    }
}