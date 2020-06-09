namespace Task11WinForms
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InputStr = new System.Windows.Forms.TextBox();
            this.buttonEncoding = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.resultEncoding = new System.Windows.Forms.ListBox();
            this.buttonDecoding = new System.Windows.Forms.Button();
            this.resultDecoding = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Данная программа кодирует последовательность из нулей и едениц, также присутствуе" +
    "т возможность декодирования";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(357, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите последовательность символов (только 0 и 1 без пробелов):";
            // 
            // InputStr
            // 
            this.InputStr.Location = new System.Drawing.Point(12, 106);
            this.InputStr.Name = "InputStr";
            this.InputStr.Size = new System.Drawing.Size(351, 20);
            this.InputStr.TabIndex = 2;
            this.InputStr.TextChanged += new System.EventHandler(this.InputStr_TextChanged);
            this.InputStr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputStr_KeyPress);
            // 
            // buttonEncoding
            // 
            this.buttonEncoding.Location = new System.Drawing.Point(12, 132);
            this.buttonEncoding.Name = "buttonEncoding";
            this.buttonEncoding.Size = new System.Drawing.Size(351, 32);
            this.buttonEncoding.TabIndex = 3;
            this.buttonEncoding.Text = "Закодировать";
            this.buttonEncoding.UseVisualStyleBackColor = true;
            this.buttonEncoding.Click += new System.EventHandler(this.buttonEncoding_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Результат кодирования: ";
            // 
            // resultEncoding
            // 
            this.resultEncoding.FormattingEnabled = true;
            this.resultEncoding.Location = new System.Drawing.Point(15, 206);
            this.resultEncoding.Name = "resultEncoding";
            this.resultEncoding.Size = new System.Drawing.Size(348, 30);
            this.resultEncoding.TabIndex = 5;
            // 
            // buttonDecoding
            // 
            this.buttonDecoding.Enabled = false;
            this.buttonDecoding.Location = new System.Drawing.Point(15, 243);
            this.buttonDecoding.Name = "buttonDecoding";
            this.buttonDecoding.Size = new System.Drawing.Size(348, 34);
            this.buttonDecoding.TabIndex = 6;
            this.buttonDecoding.Text = "Декодировать";
            this.buttonDecoding.UseVisualStyleBackColor = true;
            this.buttonDecoding.Click += new System.EventHandler(this.buttonDecoding_Click);
            // 
            // resultDecoding
            // 
            this.resultDecoding.FormattingEnabled = true;
            this.resultDecoding.Location = new System.Drawing.Point(18, 316);
            this.resultDecoding.Name = "resultDecoding";
            this.resultDecoding.Size = new System.Drawing.Size(345, 30);
            this.resultDecoding.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Результат декодирования:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 365);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resultDecoding);
            this.Controls.Add(this.buttonDecoding);
            this.Controls.Add(this.resultEncoding);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonEncoding);
            this.Controls.Add(this.InputStr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кодирование и декодирование";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InputStr;
        private System.Windows.Forms.Button buttonEncoding;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox resultEncoding;
        private System.Windows.Forms.Button buttonDecoding;
        private System.Windows.Forms.ListBox resultDecoding;
        private System.Windows.Forms.Label label4;
    }
}

