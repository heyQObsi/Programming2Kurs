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
            textBox1 = new TextBox();
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
            PostIndexTxt.AutoSize = true;
            PostIndexTxt.Location = new Point(3, 33);
            PostIndexTxt.Name = "PostIndexTxt";
            PostIndexTxt.Size = new Size(65, 15);
            PostIndexTxt.TabIndex = 1;
            PostIndexTxt.Text = "Post Index:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(71, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 23);
            textBox1.TabIndex = 2;
            // 
            // AddressControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox1);
            Controls.Add(PostIndexTxt);
            Controls.Add(AddressControlTitle);
            Name = "AddressControl";
            Size = new Size(719, 364);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AddressControlTitle;
        private Label PostIndexTxt;
        private TextBox textBox1;
    }
}
