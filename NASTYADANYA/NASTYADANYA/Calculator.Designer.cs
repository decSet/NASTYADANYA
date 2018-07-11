namespace NASTYADANYA
{
    partial class Calculator
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Multiplication = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Abs = new System.Windows.Forms.Button();
            this.Sqrt = new System.Windows.Forms.Button();
            this.Tg = new System.Windows.Forms.Button();
            this.Ctg = new System.Windows.Forms.Button();
            this.Sin = new System.Windows.Forms.Button();
            this.Cos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(142, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(178, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 60);
            this.label1.TabIndex = 12;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Multiplication
            // 
            this.Multiplication.Location = new System.Drawing.Point(124, 91);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(50, 50);
            this.Multiplication.TabIndex = 13;
            this.Multiplication.Tag = "";
            this.Multiplication.Text = "*";
            this.Multiplication.UseVisualStyleBackColor = true;
            this.Multiplication.Click += new System.EventHandler(this.button_Click);
            // 
            // Minus
            // 
            this.Minus.Location = new System.Drawing.Point(124, 203);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(50, 50);
            this.Minus.TabIndex = 14;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.button_Click);
            // 
            // Plus
            // 
            this.Plus.Location = new System.Drawing.Point(181, 91);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(50, 162);
            this.Plus.TabIndex = 15;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.button_Click);
            // 
            // Division
            // 
            this.Division.Location = new System.Drawing.Point(124, 147);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(50, 50);
            this.Division.TabIndex = 16;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 20);
            this.textBox1.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 10);
            this.button1.TabIndex = 23;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Abs
            // 
            this.Abs.Location = new System.Drawing.Point(12, 91);
            this.Abs.Name = "Abs";
            this.Abs.Size = new System.Drawing.Size(50, 50);
            this.Abs.TabIndex = 24;
            this.Abs.Tag = "";
            this.Abs.Text = "Abs";
            this.Abs.UseVisualStyleBackColor = true;
            this.Abs.Click += new System.EventHandler(this.button_Click1);
            // 
            // Sqrt
            // 
            this.Sqrt.Location = new System.Drawing.Point(12, 147);
            this.Sqrt.Name = "Sqrt";
            this.Sqrt.Size = new System.Drawing.Size(50, 50);
            this.Sqrt.TabIndex = 25;
            this.Sqrt.Tag = "";
            this.Sqrt.Text = "Sqrt";
            this.Sqrt.UseVisualStyleBackColor = true;
            this.Sqrt.Click += new System.EventHandler(this.button_Click1);
            // 
            // Tg
            // 
            this.Tg.Location = new System.Drawing.Point(12, 203);
            this.Tg.Name = "Tg";
            this.Tg.Size = new System.Drawing.Size(50, 50);
            this.Tg.TabIndex = 26;
            this.Tg.Tag = "";
            this.Tg.Text = "Tg";
            this.Tg.UseVisualStyleBackColor = true;
            this.Tg.Click += new System.EventHandler(this.button_Click1);
            // 
            // Ctg
            // 
            this.Ctg.Location = new System.Drawing.Point(69, 203);
            this.Ctg.Name = "Ctg";
            this.Ctg.Size = new System.Drawing.Size(50, 50);
            this.Ctg.TabIndex = 27;
            this.Ctg.Tag = "";
            this.Ctg.Text = "Ctg";
            this.Ctg.UseVisualStyleBackColor = true;
            this.Ctg.Click += new System.EventHandler(this.button_Click1);
            // 
            // Sin
            // 
            this.Sin.Location = new System.Drawing.Point(69, 147);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(50, 50);
            this.Sin.TabIndex = 28;
            this.Sin.Tag = "";
            this.Sin.Text = "Sin";
            this.Sin.UseVisualStyleBackColor = true;
            this.Sin.Click += new System.EventHandler(this.button_Click1);
            // 
            // Cos
            // 
            this.Cos.Location = new System.Drawing.Point(68, 91);
            this.Cos.Name = "Cos";
            this.Cos.Size = new System.Drawing.Size(50, 50);
            this.Cos.TabIndex = 29;
            this.Cos.Tag = "";
            this.Cos.Text = "Cos";
            this.Cos.UseVisualStyleBackColor = true;
            this.Cos.Click += new System.EventHandler(this.button_Click1);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Cos);
            this.Controls.Add(this.Sin);
            this.Controls.Add(this.Ctg);
            this.Controls.Add(this.Tg);
            this.Controls.Add(this.Sqrt);
            this.Controls.Add(this.Abs);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Multiplication);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Name = "Calculator";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Multiplication;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Abs;
        private System.Windows.Forms.Button Sqrt;
        private System.Windows.Forms.Button Tg;
        private System.Windows.Forms.Button Ctg;
        private System.Windows.Forms.Button Sin;
        private System.Windows.Forms.Button Cos;
    }
}

