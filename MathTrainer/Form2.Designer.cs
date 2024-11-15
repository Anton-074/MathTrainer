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
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(radioDivision);
            panel1.Controls.Add(radioMultiplication);
            panel1.Controls.Add(radioSubtraction);
            panel1.Controls.Add(radioAddition);
            panel1.Location = new Point(90, 120);
            panel1.Name = "panel1";
            panel1.Size = new Size(207, 208);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(28, 11);
            label1.Name = "label1";
            label1.Size = new Size(151, 25);
            label1.TabIndex = 4;
            label1.Text = "Что тренеруем?";
            // 
            // radioDivision
            // 
            radioDivision.AutoSize = true;
            radioDivision.Location = new Point(28, 176);
            radioDivision.Name = "radioDivision";
            radioDivision.Size = new Size(72, 19);
            radioDivision.TabIndex = 3;
            radioDivision.TabStop = true;
            radioDivision.Text = "Деление";
            radioDivision.UseVisualStyleBackColor = true;
            // 
            // radioMultiplication
            // 
            radioMultiplication.AutoSize = true;
            radioMultiplication.Location = new Point(28, 135);
            radioMultiplication.Name = "radioMultiplication";
            radioMultiplication.Size = new Size(90, 19);
            radioMultiplication.TabIndex = 2;
            radioMultiplication.TabStop = true;
            radioMultiplication.Text = "Умножение";
            radioMultiplication.UseVisualStyleBackColor = true;
            // 
            // radioSubtraction
            // 
            radioSubtraction.AutoSize = true;
            radioSubtraction.Location = new Point(29, 88);
            radioSubtraction.Name = "radioSubtraction";
            radioSubtraction.Size = new Size(86, 19);
            radioSubtraction.TabIndex = 1;
            radioSubtraction.TabStop = true;
            radioSubtraction.Text = "Вычитание";
            radioSubtraction.UseVisualStyleBackColor = true;
            // 
            // radioAddition
            // 
            radioAddition.AutoSize = true;
            radioAddition.Location = new Point(28, 51);
            radioAddition.Name = "radioAddition";
            radioAddition.Size = new Size(82, 19);
            radioAddition.TabIndex = 0;
            radioAddition.TabStop = true;
            radioAddition.Text = "Сложение";
            radioAddition.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(radioEasy);
            panel2.Controls.Add(radioMedium);
            panel2.Controls.Add(radioHard);
            panel2.Location = new Point(466, 120);
            panel2.Name = "panel2";
            panel2.Size = new Size(212, 208);
            panel2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(15, 11);
            label2.Name = "label2";
            label2.Size = new Size(185, 25);
            label2.TabIndex = 4;
            label2.Text = "Уровень сложности";
            // 
            // radioEasy
            // 
            radioEasy.AutoSize = true;
            radioEasy.Location = new Point(28, 67);
            radioEasy.Name = "radioEasy";
            radioEasy.Size = new Size(64, 19);
            radioEasy.TabIndex = 3;
            radioEasy.TabStop = true;
            radioEasy.Text = "Легкий";
            radioEasy.UseVisualStyleBackColor = true;
            // 
            // radioMedium
            // 
            radioMedium.AutoSize = true;
            radioMedium.Location = new Point(28, 114);
            radioMedium.Name = "radioMedium";
            radioMedium.Size = new Size(73, 19);
            radioMedium.TabIndex = 2;
            radioMedium.TabStop = true;
            radioMedium.Text = "Средний";
            radioMedium.UseVisualStyleBackColor = true;
            // 
            // radioHard
            // 
            radioHard.AutoSize = true;
            radioHard.Location = new Point(28, 164);
            radioHard.Name = "radioHard";
            radioHard.Size = new Size(79, 19);
            radioHard.TabIndex = 1;
            radioHard.TabStop = true;
            radioHard.Text = "Сложный";
            radioHard.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(310, 378);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(161, 60);
            btnStart.TabIndex = 6;
            btnStart.Text = "Начать";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnStart);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
    }
}