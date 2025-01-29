namespace MathTrainer
{
    partial class Form2
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
            panel1 = new Panel();
            radioDegree = new RadioButton();
            label1 = new Label();
            radioDivision = new RadioButton();
            radioMultiplication = new RadioButton();
            radioSubtraction = new RadioButton();
            radioAddition = new RadioButton();
            panel2 = new Panel();
            label2 = new Label();
            radioEasy = new RadioButton();
            radioMedium = new RadioButton();
            radioHard = new RadioButton();
            btnStart = new Button();
            btnExid = new Button();
            label3 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            radioButton10 = new RadioButton();
            radioButton15 = new RadioButton();
            radioButton20 = new RadioButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(radioDegree);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(radioDivision);
            panel1.Controls.Add(radioMultiplication);
            panel1.Controls.Add(radioSubtraction);
            panel1.Controls.Add(radioAddition);
            panel1.Location = new Point(12, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(392, 290);
            panel1.TabIndex = 3;
            // 
            // radioDegree
            // 
            radioDegree.Font = new Font("Segoe UI", 12F);
            radioDegree.ForeColor = Color.White;
            radioDegree.ImageAlign = ContentAlignment.BottomCenter;
            radioDegree.Location = new Point(230, 66);
            radioDegree.Name = "radioDegree";
            radioDegree.Size = new Size(123, 35);
            radioDegree.TabIndex = 5;
            radioDegree.Text = "Степень";
            radioDegree.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(390, 36);
            label1.TabIndex = 4;
            label1.Text = "Что тренеруем?";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // radioDivision
            // 
            radioDivision.Font = new Font("Segoe UI", 12F);
            radioDivision.ForeColor = Color.White;
            radioDivision.ImageAlign = ContentAlignment.BottomCenter;
            radioDivision.Location = new Point(42, 207);
            radioDivision.Name = "radioDivision";
            radioDivision.Size = new Size(123, 35);
            radioDivision.TabIndex = 3;
            radioDivision.Text = "Деление";
            radioDivision.UseVisualStyleBackColor = true;
            // 
            // radioMultiplication
            // 
            radioMultiplication.Font = new Font("Segoe UI", 12F);
            radioMultiplication.ForeColor = Color.White;
            radioMultiplication.ImageAlign = ContentAlignment.BottomCenter;
            radioMultiplication.Location = new Point(42, 157);
            radioMultiplication.Name = "radioMultiplication";
            radioMultiplication.Size = new Size(123, 35);
            radioMultiplication.TabIndex = 2;
            radioMultiplication.Text = "Умножение";
            radioMultiplication.UseVisualStyleBackColor = true;
            // 
            // radioSubtraction
            // 
            radioSubtraction.Font = new Font("Segoe UI", 12F);
            radioSubtraction.ForeColor = Color.White;
            radioSubtraction.ImageAlign = ContentAlignment.BottomCenter;
            radioSubtraction.Location = new Point(42, 115);
            radioSubtraction.Name = "radioSubtraction";
            radioSubtraction.Size = new Size(123, 35);
            radioSubtraction.TabIndex = 1;
            radioSubtraction.Text = "Вычитание";
            radioSubtraction.UseVisualStyleBackColor = true;
            // 
            // radioAddition
            // 
            radioAddition.Checked = true;
            radioAddition.Font = new Font("Segoe UI", 12F);
            radioAddition.ForeColor = Color.White;
            radioAddition.ImageAlign = ContentAlignment.BottomCenter;
            radioAddition.Location = new Point(42, 66);
            radioAddition.Name = "radioAddition";
            radioAddition.Size = new Size(123, 35);
            radioAddition.TabIndex = 0;
            radioAddition.TabStop = true;
            radioAddition.Text = "Сложение";
            radioAddition.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(radioEasy);
            panel2.Controls.Add(radioMedium);
            panel2.Controls.Add(radioHard);
            panel2.Location = new Point(428, 89);
            panel2.Name = "panel2";
            panel2.Size = new Size(212, 290);
            panel2.TabIndex = 5;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(210, 36);
            label2.TabIndex = 4;
            label2.Text = "Уровень сложности";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // radioEasy
            // 
            radioEasy.Checked = true;
            radioEasy.Font = new Font("Segoe UI", 12F);
            radioEasy.ForeColor = Color.White;
            radioEasy.Location = new Point(54, 59);
            radioEasy.Name = "radioEasy";
            radioEasy.Size = new Size(106, 49);
            radioEasy.TabIndex = 3;
            radioEasy.TabStop = true;
            radioEasy.Text = "Легкий";
            radioEasy.UseVisualStyleBackColor = true;
            // 
            // radioMedium
            // 
            radioMedium.Font = new Font("Segoe UI", 12F);
            radioMedium.ForeColor = Color.White;
            radioMedium.Location = new Point(54, 127);
            radioMedium.Name = "radioMedium";
            radioMedium.Size = new Size(106, 49);
            radioMedium.TabIndex = 2;
            radioMedium.Text = "Средний";
            radioMedium.UseVisualStyleBackColor = true;
            // 
            // radioHard
            // 
            radioHard.Font = new Font("Segoe UI", 12F);
            radioHard.ForeColor = Color.White;
            radioHard.Location = new Point(54, 200);
            radioHard.Name = "radioHard";
            radioHard.Size = new Size(106, 49);
            radioHard.TabIndex = 1;
            radioHard.Text = "Сложный";
            radioHard.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.FromArgb(35, 34, 73);
            btnStart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnStart.ForeColor = Color.White;
            btnStart.Location = new Point(536, 404);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(161, 60);
            btnStart.TabIndex = 6;
            btnStart.Text = "Начать";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnExid
            // 
            btnExid.BackColor = Color.FromArgb(35, 34, 73);
            btnExid.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnExid.ForeColor = Color.White;
            btnExid.Location = new Point(243, 404);
            btnExid.Name = "btnExid";
            btnExid.Size = new Size(161, 60);
            btnExid.TabIndex = 7;
            btnExid.Text = "Выход";
            btnExid.UseVisualStyleBackColor = false;
            btnExid.Click += btnExid_Click;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.White;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(938, 62);
            label3.TabIndex = 8;
            label3.Text = "Тренажер по математике";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(radioButton10);
            panel3.Controls.Add(radioButton15);
            panel3.Controls.Add(radioButton20);
            panel3.Location = new Point(714, 89);
            panel3.Name = "panel3";
            panel3.Size = new Size(212, 290);
            panel3.TabIndex = 9;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.White;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(210, 36);
            label4.TabIndex = 4;
            label4.Text = "Количество вопросов";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // radioButton10
            // 
            radioButton10.Checked = true;
            radioButton10.Font = new Font("Segoe UI", 12F);
            radioButton10.ForeColor = Color.White;
            radioButton10.Location = new Point(68, 59);
            radioButton10.Name = "radioButton10";
            radioButton10.Size = new Size(83, 49);
            radioButton10.TabIndex = 3;
            radioButton10.TabStop = true;
            radioButton10.Text = "10";
            radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton15
            // 
            radioButton15.Font = new Font("Segoe UI", 12F);
            radioButton15.ForeColor = Color.White;
            radioButton15.Location = new Point(68, 127);
            radioButton15.Name = "radioButton15";
            radioButton15.Size = new Size(83, 49);
            radioButton15.TabIndex = 2;
            radioButton15.Text = "15";
            radioButton15.UseVisualStyleBackColor = true;
            // 
            // radioButton20
            // 
            radioButton20.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            radioButton20.ForeColor = Color.White;
            radioButton20.Location = new Point(68, 200);
            radioButton20.Name = "radioButton20";
            radioButton20.Size = new Size(83, 49);
            radioButton20.TabIndex = 1;
            radioButton20.Text = "20";
            radioButton20.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 69, 74);
            ClientSize = new Size(938, 514);
            Controls.Add(panel3);
            Controls.Add(label3);
            Controls.Add(btnExid);
            Controls.Add(btnStart);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion


        private Panel panel1;
        private RadioButton radioDivision;
        private RadioButton radioMultiplication;
        private RadioButton radioSubtraction;
        private RadioButton radioAddition;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private RadioButton radioEasy;
        private RadioButton radioMedium;
        private RadioButton radioHard;
        private Button btnStart;
        private Button btnExid;
        private Label label3;
        private Panel panel3;
        private Label label4;
        private RadioButton radioButton10;
        private RadioButton radioButton15;
        private RadioButton radioButton20;
        private RadioButton radioDegree;
    }
}