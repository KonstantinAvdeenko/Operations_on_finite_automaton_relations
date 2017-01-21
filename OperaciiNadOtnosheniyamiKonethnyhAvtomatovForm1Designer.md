namespace OperaciiNadOtnosheniyamiKonethnyhAvtomatov
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Синтез = new System.Windows.Forms.Button();
            this.Пуск = new System.Windows.Forms.Button();
            this.Стоп = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Выходные_Данные1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Множество1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Выходные_Данные2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Множество2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Входные данные";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Выходные данные";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Задание числа состояний";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(144, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(224, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(144, 96);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(224, 20);
            this.textBox3.TabIndex = 5;
            // 
            // Синтез
            // 
            this.Синтез.Location = new System.Drawing.Point(18, 141);
            this.Синтез.Name = "Синтез";
            this.Синтез.Size = new System.Drawing.Size(100, 53);
            this.Синтез.TabIndex = 6;
            this.Синтез.Text = "Синтез состояний";
            this.Синтез.UseVisualStyleBackColor = true;
            this.Синтез.Click += new System.EventHandler(this.Синтез_Click);
            // 
            // Пуск
            // 
            this.Пуск.Location = new System.Drawing.Point(141, 142);
            this.Пуск.Name = "Пуск";
            this.Пуск.Size = new System.Drawing.Size(110, 52);
            this.Пуск.TabIndex = 7;
            this.Пуск.Text = "Пуск нажать после синтеза состояний";
            this.Пуск.UseVisualStyleBackColor = true;
            this.Пуск.Click += new System.EventHandler(this.Пуск_Click);
            // 
            // Стоп
            // 
            this.Стоп.Location = new System.Drawing.Point(273, 142);
            this.Стоп.Name = "Стоп";
            this.Стоп.Size = new System.Drawing.Size(95, 52);
            this.Стоп.TabIndex = 8;
            this.Стоп.Text = "Стоп";
            this.Стоп.UseVisualStyleBackColor = true;
            this.Стоп.Click += new System.EventHandler(this.Стоп_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Выходные_Данные1,
            this.Множество1,
            this.Выходные_Данные2,
            this.Множество2});
            this.dataGridView1.Location = new System.Drawing.Point(426, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 175);
            this.dataGridView1.TabIndex = 9;
            // 
            // Выходные_Данные1
            // 
            this.Выходные_Данные1.HeaderText = "Выходные_Данные1";
            this.Выходные_Данные1.Name = "Выходные_Данные1";
            this.Выходные_Данные1.Width = 150;
            // 
            // Множество1
            // 
            this.Множество1.HeaderText = "Множество1";
            this.Множество1.Name = "Множество1";
            // 
            // Выходные_Данные2
            // 
            this.Выходные_Данные2.HeaderText = "Выходные_Данные2";
            this.Выходные_Данные2.Name = "Выходные_Данные2";
            this.Выходные_Данные2.Width = 150;
            // 
            // Множество2
            // 
            this.Множество2.HeaderText = "Множество2";
            this.Множество2.Name = "Множество2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 261);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Стоп);
            this.Controls.Add(this.Пуск);
            this.Controls.Add(this.Синтез);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Синтез;
        private System.Windows.Forms.Button Пуск;
        private System.Windows.Forms.Button Стоп;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Выходные_Данные1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Множество1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Выходные_Данные2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Множество2;
    }
}