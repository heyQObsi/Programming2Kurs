using _2KursProgramming.View.Tabs.Controls;

namespace _2KursProgramming.View.Tabs
{
    partial class OrdersTab
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
            OrderTable = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            OrderTxt = new Label();
            PriceTxt = new Label();
            AmountTxt = new Label();
            OrderItemsListbox = new ListBox();
            OrderItemsTxt = new Label();
            AddressControl = new AddressControl();
            StatusCombobox = new ComboBox();
            StatusTxt = new Label();
            CreatedTxt = new Label();
            CreatedTextbox = new TextBox();
            OrderIDTxt = new Label();
            SelectedItemLabel = new Label();
            IdTextbox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrderTable).BeginInit();
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
            splitContainer1.Panel1.Controls.Add(OrderTable);
            splitContainer1.Panel1.Controls.Add(OrderTxt);
            splitContainer1.Panel1MinSize = 200;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.White;
            splitContainer1.Panel2.Controls.Add(PriceTxt);
            splitContainer1.Panel2.Controls.Add(AmountTxt);
            splitContainer1.Panel2.Controls.Add(OrderItemsListbox);
            splitContainer1.Panel2.Controls.Add(OrderItemsTxt);
            splitContainer1.Panel2.Controls.Add(AddressControl);
            splitContainer1.Panel2.Controls.Add(StatusCombobox);
            splitContainer1.Panel2.Controls.Add(StatusTxt);
            splitContainer1.Panel2.Controls.Add(CreatedTxt);
            splitContainer1.Panel2.Controls.Add(CreatedTextbox);
            splitContainer1.Panel2.Controls.Add(OrderIDTxt);
            splitContainer1.Panel2.Controls.Add(SelectedItemLabel);
            splitContainer1.Panel2.Controls.Add(IdTextbox);
            splitContainer1.Panel2MinSize = 200;
            splitContainer1.Size = new Size(1063, 623);
            splitContainer1.SplitterDistance = 498;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 5;
            // 
            // OrderTable
            // 
            OrderTable.AllowUserToAddRows = false;
            OrderTable.AllowUserToDeleteRows = false;
            OrderTable.AllowUserToResizeRows = false;
            OrderTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OrderTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderTable.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column6, Column3, Column4, Column5 });
            OrderTable.EditMode = DataGridViewEditMode.EditProgrammatically;
            OrderTable.Location = new Point(4, 24);
            OrderTable.Margin = new Padding(4, 3, 4, 3);
            OrderTable.MultiSelect = false;
            OrderTable.Name = "OrderTable";
            OrderTable.ReadOnly = true;
            OrderTable.RowHeadersVisible = false;
            OrderTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OrderTable.Size = new Size(491, 541);
            OrderTable.TabIndex = 3;
            // 
            // Column1
            // 
            Column1.HeaderText = "Id";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Created";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Order Status";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Customer Full Name";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 200;
            // 
            // Column4
            // 
            Column4.HeaderText = "Delivery Address";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 300;
            // 
            // Column5
            // 
            Column5.HeaderText = "Amount";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // OrderTxt
            // 
            OrderTxt.AutoSize = true;
            OrderTxt.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            OrderTxt.Location = new Point(4, 6);
            OrderTxt.Margin = new Padding(4, 0, 4, 0);
            OrderTxt.Name = "OrderTxt";
            OrderTxt.Size = new Size(44, 13);
            OrderTxt.TabIndex = 1;
            OrderTxt.Text = "Orders";
            // 
            // PriceTxt
            // 
            PriceTxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PriceTxt.AutoSize = true;
            PriceTxt.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PriceTxt.Location = new Point(444, 513);
            PriceTxt.Margin = new Padding(4, 0, 4, 0);
            PriceTxt.Name = "PriceTxt";
            PriceTxt.Size = new Size(104, 25);
            PriceTxt.TabIndex = 22;
            PriceTxt.Text = "4 999,90";
            PriceTxt.TextAlign = ContentAlignment.MiddleRight;
            // 
            // AmountTxt
            // 
            AmountTxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AmountTxt.AutoSize = true;
            AmountTxt.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AmountTxt.Location = new Point(494, 496);
            AmountTxt.Margin = new Padding(4, 0, 4, 0);
            AmountTxt.Name = "AmountTxt";
            AmountTxt.Size = new Size(53, 13);
            AmountTxt.TabIndex = 21;
            AmountTxt.Text = "Amount:";
            // 
            // OrderItemsListbox
            // 
            OrderItemsListbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            OrderItemsListbox.FormattingEnabled = true;
            OrderItemsListbox.IntegralHeight = false;
            OrderItemsListbox.Location = new Point(7, 302);
            OrderItemsListbox.Margin = new Padding(4, 3, 4, 3);
            OrderItemsListbox.Name = "OrderItemsListbox";
            OrderItemsListbox.Size = new Size(547, 186);
            OrderItemsListbox.TabIndex = 20;
            // 
            // OrderItemsTxt
            // 
            OrderItemsTxt.AutoSize = true;
            OrderItemsTxt.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            OrderItemsTxt.Location = new Point(4, 284);
            OrderItemsTxt.Margin = new Padding(4, 0, 4, 0);
            OrderItemsTxt.Name = "OrderItemsTxt";
            OrderItemsTxt.Size = new Size(72, 13);
            OrderItemsTxt.TabIndex = 19;
            OrderItemsTxt.Text = "Order Items";
            // 
            // AddressControl
            // 
            AddressControl.BackColor = SystemColors.Window;
            AddressControl.Location = new Point(7, 127);
            AddressControl.Margin = new Padding(4, 3, 4, 3);
            AddressControl.Name = "AddressControl";
            AddressControl.Size = new Size(551, 153);
            AddressControl.TabIndex = 18;
            // 
            // StatusCombobox
            // 
            StatusCombobox.FormattingEnabled = true;
            StatusCombobox.Location = new Point(76, 96);
            StatusCombobox.Margin = new Padding(4, 3, 4, 3);
            StatusCombobox.Name = "StatusCombobox";
            StatusCombobox.Size = new Size(142, 23);
            StatusCombobox.TabIndex = 17;
            // 
            // StatusTxt
            // 
            StatusTxt.AutoSize = true;
            StatusTxt.Location = new Point(4, 99);
            StatusTxt.Margin = new Padding(4, 0, 4, 0);
            StatusTxt.Name = "StatusTxt";
            StatusTxt.Size = new Size(42, 15);
            StatusTxt.TabIndex = 16;
            StatusTxt.Text = "Status:";
            // 
            // CreatedTxt
            // 
            CreatedTxt.AutoSize = true;
            CreatedTxt.Location = new Point(4, 69);
            CreatedTxt.Margin = new Padding(4, 0, 4, 0);
            CreatedTxt.Name = "CreatedTxt";
            CreatedTxt.Size = new Size(51, 15);
            CreatedTxt.TabIndex = 15;
            CreatedTxt.Text = "Created:";
            // 
            // CreatedTextbox
            // 
            CreatedTextbox.Location = new Point(76, 66);
            CreatedTextbox.Margin = new Padding(4, 3, 4, 3);
            CreatedTextbox.Name = "CreatedTextbox";
            CreatedTextbox.Size = new Size(142, 23);
            CreatedTextbox.TabIndex = 14;
            // 
            // OrderIDTxt
            // 
            OrderIDTxt.AutoSize = true;
            OrderIDTxt.Location = new Point(4, 39);
            OrderIDTxt.Margin = new Padding(4, 0, 4, 0);
            OrderIDTxt.Name = "OrderIDTxt";
            OrderIDTxt.Size = new Size(21, 15);
            OrderIDTxt.TabIndex = 13;
            OrderIDTxt.Text = "ID:";
            // 
            // SelectedItemLabel
            // 
            SelectedItemLabel.AutoSize = true;
            SelectedItemLabel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SelectedItemLabel.Location = new Point(4, 6);
            SelectedItemLabel.Margin = new Padding(4, 0, 4, 0);
            SelectedItemLabel.Name = "SelectedItemLabel";
            SelectedItemLabel.Size = new Size(92, 13);
            SelectedItemLabel.TabIndex = 12;
            SelectedItemLabel.Text = "Selected Order";
            // 
            // IdTextbox
            // 
            IdTextbox.Location = new Point(76, 36);
            IdTextbox.Margin = new Padding(4, 3, 4, 3);
            IdTextbox.Name = "IdTextbox";
            IdTextbox.Size = new Size(142, 23);
            IdTextbox.TabIndex = 11;
            // 
            // OrdersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "OrdersTab";
            Size = new Size(1063, 623);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)OrderTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label OrderTxt;
        private DataGridView OrderTable;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Label OrderItemsTxt;
        private AddressControl AddressControl;
        private ComboBox StatusCombobox;
        private Label StatusTxt;
        private Label CreatedTxt;
        private TextBox CreatedTextbox;
        private Label OrderIDTxt;
        private Label SelectedItemLabel;
        private TextBox IdTextbox;
        private ListBox OrderItemsListbox;
        private Label PriceTxt;
        private Label AmountTxt;
    }
}
