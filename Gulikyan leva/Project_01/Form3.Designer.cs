namespace Project_01
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lstColor = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.txtLinesCount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "6.11. Подгонка ширины списка под самый длинный текст";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(294, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 1;
            this.listBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            this.listBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox1_DragEnter);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(260, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "6.12. Заполнение списка именами файлов";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 94);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(260, 35);
            this.button3.TabIndex = 3;
            this.button3.Text = "6.13. Вывод цветного списка";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lstColor
            // 
            this.lstColor.FormattingEnabled = true;
            this.lstColor.Location = new System.Drawing.Point(420, 12);
            this.lstColor.Name = "lstColor";
            this.lstColor.Size = new System.Drawing.Size(120, 95);
            this.lstColor.TabIndex = 4;
            this.lstColor.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstColor_DrawItem);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 135);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(260, 35);
            this.button4.TabIndex = 5;
            this.button4.Text = " 6.14. Подгонка ширины комбинированного окна под самый";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(293, 113);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(247, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 176);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(260, 35);
            this.button5.TabIndex = 7;
            this.button5.Text = "6.15. Запрет на раскрытие списка";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 217);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(260, 35);
            this.button6.TabIndex = 8;
            this.button6.Text = "6.16. Изменение высоты элементов списка";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 258);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(260, 35);
            this.button7.TabIndex = 9;
            this.button7.Text = " 6.17. Увеличение высоты под элемент списка";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 299);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(260, 35);
            this.button8.TabIndex = 10;
            this.button8.Text = " 6.18. Подсчет строк в многострочном текстовом поле";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // txtLinesCount
            // 
            this.txtLinesCount.Location = new System.Drawing.Point(293, 143);
            this.txtLinesCount.Name = "txtLinesCount";
            this.txtLinesCount.Size = new System.Drawing.Size(247, 20);
            this.txtLinesCount.TabIndex = 11;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtLinesCount);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.lstColor);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListBox lstColor;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox txtLinesCount;
    }
}