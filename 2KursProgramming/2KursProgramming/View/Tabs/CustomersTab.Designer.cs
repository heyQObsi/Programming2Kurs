namespace _2KursProgramming.View.Tabs
{
    partial class CustomersTab
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            CustMainLayoutPanel = new TableLayoutPanel();
            CustomersPanel = new Panel();
            CustButtonPanel = new TableLayoutPanel();
            AddCustButton = new Button();
            CustRemoveButton = new Button();
            CustomersListbox = new ListBox();
            CustomersTxt = new Label();
            SelectedCustLayoutPanel = new TableLayoutPanel();
            SelectedCustPanel = new Panel();
            AddressTextbox = new TextBox();
            FullNameTextbox = new TextBox();
            CustIdTextbox = new TextBox();
            AddressTxt = new Label();
            FullNameTxt = new Label();
            CustIdTxt = new Label();
            SelectedCustomerTxt = new Label();
            NoNamePanel = new Panel();
            CustMainLayoutPanel.SuspendLayout();
            CustomersPanel.SuspendLayout();
            CustButtonPanel.SuspendLayout();
            SelectedCustLayoutPanel.SuspendLayout();
            SelectedCustPanel.SuspendLayout();
            SuspendLayout();
            // 
            // CustMainLayoutPanel
            // 
            CustMainLayoutPanel.ColumnCount = 2;
            CustMainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.5286636F));
            CustMainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.4713364F));
            CustMainLayoutPanel.Controls.Add(CustomersPanel, 0, 0);
            CustMainLayoutPanel.Controls.Add(SelectedCustLayoutPanel, 1, 0);
            CustMainLayoutPanel.Dock = DockStyle.Fill;
            CustMainLayoutPanel.Location = new Point(0, 0);
            CustMainLayoutPanel.Name = "CustMainLayoutPanel";
            CustMainLayoutPanel.RowCount = 1;
            CustMainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 87.33945F));
            CustMainLayoutPanel.Size = new Size(800, 587);
            CustMainLayoutPanel.TabIndex = 1;
            // 
            // CustomersPanel
            // 
            CustomersPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomersPanel.BackColor = SystemColors.Menu;
            CustomersPanel.Controls.Add(CustButtonPanel);
            CustomersPanel.Controls.Add(CustomersListbox);
            CustomersPanel.Controls.Add(CustomersTxt);
            CustomersPanel.Location = new Point(3, 3);
            CustomersPanel.Name = "CustomersPanel";
            CustomersPanel.Size = new Size(326, 581);
            CustomersPanel.TabIndex = 2;
            // 
            // CustButtonPanel
            // 
            CustButtonPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustButtonPanel.ColumnCount = 3;
            CustButtonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            CustButtonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            CustButtonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            CustButtonPanel.Controls.Add(AddCustButton, 0, 0);
            CustButtonPanel.Controls.Add(CustRemoveButton, 1, 0);
            CustButtonPanel.Location = new Point(3, 528);
            CustButtonPanel.Name = "CustButtonPanel";
            CustButtonPanel.RowCount = 1;
            CustButtonPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            CustButtonPanel.Size = new Size(320, 50);
            CustButtonPanel.TabIndex = 2;
            // 
            // AddCustButton
            // 
            AddCustButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddCustButton.Location = new Point(3, 3);
            AddCustButton.Name = "AddCustButton";
            AddCustButton.Size = new Size(100, 44);
            AddCustButton.TabIndex = 0;
            AddCustButton.Text = "Add";
            AddCustButton.UseVisualStyleBackColor = true;
            AddCustButton.Click += AddCustButton_Click;
            // 
            // CustRemoveButton
            // 
            CustRemoveButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustRemoveButton.Location = new Point(109, 3);
            CustRemoveButton.Name = "CustRemoveButton";
            CustRemoveButton.Size = new Size(100, 44);
            CustRemoveButton.TabIndex = 1;
            CustRemoveButton.Text = "Remove";
            CustRemoveButton.UseVisualStyleBackColor = true;
            CustRemoveButton.Click += CustRemoveButton_Click;
            // 
            // CustomersListbox
            // 
            CustomersListbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomersListbox.FormattingEnabled = true;
            CustomersListbox.Location = new Point(3, 28);
            CustomersListbox.Name = "CustomersListbox";
            CustomersListbox.Size = new Size(320, 499);
            CustomersListbox.TabIndex = 1;
            CustomersListbox.SelectedIndexChanged += CustomersListbox_SelectedIndexChanged;
            // 
            // CustomersTxt
            // 
            CustomersTxt.AutoSize = true;
            CustomersTxt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CustomersTxt.Location = new Point(3, 10);
            CustomersTxt.Name = "CustomersTxt";
            CustomersTxt.Size = new Size(66, 15);
            CustomersTxt.TabIndex = 0;
            CustomersTxt.Text = "Customers";
            // 
            // SelectedCustLayoutPanel
            // 
            SelectedCustLayoutPanel.ColumnCount = 1;
            SelectedCustLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            SelectedCustLayoutPanel.Controls.Add(SelectedCustPanel, 0, 0);
            SelectedCustLayoutPanel.Controls.Add(NoNamePanel, 0, 1);
            SelectedCustLayoutPanel.Dock = DockStyle.Fill;
            SelectedCustLayoutPanel.Location = new Point(335, 3);
            SelectedCustLayoutPanel.Name = "SelectedCustLayoutPanel";
            SelectedCustLayoutPanel.RowCount = 2;
            SelectedCustLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 39.0705681F));
            SelectedCustLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 60.9294319F));
            SelectedCustLayoutPanel.Size = new Size(462, 581);
            SelectedCustLayoutPanel.TabIndex = 3;
            // 
            // SelectedCustPanel
            // 
            SelectedCustPanel.AllowDrop = true;
            SelectedCustPanel.BackColor = SystemColors.Window;
            SelectedCustPanel.Controls.Add(AddressTextbox);
            SelectedCustPanel.Controls.Add(FullNameTextbox);
            SelectedCustPanel.Controls.Add(CustIdTextbox);
            SelectedCustPanel.Controls.Add(AddressTxt);
            SelectedCustPanel.Controls.Add(FullNameTxt);
            SelectedCustPanel.Controls.Add(CustIdTxt);
            SelectedCustPanel.Controls.Add(SelectedCustomerTxt);
            SelectedCustPanel.Dock = DockStyle.Fill;
            SelectedCustPanel.Location = new Point(3, 3);
            SelectedCustPanel.Name = "SelectedCustPanel";
            SelectedCustPanel.Size = new Size(456, 221);
            SelectedCustPanel.TabIndex = 0;
            // 
            // AddressTextbox
            // 
            AddressTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddressTextbox.Location = new Point(73, 92);
            AddressTextbox.MaximumSize = new Size(800, 126);
            AddressTextbox.Multiline = true;
            AddressTextbox.Name = "AddressTextbox";
            AddressTextbox.Size = new Size(380, 126);
            AddressTextbox.TabIndex = 6;
            AddressTextbox.TextChanged += AddressTextbox_TextChanged;
            // 
            // FullNameTextbox
            // 
            FullNameTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FullNameTextbox.Location = new Point(73, 63);
            FullNameTextbox.MaximumSize = new Size(500, 23);
            FullNameTextbox.Name = "FullNameTextbox";
            FullNameTextbox.Size = new Size(380, 23);
            FullNameTextbox.TabIndex = 5;
            FullNameTextbox.TextChanged += FullNameTextbox_TextChanged;
            // 
            // CustIdTextbox
            // 
            CustIdTextbox.Location = new Point(73, 34);
            CustIdTextbox.Name = "CustIdTextbox";
            CustIdTextbox.Size = new Size(137, 23);
            CustIdTextbox.TabIndex = 4;
            // 
            // AddressTxt
            // 
            AddressTxt.AutoSize = true;
            AddressTxt.Location = new Point(0, 95);
            AddressTxt.Name = "AddressTxt";
            AddressTxt.Size = new Size(52, 15);
            AddressTxt.TabIndex = 3;
            AddressTxt.Text = "Address:";
            // 
            // FullNameTxt
            // 
            FullNameTxt.AutoSize = true;
            FullNameTxt.Location = new Point(0, 66);
            FullNameTxt.Name = "FullNameTxt";
            FullNameTxt.Size = new Size(64, 15);
            FullNameTxt.TabIndex = 2;
            FullNameTxt.Text = "Full Name:";
            // 
            // CustIdTxt
            // 
            CustIdTxt.AutoSize = true;
            CustIdTxt.Location = new Point(0, 37);
            CustIdTxt.Name = "CustIdTxt";
            CustIdTxt.Size = new Size(21, 15);
            CustIdTxt.TabIndex = 1;
            CustIdTxt.Text = "ID:";
            // 
            // SelectedCustomerTxt
            // 
            SelectedCustomerTxt.AutoSize = true;
            SelectedCustomerTxt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SelectedCustomerTxt.Location = new Point(0, 7);
            SelectedCustomerTxt.Name = "SelectedCustomerTxt";
            SelectedCustomerTxt.Size = new Size(113, 15);
            SelectedCustomerTxt.TabIndex = 0;
            SelectedCustomerTxt.Text = "Selected Customer";
            // 
            // NoNamePanel
            // 
            NoNamePanel.BackColor = SystemColors.Window;
            NoNamePanel.Dock = DockStyle.Fill;
            NoNamePanel.Location = new Point(3, 230);
            NoNamePanel.Name = "NoNamePanel";
            NoNamePanel.Size = new Size(456, 348);
            NoNamePanel.TabIndex = 1;
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CustMainLayoutPanel);
            Name = "CustomersTab";
            Size = new Size(800, 587);
            CustMainLayoutPanel.ResumeLayout(false);
            CustomersPanel.ResumeLayout(false);
            CustomersPanel.PerformLayout();
            CustButtonPanel.ResumeLayout(false);
            SelectedCustLayoutPanel.ResumeLayout(false);
            SelectedCustPanel.ResumeLayout(false);
            SelectedCustPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel CustMainLayoutPanel;
        private Panel CustomersPanel;
        private TableLayoutPanel CustButtonPanel;
        private Button AddCustButton;
        private Button CustRemoveButton;
        private ListBox CustomersListbox;
        private Label CustomersTxt;
        private TableLayoutPanel SelectedCustLayoutPanel;
        private Panel SelectedCustPanel;
        private TextBox AddressTextbox;
        private TextBox FullNameTextbox;
        private TextBox CustIdTextbox;
        private Label AddressTxt;
        private Label FullNameTxt;
        private Label CustIdTxt;
        private Label SelectedCustomerTxt;
        private Panel NoNamePanel;
    }
}
