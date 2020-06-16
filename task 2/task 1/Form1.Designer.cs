namespace task_2
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
            this.UserChoice = new System.Windows.Forms.ComboBox();
            this.ButtonInputFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.InputUserNumber = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.OutResult = new System.Windows.Forms.Label();
            this.ButtonSaveFile = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выбор ввода:";
            // 
            // UserChoice
            // 
            this.UserChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserChoice.FormattingEnabled = true;
            this.UserChoice.Items.AddRange(new object[] {
            "Номер из файла",
            "Ввести номер в программе"});
            this.UserChoice.Location = new System.Drawing.Point(130, 93);
            this.UserChoice.Name = "UserChoice";
            this.UserChoice.Size = new System.Drawing.Size(171, 21);
            this.UserChoice.TabIndex = 1;
            this.UserChoice.SelectedIndexChanged += new System.EventHandler(this.UserChoice_SelectedIndexChanged);
            // 
            // ButtonInputFile
            // 
            this.ButtonInputFile.Location = new System.Drawing.Point(17, 126);
            this.ButtonInputFile.Name = "ButtonInputFile";
            this.ButtonInputFile.Size = new System.Drawing.Size(286, 35);
            this.ButtonInputFile.TabIndex = 2;
            this.ButtonInputFile.Text = "Выбор файла";
            this.ButtonInputFile.UseVisualStyleBackColor = true;
            this.ButtonInputFile.Visible = false;
            this.ButtonInputFile.Click += new System.EventHandler(this.ButtonInputFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите номер:";
            this.label2.Visible = false;
            // 
            // InputUserNumber
            // 
            this.InputUserNumber.Location = new System.Drawing.Point(144, 134);
            this.InputUserNumber.Name = "InputUserNumber";
            this.InputUserNumber.Size = new System.Drawing.Size(159, 20);
            this.InputUserNumber.TabIndex = 4;
            this.InputUserNumber.Visible = false;
            this.InputUserNumber.TextChanged += new System.EventHandler(this.InputUserNumber_TextChanged);
            this.InputUserNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputUserNumber_KeyPress);
            // 
            // buttonStart
            // 
            this.buttonStart.Enabled = false;
            this.buttonStart.Location = new System.Drawing.Point(17, 167);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(426, 42);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ответ:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // OutResult
            // 
            this.OutResult.AutoSize = true;
            this.OutResult.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutResult.Location = new System.Drawing.Point(75, 232);
            this.OutResult.Name = "OutResult";
            this.OutResult.Size = new System.Drawing.Size(0, 19);
            this.OutResult.TabIndex = 7;
            // 
            // ButtonSaveFile
            // 
            this.ButtonSaveFile.Enabled = false;
            this.ButtonSaveFile.Location = new System.Drawing.Point(353, 218);
            this.ButtonSaveFile.Name = "ButtonSaveFile";
            this.ButtonSaveFile.Size = new System.Drawing.Size(90, 49);
            this.ButtonSaveFile.TabIndex = 8;
            this.ButtonSaveFile.Text = "Сохранить в файл";
            this.ButtonSaveFile.UseVisualStyleBackColor = true;
            this.ButtonSaveFile.Click += new System.EventHandler(this.ButtonSaveFile_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(319, 137);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(123, 13);
            this.labelError.TabIndex = 9;
            this.labelError.Text = "Некорректные данные";
            this.labelError.Visible = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(442, 74);
            this.label4.TabIndex = 10;
            this.label4.Text = "Данная программа ищет значение элемента последовательности: 011212201220200112… п" +
    "о заданному номеру. Для начала работы необходимо ввести номер элемента, значение" +
    " которого необходимо получить:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 282);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.ButtonSaveFile);
            this.Controls.Add(this.OutResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.InputUserNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonInputFile);
            this.Controls.Add(this.UserChoice);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Число в последовательности";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox UserChoice;
        private System.Windows.Forms.Button ButtonInputFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InputUserNumber;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label OutResult;
        private System.Windows.Forms.Button ButtonSaveFile;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label label4;
    }
}

