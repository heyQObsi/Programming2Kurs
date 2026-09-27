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
            ItemMainLayoutPanel = new TableLayoutPanel();
            ItemInfoPanel = new Panel();
            DescriptionTextbox = new TextBox();
            DescriptionTxt = new Label();
            NameTextbox = new TextBox();
            NameTxt = new Label();
            CostTxt = new Label();
            IdItemTxt = new Label();
            CostTextbox = new TextBox();
            IdItemTextbox = new TextBox();
            SelectedItemTxt = new Label();
            ItemsPanel = new Panel();
            ItemButtonPanel = new TableLayoutPanel();
            ItemAddButton = new Button();
            ItemRemoveButton = new Button();
            ItemsListbox = new ListBox();
            ItemsTxt = new Label();
            ItemMainLayoutPanel.SuspendLayout();
            ItemInfoPanel.SuspendLayout();
            ItemsPanel.SuspendLayout();
            ItemButtonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ItemMainLayoutPanel
            // 
            ItemMainLayoutPanel.ColumnCount = 2;
            ItemMainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.5286636F));
            ItemMainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.4713364F));
            ItemMainLayoutPanel.Controls.Add(ItemInfoPanel, 1, 0);
            ItemMainLayoutPanel.Controls.Add(ItemsPanel, 0, 0);
            ItemMainLayoutPanel.Dock = DockStyle.Fill;
            ItemMainLayoutPanel.Location = new Point(0, 0);
            ItemMainLayoutPanel.Name = "ItemMainLayoutPanel";
            ItemMainLayoutPanel.RowCount = 1;
            ItemMainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 87.33945F));
            ItemMainLayoutPanel.Size = new Size(800, 587);
            ItemMainLayoutPanel.TabIndex = 0;
            ItemMainLayoutPanel.Paint += tableLayoutPanel1_Paint;
            // 
            // ItemInfoPanel
            // 
            ItemInfoPanel.BackColor = SystemColors.ButtonHighlight;
            ItemInfoPanel.Controls.Add(DescriptionTextbox);
            ItemInfoPanel.Controls.Add(DescriptionTxt);
            ItemInfoPanel.Controls.Add(NameTextbox);
            ItemInfoPanel.Controls.Add(NameTxt);
            ItemInfoPanel.Controls.Add(CostTxt);
            ItemInfoPanel.Controls.Add(IdItemTxt);
            ItemInfoPanel.Controls.Add(CostTextbox);
            ItemInfoPanel.Controls.Add(IdItemTextbox);
            ItemInfoPanel.Controls.Add(SelectedItemTxt);
            ItemInfoPanel.Dock = DockStyle.Fill;
            ItemInfoPanel.Location = new Point(335, 3);
            ItemInfoPanel.Name = "ItemInfoPanel";
            ItemInfoPanel.Size = new Size(462, 581);
            ItemInfoPanel.TabIndex = 1;
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
            // IdItemTxt
            // 
            IdItemTxt.AutoSize = true;
            IdItemTxt.Location = new Point(3, 40);
            IdItemTxt.Name = "IdItemTxt";
            IdItemTxt.Size = new Size(21, 15);
            IdItemTxt.TabIndex = 3;
            IdItemTxt.Text = "ID:";
            IdItemTxt.Click += label3_Click;
            // 
            // CostTextbox
            // 
            CostTextbox.Location = new Point(46, 66);
            CostTextbox.Name = "CostTextbox";
            CostTextbox.Size = new Size(136, 23);
            CostTextbox.TabIndex = 2;
            // 
            // IdItemTextbox
            // 
            IdItemTextbox.Location = new Point(46, 37);
            IdItemTextbox.Name = "IdItemTextbox";
            IdItemTextbox.Size = new Size(136, 23);
            IdItemTextbox.TabIndex = 1;
            // 
            // SelectedItemTxt
            // 
            SelectedItemTxt.AutoSize = true;
            SelectedItemTxt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SelectedItemTxt.Location = new Point(3, 10);
            SelectedItemTxt.Name = "SelectedItemTxt";
            SelectedItemTxt.Size = new Size(86, 15);
            SelectedItemTxt.TabIndex = 0;
            SelectedItemTxt.Text = "Selected Item";
            // 
            // ItemsPanel
            // 
            ItemsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsPanel.BackColor = SystemColors.Menu;
            ItemsPanel.Controls.Add(ItemButtonPanel);
            ItemsPanel.Controls.Add(ItemsListbox);
            ItemsPanel.Controls.Add(ItemsTxt);
            ItemsPanel.Location = new Point(3, 3);
            ItemsPanel.Name = "ItemsPanel";
            ItemsPanel.Size = new Size(326, 581);
            ItemsPanel.TabIndex = 2;
            // 
            // ItemButtonPanel
            // 
            ItemButtonPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemButtonPanel.ColumnCount = 3;
            ItemButtonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            ItemButtonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            ItemButtonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            ItemButtonPanel.Controls.Add(ItemAddButton, 0, 0);
            ItemButtonPanel.Controls.Add(ItemRemoveButton, 1, 0);
            ItemButtonPanel.Location = new Point(3, 528);
            ItemButtonPanel.Name = "ItemButtonPanel";
            ItemButtonPanel.RowCount = 1;
            ItemButtonPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ItemButtonPanel.Size = new Size(320, 50);
            ItemButtonPanel.TabIndex = 2;
            // 
            // ItemAddButton
            // 
            ItemAddButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemAddButton.Location = new Point(3, 3);
            ItemAddButton.Name = "ItemAddButton";
            ItemAddButton.Size = new Size(100, 44);
            ItemAddButton.TabIndex = 0;
            ItemAddButton.Text = "Add";
            ItemAddButton.UseVisualStyleBackColor = true;
            ItemAddButton.Click += ItemAddButton_Click;
            // 
            // ItemRemoveButton
            // 
            ItemRemoveButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemRemoveButton.Location = new Point(109, 3);
            ItemRemoveButton.Name = "ItemRemoveButton";
            ItemRemoveButton.Size = new Size(100, 44);
            ItemRemoveButton.TabIndex = 1;
            ItemRemoveButton.Text = "Remove";
            ItemRemoveButton.UseVisualStyleBackColor = true;
            ItemRemoveButton.Click += ItemRemoveButton_Click;
            // 
            // ItemsListbox
            // 
            ItemsListbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsListbox.FormattingEnabled = true;
            ItemsListbox.Location = new Point(3, 28);
            ItemsListbox.Name = "ItemsListbox";
            ItemsListbox.Size = new Size(320, 499);
            ItemsListbox.TabIndex = 1;
            ItemsListbox.SelectedIndexChanged += ItemsListbox_SelectedIndexChanged;
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
            Controls.Add(ItemMainLayoutPanel);
            Name = "ItemsTab";
            Size = new Size(800, 587);
            ItemMainLayoutPanel.ResumeLayout(false);
            ItemInfoPanel.ResumeLayout(false);
            ItemInfoPanel.PerformLayout();
            ItemsPanel.ResumeLayout(false);
            ItemsPanel.PerformLayout();
            ItemButtonPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel ItemMainLayoutPanel;
        private Panel ItemInfoPanel;
        private Panel ItemsPanel;
        private Label ItemsTxt;
        private TableLayoutPanel ItemButtonPanel;
        private ListBox ItemsListbox;
        private Button ItemAddButton;
        private Button ItemRemoveButton;
        private TextBox CostTextbox;
        private TextBox IdItemTextbox;
        private Label SelectedItemTxt;
        private Label IdItemTxt;
        private Label CostTxt;
        private TextBox NameTextbox;
        private Label NameTxt;
        private TextBox DescriptionTextbox;
        private Label DescriptionTxt;
    }
}
