namespace NET_LAB5W
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            tabPage2 = new TabPage();
            label6 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            tabPage3 = new TabPage();
            label7 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            button3 = new Button();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            label8 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 10);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(582, 426);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(button1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(574, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Задание 1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(3, 339);
            label3.Name = "label3";
            label3.Size = new Size(144, 37);
            label3.TabIndex = 4;
            label3.Text = "Результат:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(3, 25);
            label2.Name = "label2";
            label2.Size = new Size(308, 37);
            label2.TabIndex = 2;
            label2.Text = "Введите предложение:";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(6, 65);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(532, 228);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(171, 299);
            button1.Name = "button1";
            button1.Size = new Size(212, 32);
            button1.TabIndex = 0;
            button1.Text = "Определить тип предложения";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(button2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(574, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Задание 2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(3, 258);
            label6.Name = "label6";
            label6.Size = new Size(144, 37);
            label6.TabIndex = 5;
            label6.Text = "Результат:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(6, 17);
            label4.Name = "label4";
            label4.Size = new Size(455, 37);
            label4.TabIndex = 3;
            label4.Text = "Введите предложение (2-50 слов):";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 89);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.Size = new Size(522, 122);
            textBox2.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(145, 217);
            button2.Name = "button2";
            button2.Size = new Size(249, 32);
            button2.TabIndex = 1;
            button2.Text = "Найти максимально длинное слово";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(textBox3);
            tabPage3.Controls.Add(button3);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(574, 398);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Задание 3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(6, 266);
            label7.Name = "label7";
            label7.Size = new Size(144, 37);
            label7.TabIndex = 5;
            label7.Text = "Результат:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(6, 17);
            label5.Name = "label5";
            label5.Size = new Size(557, 74);
            label5.TabIndex = 4;
            label5.Text = "Введите слово, чтобы определить повтор \r\nбукв:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(6, 94);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ScrollBars = ScrollBars.Vertical;
            textBox3.Size = new Size(522, 122);
            textBox3.TabIndex = 3;
            // 
            // button3
            // 
            button3.Location = new Point(128, 222);
            button3.Name = "button3";
            button3.Size = new Size(290, 32);
            button3.TabIndex = 1;
            button3.Text = "Определить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.AppWorkspace;
            label1.Location = new Point(1, 434);
            label1.Name = "label1";
            label1.Size = new Size(133, 13);
            label1.TabIndex = 1;
            label1.Text = "Филичева В. А. бИД-241";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            errorProvider3.ContainerControl = this;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 54);
            label8.Name = "label8";
            label8.Size = new Size(258, 15);
            label8.TabIndex = 6;
            label8.Text = "Предложение должно оканчиваться на точку";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 450);
            Controls.Add(label1);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Лабараторная работа 5. Задание 2";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private Label label2;
        private ErrorProvider errorProvider1;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private ErrorProvider errorProvider2;
        private Label label5;
        private TextBox textBox3;
        private Label label6;
        private Label label7;
        private ErrorProvider errorProvider3;
        private Label label8;
    }
}
