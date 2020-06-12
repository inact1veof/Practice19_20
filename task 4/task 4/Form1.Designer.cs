namespace task_4
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.InputEps = new System.Windows.Forms.TextBox();
            this.begLen = new System.Windows.Forms.TextBox();
            this.endLen = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Данная программа численным методом решает уравнение:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите точность:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 53);
            this.label3.TabIndex = 2;
            this.label3.Text = "Начало отрезка, содержащего корень:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 46);
            this.label4.TabIndex = 3;
            this.label4.Text = "Конец отрезка, содержащего корень:";
            // 
            // buttonStart
            // 
            this.buttonStart.Enabled = false;
            this.buttonStart.Location = new System.Drawing.Point(7, 205);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(271, 36);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Вычислить";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(82, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ответ:";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(154, 245);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(43, 22);
            this.labelResult.TabIndex = 6;
            this.labelResult.Text = "123";
            // 
            // InputEps
            // 
            this.InputEps.Location = new System.Drawing.Point(184, 80);
            this.InputEps.Name = "InputEps";
            this.InputEps.Size = new System.Drawing.Size(100, 20);
            this.InputEps.TabIndex = 7;
            this.InputEps.TextChanged += new System.EventHandler(this.InputEps_TextChanged);
            this.InputEps.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputEps_KeyPress);
            // 
            // begLen
            // 
            this.begLen.Location = new System.Drawing.Point(86, 128);
            this.begLen.Name = "begLen";
            this.begLen.Size = new System.Drawing.Size(96, 20);
            this.begLen.TabIndex = 8;
            this.begLen.TextChanged += new System.EventHandler(this.begLen_TextChanged);
            this.begLen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.begLen_KeyPress);
            // 
            // endLen
            // 
            this.endLen.Location = new System.Drawing.Point(86, 180);
            this.endLen.Name = "endLen";
            this.endLen.Size = new System.Drawing.Size(100, 20);
            this.endLen.TabIndex = 9;
            this.endLen.TextChanged += new System.EventHandler(this.endLen_TextChanged);
            this.endLen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.endLen_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::task_4.Properties.Resources.ur;
            this.pictureBox1.Location = new System.Drawing.Point(49, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 17);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 279);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.endLen);
            this.Controls.Add(this.begLen);
            this.Controls.Add(this.InputEps);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Решение уравнения";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox InputEps;
        private System.Windows.Forms.TextBox begLen;
        private System.Windows.Forms.TextBox endLen;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

