namespace _2KursProgramming
{
    partial class MainForm
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
            MainIcon = new TabControl();
            ItemTabPage = new TabPage();
            itemsTab1 = new _2KursProgramming.View.Tabs.ItemsTab();
            CustTabPage = new TabPage();
            customersTab1 = new _2KursProgramming.View.Tabs.CustomersTab();
            CartsTab = new TabPage();
            cartsTab1 = new _2KursProgramming.View.Tabs.CartsTab();
            tabPage1 = new TabPage();
            ordersTab1 = new _2KursProgramming.View.Tabs.OrdersTab();
            MainIcon.SuspendLayout();
            ItemTabPage.SuspendLayout();
            CustTabPage.SuspendLayout();
            CartsTab.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // MainIcon
            // 
            MainIcon.Controls.Add(ItemTabPage);
            MainIcon.Controls.Add(CustTabPage);
            MainIcon.Controls.Add(CartsTab);
            MainIcon.Controls.Add(tabPage1);
            MainIcon.Dock = DockStyle.Fill;
            MainIcon.Location = new Point(0, 0);
            MainIcon.Name = "MainIcon";
            MainIcon.SelectedIndex = 0;
            MainIcon.Size = new Size(688, 601);
            MainIcon.TabIndex = 0;
            MainIcon.SelectedIndexChanged += MainIcon_SelectedIndexChanged;
            // 
            // ItemTabPage
            // 
            ItemTabPage.Controls.Add(itemsTab1);
            ItemTabPage.Location = new Point(4, 24);
            ItemTabPage.Name = "ItemTabPage";
            ItemTabPage.Padding = new Padding(3);
            ItemTabPage.Size = new Size(680, 573);
            ItemTabPage.TabIndex = 0;
            ItemTabPage.Text = "Items";
            ItemTabPage.UseVisualStyleBackColor = true;
            // 
            // itemsTab1
            // 
            itemsTab1.Dock = DockStyle.Fill;
            itemsTab1.Location = new Point(3, 3);
            itemsTab1.Name = "itemsTab1";
            itemsTab1.Size = new Size(674, 567);
            itemsTab1.TabIndex = 0;
            // 
            // CustTabPage
            // 
            CustTabPage.Controls.Add(customersTab1);
            CustTabPage.Location = new Point(4, 24);
            CustTabPage.Name = "CustTabPage";
            CustTabPage.Padding = new Padding(3);
            CustTabPage.Size = new Size(680, 573);
            CustTabPage.TabIndex = 1;
            CustTabPage.Text = "Customers";
            CustTabPage.UseVisualStyleBackColor = true;
            // 
            // customersTab1
            // 
            customersTab1.Dock = DockStyle.Fill;
            customersTab1.Location = new Point(3, 3);
            customersTab1.Name = "customersTab1";
            customersTab1.Size = new Size(674, 567);
            customersTab1.TabIndex = 0;
            // 
            // CartsTab
            // 
            CartsTab.Controls.Add(cartsTab1);
            CartsTab.Location = new Point(4, 24);
            CartsTab.Name = "CartsTab";
            CartsTab.Padding = new Padding(3);
            CartsTab.Size = new Size(680, 573);
            CartsTab.TabIndex = 2;
            CartsTab.Text = "Carts";
            CartsTab.UseVisualStyleBackColor = true;
            // 
            // cartsTab1
            // 
            cartsTab1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cartsTab1.Dock = DockStyle.Fill;
            cartsTab1.Location = new Point(3, 3);
            cartsTab1.Margin = new Padding(4, 3, 4, 3);
            cartsTab1.Name = "cartsTab1";
            cartsTab1.Size = new Size(674, 567);
            cartsTab1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(ordersTab1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(680, 573);
            tabPage1.TabIndex = 3;
            tabPage1.Text = "Orders";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // ordersTab1
            // 
            ordersTab1.AutoSize = true;
            ordersTab1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ordersTab1.Dock = DockStyle.Fill;
            ordersTab1.Location = new Point(3, 3);
            ordersTab1.Margin = new Padding(4, 3, 4, 3);
            ordersTab1.Name = "ordersTab1";
            ordersTab1.Size = new Size(674, 567);
            ordersTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 601);
            Controls.Add(MainIcon);
            Name = "MainForm";
            Text = "Form1";
            MainIcon.ResumeLayout(false);
            ItemTabPage.ResumeLayout(false);
            CustTabPage.ResumeLayout(false);
            CartsTab.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl MainIcon;
        private TabPage ItemTabPage;
        private View.Tabs.ItemsTab itemsTab1;
        private TabPage CustTabPage;
        private View.Tabs.CustomersTab customersTab1;
        private TabPage CartsTab;
        private View.Tabs.CartsTab cartsTab1;
        private TabPage tabPage1;
        private View.Tabs.OrdersTab ordersTab1;
    }
}
