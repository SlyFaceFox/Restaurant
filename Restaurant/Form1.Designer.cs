namespace Restaurant
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lstMenu = new System.Windows.Forms.ListBox();
            this.lstZakaz = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtRemake = new System.Windows.Forms.TextBox();
            this.btnRemove2 = new System.Windows.Forms.Button();
            this.lstPrice = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(540, 126);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 31);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(540, 184);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(82, 31);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Удалить";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(538, 246);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(84, 28);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Заказать";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lstMenu
            // 
            this.lstMenu.FormattingEnabled = true;
            this.lstMenu.ItemHeight = 16;
            this.lstMenu.Items.AddRange(new object[] {
            "Гусь жареный",
            "Мундиры",
            "Цветная капуста",
            "Чёрно-белая капуста",
            "Компот",
            "Сухари сушённые ",
            "Глазунья"});
            this.lstMenu.Location = new System.Drawing.Point(304, 126);
            this.lstMenu.Name = "lstMenu";
            this.lstMenu.Size = new System.Drawing.Size(151, 148);
            this.lstMenu.TabIndex = 3;
            this.lstMenu.SelectedIndexChanged += new System.EventHandler(this.lstMenu_SelectedIndexChanged);
            // 
            // lstZakaz
            // 
            this.lstZakaz.FormattingEnabled = true;
            this.lstZakaz.ItemHeight = 16;
            this.lstZakaz.Location = new System.Drawing.Point(688, 126);
            this.lstZakaz.Name = "lstZakaz";
            this.lstZakaz.Size = new System.Drawing.Size(136, 148);
            this.lstZakaz.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Меню";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(734, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Заказ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Изменить меню";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 31);
            this.button1.TabIndex = 9;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtRemake
            // 
            this.txtRemake.Location = new System.Drawing.Point(12, 126);
            this.txtRemake.Name = "txtRemake";
            this.txtRemake.Size = new System.Drawing.Size(174, 22);
            this.txtRemake.TabIndex = 10;
            // 
            // btnRemove2
            // 
            this.btnRemove2.Location = new System.Drawing.Point(688, 299);
            this.btnRemove2.Name = "btnRemove2";
            this.btnRemove2.Size = new System.Drawing.Size(136, 36);
            this.btnRemove2.TabIndex = 11;
            this.btnRemove2.Text = "Удалить всё";
            this.btnRemove2.UseVisualStyleBackColor = true;
            this.btnRemove2.Click += new System.EventHandler(this.btnRemove2_Click);
            // 
            // lstPrice
            // 
            this.lstPrice.FormattingEnabled = true;
            this.lstPrice.ItemHeight = 16;
            this.lstPrice.Items.AddRange(new object[] {
            "450",
            "250",
            "80",
            "100",
            "35",
            "15",
            "150"});
            this.lstPrice.Location = new System.Drawing.Point(461, 126);
            this.lstPrice.Name = "lstPrice";
            this.lstPrice.Size = new System.Drawing.Size(57, 148);
            this.lstPrice.TabIndex = 12;
            this.lstPrice.SelectedIndexChanged += new System.EventHandler(this.lstPrice_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(458, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Цена";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 519);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstPrice);
            this.Controls.Add(this.btnRemove2);
            this.Controls.Add(this.txtRemake);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstZakaz);
            this.Controls.Add(this.lstMenu);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ListBox lstMenu;
        private System.Windows.Forms.ListBox lstZakaz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtRemake;
        private System.Windows.Forms.Button btnRemove2;
        private System.Windows.Forms.ListBox lstPrice;
        private System.Windows.Forms.Label label4;
    }
}

