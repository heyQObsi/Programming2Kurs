namespace _2KursProgramming.View.Tabs.Controls
{
    partial class AddressControl
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
            AddressControlTitle = new Label();
            PostIndexTxt = new Label();
            PostIndexTextbox = new TextBox();
            StreetTxt = new Label();
            StreetTextbox = new TextBox();
            BuildingTxt = new Label();
            BuildingTextbox = new TextBox();
            ApartmentTextbox = new TextBox();
            ApartmentTxt = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            CityTextbox = new TextBox();
            CityTxt = new Label();
            CountryTextbox = new TextBox();
            CountryTxt = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // AddressControlTitle
            // 
            AddressControlTitle.AutoSize = true;
            AddressControlTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AddressControlTitle.Location = new Point(3, 9);
            AddressControlTitle.Name = "AddressControlTitle";
            AddressControlTitle.Size = new Size(101, 15);
            AddressControlTitle.TabIndex = 0;
            AddressControlTitle.Text = "Delivery Address";
            // 
            // PostIndexTxt
            // 
            PostIndexTxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PostIndexTxt.AutoSize = true;
            PostIndexTxt.Location = new Point(3, 33);
            PostIndexTxt.Name = "PostIndexTxt";
            PostIndexTxt.Size = new Size(65, 15);
            PostIndexTxt.TabIndex = 1;
            PostIndexTxt.Text = "Post Index:";
            // 
            // PostIndexTextbox
            // 
            PostIndexTextbox.Location = new Point(71, 30);
            PostIndexTextbox.MaximumSize = new Size(125, 23);
            PostIndexTextbox.MinimumSize = new Size(125, 23);
            PostIndexTextbox.Name = "PostIndexTextbox";
            PostIndexTextbox.Size = new Size(125, 23);
            PostIndexTextbox.TabIndex = 2;
            PostIndexTextbox.TextChanged += PostIndexTextbox_TextChanged;
            // 
            // StreetTxt
            // 
            StreetTxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            StreetTxt.AutoSize = true;
            StreetTxt.Location = new Point(3, 91);
            StreetTxt.Name = "StreetTxt";
            StreetTxt.Size = new Size(40, 15);
            StreetTxt.TabIndex = 7;
            StreetTxt.Text = "Street:";
            // 
            // StreetTextbox
            // 
            StreetTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            StreetTextbox.Location = new Point(71, 88);
            StreetTextbox.Name = "StreetTextbox";
            StreetTextbox.Size = new Size(476, 23);
            StreetTextbox.TabIndex = 8;
            StreetTextbox.TextChanged += StreetTextbox_TextChanged;
            // 
            // BuildingTxt
            // 
            BuildingTxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BuildingTxt.AutoSize = true;
            BuildingTxt.Location = new Point(3, 120);
            BuildingTxt.Name = "BuildingTxt";
            BuildingTxt.Size = new Size(54, 15);
            BuildingTxt.TabIndex = 9;
            BuildingTxt.Text = "Building:";
            // 
            // BuildingTextbox
            // 
            BuildingTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BuildingTextbox.Location = new Point(71, 117);
            BuildingTextbox.MaximumSize = new Size(92, 23);
            BuildingTextbox.MinimumSize = new Size(92, 23);
            BuildingTextbox.Name = "BuildingTextbox";
            BuildingTextbox.Size = new Size(92, 23);
            BuildingTextbox.TabIndex = 10;
            BuildingTextbox.TextChanged += BuildingTextbox_TextChanged;
            // 
            // ApartmentTextbox
            // 
            ApartmentTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ApartmentTextbox.Location = new Point(262, 117);
            ApartmentTextbox.MaximumSize = new Size(92, 23);
            ApartmentTextbox.MinimumSize = new Size(92, 23);
            ApartmentTextbox.Name = "ApartmentTextbox";
            ApartmentTextbox.Size = new Size(92, 23);
            ApartmentTextbox.TabIndex = 12;
            ApartmentTextbox.TextChanged += ApartmentTextbox_TextChanged;
            // 
            // ApartmentTxt
            // 
            ApartmentTxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ApartmentTxt.AutoSize = true;
            ApartmentTxt.Location = new Point(189, 120);
            ApartmentTxt.Name = "ApartmentTxt";
            ApartmentTxt.Size = new Size(67, 15);
            ApartmentTxt.TabIndex = 11;
            ApartmentTxt.Text = "Apartment:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AccessibleRole = AccessibleRole.None;
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 68F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(CityTextbox, 4, 0);
            tableLayoutPanel1.Controls.Add(CityTxt, 3, 0);
            tableLayoutPanel1.Controls.Add(CountryTextbox, 1, 0);
            tableLayoutPanel1.Controls.Add(CountryTxt, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 56);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(550, 29);
            tableLayoutPanel1.TabIndex = 13;
            // 
            // CityTextbox
            // 
            CityTextbox.Dock = DockStyle.Fill;
            CityTextbox.Location = new Point(335, 3);
            CityTextbox.Name = "CityTextbox";
            CityTextbox.Size = new Size(212, 23);
            CityTextbox.TabIndex = 7;
            CityTextbox.TextChanged += CityTextbox_TextChanged;
            // 
            // CityTxt
            // 
            CityTxt.AutoSize = true;
            CityTxt.Dock = DockStyle.Fill;
            CityTxt.Location = new Point(298, 0);
            CityTxt.Name = "CityTxt";
            CityTxt.Size = new Size(31, 29);
            CityTxt.TabIndex = 6;
            CityTxt.Text = "City:";
            CityTxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CountryTextbox
            // 
            CountryTextbox.Dock = DockStyle.Fill;
            CountryTextbox.Location = new Point(71, 3);
            CountryTextbox.Name = "CountryTextbox";
            CountryTextbox.Size = new Size(211, 23);
            CountryTextbox.TabIndex = 5;
            CountryTextbox.TextChanged += CountryTextbox_TextChanged;
            // 
            // CountryTxt
            // 
            CountryTxt.AutoSize = true;
            CountryTxt.Dock = DockStyle.Fill;
            CountryTxt.Location = new Point(3, 0);
            CountryTxt.Name = "CountryTxt";
            CountryTxt.Size = new Size(62, 29);
            CountryTxt.TabIndex = 4;
            CountryTxt.Text = "Country:";
            CountryTxt.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AddressControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(ApartmentTextbox);
            Controls.Add(ApartmentTxt);
            Controls.Add(BuildingTextbox);
            Controls.Add(BuildingTxt);
            Controls.Add(StreetTextbox);
            Controls.Add(StreetTxt);
            Controls.Add(PostIndexTextbox);
            Controls.Add(PostIndexTxt);
            Controls.Add(AddressControlTitle);
            Name = "AddressControl";
            Size = new Size(554, 151);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AddressControlTitle;
        private Label PostIndexTxt;
        private TextBox PostIndexTextbox;
        private Label StreetTxt;
        private TextBox StreetTextbox;
        private Label BuildingTxt;
        private TextBox BuildingTextbox;
        private TextBox ApartmentTextbox;
        private Label ApartmentTxt;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox CityTextbox;
        private Label CityTxt;
        private TextBox CountryTextbox;
        private Label CountryTxt;
    }
}
