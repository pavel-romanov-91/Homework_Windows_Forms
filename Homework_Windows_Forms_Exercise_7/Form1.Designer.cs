namespace Homework_Windows_Forms_Exercise_7
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
            this.YearRadio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.secondsRadio = new System.Windows.Forms.RadioButton();
            this.minutesRadio = new System.Windows.Forms.RadioButton();
            this.DayRadio = new System.Windows.Forms.RadioButton();
            this.MonthRadio = new System.Windows.Forms.RadioButton();
            this.textInput = new System.Windows.Forms.TextBox();
            this.textOutput = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnRes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // YearRadio
            // 
            this.YearRadio.AutoSize = true;
            this.YearRadio.Location = new System.Drawing.Point(8, 29);
            this.YearRadio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.YearRadio.Name = "YearRadio";
            this.YearRadio.Size = new System.Drawing.Size(80, 24);
            this.YearRadio.TabIndex = 0;
            this.YearRadio.TabStop = true;
            this.YearRadio.Text = "в годах";
            this.YearRadio.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.secondsRadio);
            this.groupBox1.Controls.Add(this.minutesRadio);
            this.groupBox1.Controls.Add(this.DayRadio);
            this.groupBox1.Controls.Add(this.MonthRadio);
            this.groupBox1.Controls.Add(this.YearRadio);
            this.groupBox1.Location = new System.Drawing.Point(16, 82);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(143, 208);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вид";
            // 
            // secondsRadio
            // 
            this.secondsRadio.AutoSize = true;
            this.secondsRadio.Location = new System.Drawing.Point(8, 171);
            this.secondsRadio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.secondsRadio.Name = "secondsRadio";
            this.secondsRadio.Size = new System.Drawing.Size(103, 24);
            this.secondsRadio.TabIndex = 4;
            this.secondsRadio.TabStop = true;
            this.secondsRadio.Text = "в секундах";
            this.secondsRadio.UseVisualStyleBackColor = true;
            // 
            // minutesRadio
            // 
            this.minutesRadio.AutoSize = true;
            this.minutesRadio.Location = new System.Drawing.Point(8, 135);
            this.minutesRadio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.minutesRadio.Name = "minutesRadio";
            this.minutesRadio.Size = new System.Drawing.Size(99, 24);
            this.minutesRadio.TabIndex = 3;
            this.minutesRadio.TabStop = true;
            this.minutesRadio.Text = "в минутах";
            this.minutesRadio.UseVisualStyleBackColor = true;
            // 
            // DayRadio
            // 
            this.DayRadio.AutoSize = true;
            this.DayRadio.Location = new System.Drawing.Point(8, 100);
            this.DayRadio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DayRadio.Name = "DayRadio";
            this.DayRadio.Size = new System.Drawing.Size(74, 24);
            this.DayRadio.TabIndex = 2;
            this.DayRadio.TabStop = true;
            this.DayRadio.Text = "в днях";
            this.DayRadio.UseVisualStyleBackColor = true;
            // 
            // MonthRadio
            // 
            this.MonthRadio.AutoSize = true;
            this.MonthRadio.Location = new System.Drawing.Point(8, 65);
            this.MonthRadio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MonthRadio.Name = "MonthRadio";
            this.MonthRadio.Size = new System.Drawing.Size(100, 24);
            this.MonthRadio.TabIndex = 1;
            this.MonthRadio.TabStop = true;
            this.MonthRadio.Text = "в месяцах";
            this.MonthRadio.UseVisualStyleBackColor = true;
            // 
            // textInput
            // 
            this.textInput.Location = new System.Drawing.Point(201, 97);
            this.textInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(187, 27);
            this.textInput.TabIndex = 2;
            this.textInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textInput.TextChanged += new System.EventHandler(this.textInput_TextChanged);
            // 
            // textOutput
            // 
            this.textOutput.Location = new System.Drawing.Point(201, 203);
            this.textOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textOutput.Name = "textOutput";
            this.textOutput.ReadOnly = true;
            this.textOutput.Size = new System.Drawing.Size(187, 27);
            this.textOutput.TabIndex = 3;
            this.textOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(244, 149);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 35);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Ок";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnRes
            // 
            this.btnRes.Location = new System.Drawing.Point(244, 254);
            this.btnRes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(100, 35);
            this.btnRes.TabIndex = 5;
            this.btnRes.Text = "Сброс";
            this.btnRes.UseVisualStyleBackColor = true;
            this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "Программа вычисления сколько осталось времени \r\nдо указанной даты";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label.Location = new System.Drawing.Point(205, 66);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(180, 20);
            this.label.TabIndex = 7;
            this.label.Text = "Неверный формат даты!";
            this.label.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 309);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRes);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.textOutput);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Программа";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton YearRadio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton secondsRadio;
        private System.Windows.Forms.RadioButton minutesRadio;
        private System.Windows.Forms.RadioButton DayRadio;
        private System.Windows.Forms.RadioButton MonthRadio;
        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.TextBox textOutput;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnRes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
    }
}