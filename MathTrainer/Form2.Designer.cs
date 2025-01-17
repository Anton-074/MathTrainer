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
            btnExid = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(radioDivision);
            panel1.Controls.Add(radioMultiplication);
            panel1.Controls.Add(radioSubtraction);
            panel1.Controls.Add(radioAddition);
            panel1.Location = new Point(78, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(207, 290);
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
            radioDivision.Location = new Point(28, 214);
            radioDivision.Name = "radioDivision";
            radioDivision.Size = new Size(150, 35);
            radioDivision.TabIndex = 3;
            radioDivision.Text = "Деление";
            radioDivision.TextAlign = ContentAlignment.MiddleCenter;
            radioDivision.UseVisualStyleBackColor = true;
            // 
            // radioMultiplication
            // 
            radioMultiplication.Location = new Point(27, 157);
            radioMultiplication.Name = "radioMultiplication";
            radioMultiplication.Size = new Size(150, 35);
            radioMultiplication.TabIndex = 2;
            radioMultiplication.Text = "Умножение";
            radioMultiplication.TextAlign = ContentAlignment.MiddleCenter;
            radioMultiplication.UseVisualStyleBackColor = true;
            // 
            // radioSubtraction
            // 
            radioSubtraction.Location = new Point(28, 109);
            radioSubtraction.Name = "radioSubtraction";
            radioSubtraction.Size = new Size(150, 35);
            radioSubtraction.TabIndex = 1;
            radioSubtraction.Text = "Вычитание";
            radioSubtraction.TextAlign = ContentAlignment.MiddleCenter;
            radioSubtraction.UseVisualStyleBackColor = true;
            // 
            // radioAddition
            // 
            radioAddition.Checked = true;
            radioAddition.Location = new Point(28, 59);
            radioAddition.Name = "radioAddition";
            radioAddition.Size = new Size(150, 35);
            radioAddition.TabIndex = 0;
            radioAddition.TabStop = true;
            radioAddition.Text = "Сложение";
            radioAddition.TextAlign = ContentAlignment.MiddleCenter;
            radioAddition.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(radioEasy);
            panel2.Controls.Add(radioMedium);
            panel2.Controls.Add(radioHard);
            panel2.Location = new Point(486, 89);
            panel2.Name = "panel2";
            panel2.Size = new Size(212, 290);
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
            radioEasy.Checked = true;
            radioEasy.Location = new Point(43, 59);
            radioEasy.Name = "radioEasy";
            radioEasy.Size = new Size(121, 49);
            radioEasy.TabIndex = 3;
            radioEasy.TabStop = true;
            radioEasy.Text = "Легкий";
            radioEasy.TextAlign = ContentAlignment.MiddleCenter;
            radioEasy.UseVisualStyleBackColor = true;
            // 
            // radioMedium
            // 
            radioMedium.Location = new Point(43, 125);
            radioMedium.Name = "radioMedium";
            radioMedium.Size = new Size(121, 49);
            radioMedium.TabIndex = 2;
            radioMedium.Text = "Средний";
            radioMedium.TextAlign = ContentAlignment.MiddleCenter;
            radioMedium.UseVisualStyleBackColor = true;
            // 
            // radioHard
            // 
            radioHard.Location = new Point(43, 200);
            radioHard.Name = "radioHard";
            radioHard.Size = new Size(121, 49);
            radioHard.TabIndex = 1;
            radioHard.Text = "Сложный";
            radioHard.TextAlign = ContentAlignment.MiddleCenter;
            radioHard.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(303, 149);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(161, 60);
            btnStart.TabIndex = 6;
            btnStart.Text = "Начать";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnExid
            // 
            btnExid.Location = new Point(303, 234);
            btnExid.Name = "btnExid";
            btnExid.Size = new Size(161, 60);
            btnExid.TabIndex = 7;
            btnExid.Text = "Выход";
            btnExid.UseVisualStyleBackColor = true;
            btnExid.Click += btnExid_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExid);
            Controls.Add(btnStart);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Button btnExid;
    }
}