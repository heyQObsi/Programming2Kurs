namespace _2KursProgramming.View.Tabs
{
    partial class ItemsTab
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
            MainLayoutPanel = new TableLayoutPanel();
            InfoPanel = new Panel();
            DescriptionTextbox = new TextBox();
            DescriptionTxt = new Label();
            NameTextbox = new TextBox();
            NameTxt = new Label();
            CostTxt = new Label();
            IdTxt = new Label();
            CostTextbox = new TextBox();
            IdTextbox = new TextBox();
            SelectedTxt = new Label();
            ItemsPanel = new Panel();
            ButtonPanel = new TableLayoutPanel();
            AddButton = new Button();
            RemoveButton = new Button();
            ItemsListbox = new ListBox();
            ItemsTxt = new Label();
            MainLayoutPanel.SuspendLayout();
            InfoPanel.SuspendLayout();
            ItemsPanel.SuspendLayout();
            ButtonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainLayoutPanel
            // 
            MainLayoutPanel.ColumnCount = 2;
            MainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.5286636F));
            MainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.4713364F));
            MainLayoutPanel.Controls.Add(InfoPanel, 1, 0);
            MainLayoutPanel.Controls.Add(ItemsPanel, 0, 0);
            MainLayoutPanel.Dock = DockStyle.Fill;
            MainLayoutPanel.Location = new Point(0, 0);
            MainLayoutPanel.Name = "MainLayoutPanel";
            MainLayoutPanel.RowCount = 1;
            MainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 87.33945F));
            MainLayoutPanel.Size = new Size(800, 587);
            MainLayoutPanel.TabIndex = 0;
            MainLayoutPanel.Paint += tableLayoutPanel1_Paint;
            // 
            // InfoPanel
            // 
            InfoPanel.BackColor = SystemColors.ButtonHighlight;
            InfoPanel.Controls.Add(DescriptionTextbox);
            InfoPanel.Controls.Add(DescriptionTxt);
            InfoPanel.Controls.Add(NameTextbox);
            InfoPanel.Controls.Add(NameTxt);
            InfoPanel.Controls.Add(CostTxt);
            InfoPanel.Controls.Add(IdTxt);
            InfoPanel.Controls.Add(CostTextbox);
            InfoPanel.Controls.Add(IdTextbox);
            InfoPanel.Controls.Add(SelectedTxt);
            InfoPanel.Dock = DockStyle.Fill;
            InfoPanel.Location = new Point(335, 3);
            InfoPanel.Name = "InfoPanel";
            InfoPanel.Size = new Size(462, 581);
            InfoPanel.TabIndex = 1;
            // 
            // DescriptionTextbox
            // 
            DescriptionTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DescriptionTextbox.Location = new Point(3, 256);
            DescriptionTextbox.MaximumSize = new Size(800, 75);
            DescriptionTextbox.Multiline = true;
            DescriptionTextbox.Name = "DescriptionTextbox";
            DescriptionTextbox.Size = new Size(456, 75);
            DescriptionTextbox.TabIndex = 8;
            // 
            // DescriptionTxt
            // 
            DescriptionTxt.AutoSize = true;
            DescriptionTxt.Location = new Point(3, 238);
            DescriptionTxt.Name = "DescriptionTxt";
            DescriptionTxt.Size = new Size(70, 15);
            DescriptionTxt.TabIndex = 7;
            DescriptionTxt.Text = "Description:";
            // 
            // NameTextbox
            // 
            NameTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameTextbox.Location = new Point(3, 115);
            NameTextbox.MaximumSize = new Size(800, 111);
            NameTextbox.Multiline = true;
            NameTextbox.Name = "NameTextbox";
            NameTextbox.Size = new Size(456, 111);
            NameTextbox.TabIndex = 6;
            // 
            // NameTxt
            // 
            NameTxt.AutoSize = true;
            NameTxt.Location = new Point(3, 97);
            NameTxt.Name = "NameTxt";
            NameTxt.Size = new Size(42, 15);
            NameTxt.TabIndex = 5;
            NameTxt.Text = "Name:";
            // 
            // CostTxt
            // 
            CostTxt.AutoSize = true;
            CostTxt.Location = new Point(3, 69);
            CostTxt.Name = "CostTxt";
            CostTxt.Size = new Size(34, 15);
            CostTxt.TabIndex = 4;
            CostTxt.Text = "Cost:";
            // 
            // IdTxt
            // 
            IdTxt.AutoSize = true;
            IdTxt.Location = new Point(3, 40);
            IdTxt.Name = "IdTxt";
            IdTxt.Size = new Size(21, 15);
            IdTxt.TabIndex = 3;
            IdTxt.Text = "ID:";
            IdTxt.Click += label3_Click;
            // 
            // CostTextbox
            // 
            CostTextbox.Location = new Point(46, 66);
            CostTextbox.Name = "CostTextbox";
            CostTextbox.Size = new Size(136, 23);
            CostTextbox.TabIndex = 2;
            // 
            // IdTextbox
            // 
            IdTextbox.Location = new Point(46, 37);
            IdTextbox.Name = "IdTextbox";
            IdTextbox.Size = new Size(136, 23);
            IdTextbox.TabIndex = 1;
            // 
            // SelectedTxt
            // 
            SelectedTxt.AutoSize = true;
            SelectedTxt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SelectedTxt.Location = new Point(3, 10);
            SelectedTxt.Name = "SelectedTxt";
            SelectedTxt.Size = new Size(86, 15);
            SelectedTxt.TabIndex = 0;
            SelectedTxt.Text = "Selected Item";
            // 
            // ItemsPanel
            // 
            ItemsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsPanel.BackColor = SystemColors.ButtonHighlight;
            ItemsPanel.Controls.Add(ButtonPanel);
            ItemsPanel.Controls.Add(ItemsListbox);
            ItemsPanel.Controls.Add(ItemsTxt);
            ItemsPanel.Location = new Point(3, 3);
            ItemsPanel.Name = "ItemsPanel";
            ItemsPanel.Size = new Size(326, 581);
            ItemsPanel.TabIndex = 2;
            // 
            // ButtonPanel
            // 
            ButtonPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ButtonPanel.ColumnCount = 3;
            ButtonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            ButtonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            ButtonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            ButtonPanel.Controls.Add(AddButton, 0, 0);
            ButtonPanel.Controls.Add(RemoveButton, 1, 0);
            ButtonPanel.Location = new Point(3, 528);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.RowCount = 1;
            ButtonPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ButtonPanel.Size = new Size(320, 50);
            ButtonPanel.TabIndex = 2;
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddButton.Location = new Point(3, 3);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(100, 44);
            AddButton.TabIndex = 0;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // RemoveButton
            // 
            RemoveButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RemoveButton.Location = new Point(109, 3);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(100, 44);
            RemoveButton.TabIndex = 1;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            // 
            // ItemsListbox
            // 
            ItemsListbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsListbox.FormattingEnabled = true;
            ItemsListbox.Location = new Point(3, 28);
            ItemsListbox.Name = "ItemsListbox";
            ItemsListbox.Size = new Size(320, 499);
            ItemsListbox.TabIndex = 1;
            // 
            // ItemsTxt
            // 
            ItemsTxt.AutoSize = true;
            ItemsTxt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ItemsTxt.Location = new Point(3, 10);
            ItemsTxt.Name = "ItemsTxt";
            ItemsTxt.Size = new Size(39, 15);
            ItemsTxt.TabIndex = 0;
            ItemsTxt.Text = "Items";
            ItemsTxt.Click += label1_Click;
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MainLayoutPanel);
            Name = "ItemsTab";
            Size = new Size(800, 587);
            MainLayoutPanel.ResumeLayout(false);
            InfoPanel.ResumeLayout(false);
            InfoPanel.PerformLayout();
            ItemsPanel.ResumeLayout(false);
            ItemsPanel.PerformLayout();
            ButtonPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel MainLayoutPanel;
        private Panel InfoPanel;
        private Panel ItemsPanel;
        private Label ItemsTxt;
        private TableLayoutPanel ButtonPanel;
        private ListBox ItemsListbox;
        private Button AddButton;
        private Button RemoveButton;
        private TextBox CostTextbox;
        private TextBox IdTextbox;
        private Label SelectedTxt;
        private Label IdTxt;
        private Label CostTxt;
        private TextBox NameTextbox;
        private Label NameTxt;
        private TextBox DescriptionTextbox;
        private Label DescriptionTxt;
    }
}
