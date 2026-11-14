namespace _2KursProgramming.View.Tabs
{
    partial class CartsTab
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            CartItemsTxt = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            AddToCartButton = new Button();
            CartItemListbox = new ListBox();
            ClearCartButton = new Button();
            PriceTxt = new Label();
            AmountTxt = new Label();
            CreateOrderButton = new Button();
            RemoveItemButton = new Button();
            CartListbox = new ListBox();
            CustomersCombobox = new ComboBox();
            CartCustomersTxt = new Label();
            CartTxt = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(4, 3, 4, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(CartItemsTxt);
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel1);
            splitContainer1.Panel1.Controls.Add(CartItemListbox);
            splitContainer1.Panel1MinSize = 200;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.White;
            splitContainer1.Panel2.Controls.Add(ClearCartButton);
            splitContainer1.Panel2.Controls.Add(PriceTxt);
            splitContainer1.Panel2.Controls.Add(AmountTxt);
            splitContainer1.Panel2.Controls.Add(CreateOrderButton);
            splitContainer1.Panel2.Controls.Add(RemoveItemButton);
            splitContainer1.Panel2.Controls.Add(CartListbox);
            splitContainer1.Panel2.Controls.Add(CustomersCombobox);
            splitContainer1.Panel2.Controls.Add(CartCustomersTxt);
            splitContainer1.Panel2.Controls.Add(CartTxt);
            splitContainer1.Panel2MinSize = 200;
            splitContainer1.Size = new Size(855, 579);
            splitContainer1.SplitterDistance = 348;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 4;
            // 
            // CartItemsTxt
            // 
            CartItemsTxt.AutoSize = true;
            CartItemsTxt.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CartItemsTxt.Location = new Point(4, 6);
            CartItemsTxt.Margin = new Padding(4, 0, 4, 0);
            CartItemsTxt.Name = "CartItemsTxt";
            CartItemsTxt.Size = new Size(37, 13);
            CartItemsTxt.TabIndex = 1;
            CartItemsTxt.Text = "Items";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333F));
            tableLayoutPanel1.Controls.Add(AddToCartButton, 0, 0);
            tableLayoutPanel1.Location = new Point(4, 528);
            tableLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(341, 47);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // AddToCartButton
            // 
            AddToCartButton.Dock = DockStyle.Fill;
            AddToCartButton.Location = new Point(4, 3);
            AddToCartButton.Margin = new Padding(4, 3, 4, 3);
            AddToCartButton.Name = "AddToCartButton";
            AddToCartButton.Size = new Size(105, 41);
            AddToCartButton.TabIndex = 0;
            AddToCartButton.Text = "Add To Cart";
            AddToCartButton.UseVisualStyleBackColor = true;
            AddToCartButton.Click += AddToCartButton_Click;
            // 
            // CartItemListbox
            // 
            CartItemListbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CartItemListbox.FormattingEnabled = true;
            CartItemListbox.IntegralHeight = false;
            CartItemListbox.Location = new Point(4, 24);
            CartItemListbox.Margin = new Padding(4, 3, 4, 3);
            CartItemListbox.Name = "CartItemListbox";
            CartItemListbox.Size = new Size(340, 500);
            CartItemListbox.TabIndex = 0;
            // 
            // ClearCartButton
            // 
            ClearCartButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ClearCartButton.Location = new Point(374, 321);
            ClearCartButton.Margin = new Padding(4, 3, 4, 3);
            ClearCartButton.Name = "ClearCartButton";
            ClearCartButton.Size = new Size(106, 40);
            ClearCartButton.TabIndex = 15;
            ClearCartButton.Text = "Clear Cart";
            ClearCartButton.UseVisualStyleBackColor = true;
            ClearCartButton.Click += ClearCartButton_Click;
            // 
            // PriceTxt
            // 
            PriceTxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PriceTxt.AutoSize = true;
            PriceTxt.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PriceTxt.Location = new Point(418, 287);
            PriceTxt.Margin = new Padding(4, 0, 4, 0);
            PriceTxt.Name = "PriceTxt";
            PriceTxt.Size = new Size(58, 25);
            PriceTxt.TabIndex = 14;
            PriceTxt.Text = "0,00";
            PriceTxt.TextAlign = ContentAlignment.MiddleRight;
            // 
            // AmountTxt
            // 
            AmountTxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AmountTxt.AutoSize = true;
            AmountTxt.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AmountTxt.Location = new Point(421, 269);
            AmountTxt.Margin = new Padding(4, 0, 4, 0);
            AmountTxt.Name = "AmountTxt";
            AmountTxt.Size = new Size(53, 13);
            AmountTxt.TabIndex = 13;
            AmountTxt.Text = "Amount:";
            // 
            // CreateOrderButton
            // 
            CreateOrderButton.Location = new Point(7, 321);
            CreateOrderButton.Margin = new Padding(4, 3, 4, 3);
            CreateOrderButton.Name = "CreateOrderButton";
            CreateOrderButton.Size = new Size(106, 40);
            CreateOrderButton.TabIndex = 12;
            CreateOrderButton.Text = "Create Order";
            CreateOrderButton.UseVisualStyleBackColor = true;
            CreateOrderButton.Click += CreateOrderButton_Click;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RemoveItemButton.Location = new Point(261, 321);
            RemoveItemButton.Margin = new Padding(4, 3, 4, 3);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(106, 40);
            RemoveItemButton.TabIndex = 11;
            RemoveItemButton.Text = "Remove Item";
            RemoveItemButton.UseVisualStyleBackColor = true;
            RemoveItemButton.Click += RemoveItemButton_Click;
            // 
            // CartListbox
            // 
            CartListbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CartListbox.FormattingEnabled = true;
            CartListbox.IntegralHeight = false;
            CartListbox.Location = new Point(7, 84);
            CartListbox.Margin = new Padding(4, 3, 4, 3);
            CartListbox.Name = "CartListbox";
            CartListbox.Size = new Size(472, 176);
            CartListbox.TabIndex = 3;
            // 
            // CustomersCombobox
            // 
            CustomersCombobox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CustomersCombobox.FormattingEnabled = true;
            CustomersCombobox.Location = new Point(88, 25);
            CustomersCombobox.Margin = new Padding(4, 3, 4, 3);
            CustomersCombobox.Name = "CustomersCombobox";
            CustomersCombobox.Size = new Size(392, 23);
            CustomersCombobox.TabIndex = 10;
            // 
            // CartCustomersTxt
            // 
            CartCustomersTxt.AutoSize = true;
            CartCustomersTxt.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CartCustomersTxt.Location = new Point(7, 29);
            CartCustomersTxt.Margin = new Padding(4, 0, 4, 0);
            CartCustomersTxt.Name = "CartCustomersTxt";
            CartCustomersTxt.Size = new Size(63, 13);
            CartCustomersTxt.TabIndex = 9;
            CartCustomersTxt.Text = "Customer:";
            // 
            // CartTxt
            // 
            CartTxt.AutoSize = true;
            CartTxt.Location = new Point(7, 66);
            CartTxt.Margin = new Padding(4, 0, 4, 0);
            CartTxt.Name = "CartTxt";
            CartTxt.Size = new Size(32, 15);
            CartTxt.TabIndex = 3;
            CartTxt.Text = "Cart:";
            // 
            // CartsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "CartsTab";
            Size = new Size(855, 579);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label CartItemsTxt;
        private TableLayoutPanel tableLayoutPanel1;
        private Button AddToCartButton;
        private ListBox CartItemListbox;
        private ComboBox CustomersCombobox;
        private Label CartCustomersTxt;
        private Label CartTxt;
        private Button ClearCartButton;
        private Label PriceTxt;
        private Label AmountTxt;
        private Button CreateOrderButton;
        private Button RemoveItemButton;
        private ListBox CartListbox;
    }
}
