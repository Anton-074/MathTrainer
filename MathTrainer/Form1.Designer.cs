namespace MathTrainer
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
            questionLabel = new Label();
            answerButton1 = new Button();
            resultLabel = new Label();
            answerButton2 = new Button();
            answerButton3 = new Button();
            NextQ = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            btnFInish = new Button();
            labelDifficulty = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // questionLabel
            // 
            questionLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            questionLabel.Location = new Point(41, 123);
            questionLabel.Name = "questionLabel";
            questionLabel.Size = new Size(156, 51);
            questionLabel.TabIndex = 0;
            questionLabel.Text = "Вопрос";
            questionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // answerButton1
            // 
            answerButton1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            answerButton1.Location = new Point(55, 64);
            answerButton1.Name = "answerButton1";
            answerButton1.Size = new Size(99, 51);
            answerButton1.TabIndex = 2;
            answerButton1.UseVisualStyleBackColor = true;
            answerButton1.Click += AnswerButton_Click;
            // 
            // resultLabel
            // 
            resultLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            resultLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            resultLabel.Location = new Point(98, 152);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(361, 51);
            resultLabel.TabIndex = 3;
            resultLabel.Text = "Результат";
            resultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // answerButton2
            // 
            answerButton2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            answerButton2.Location = new Point(228, 64);
            answerButton2.Name = "answerButton2";
            answerButton2.Size = new Size(99, 51);
            answerButton2.TabIndex = 4;
            answerButton2.UseVisualStyleBackColor = true;
            answerButton2.Click += AnswerButton_Click;
            // 
            // answerButton3
            // 
            answerButton3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            answerButton3.Location = new Point(400, 64);
            answerButton3.Name = "answerButton3";
            answerButton3.Size = new Size(99, 51);
            answerButton3.TabIndex = 5;
            answerButton3.UseVisualStyleBackColor = true;
            answerButton3.Click += AnswerButton_Click;
            // 
            // NextQ
            // 
            NextQ.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NextQ.Location = new Point(172, 256);
            NextQ.Name = "NextQ";
            NextQ.Size = new Size(202, 41);
            NextQ.TabIndex = 6;
            NextQ.Text = "Далее";
            NextQ.UseVisualStyleBackColor = true;
            NextQ.Click += NextQ_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(questionLabel);
            panel1.Location = new Point(0, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(246, 300);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(23, 64);
            label1.Name = "label1";
            label1.Size = new Size(193, 48);
            label1.TabIndex = 9;
            label1.Text = "Решите пример";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Location = new Point(244, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(554, 300);
            panel2.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(resultLabel);
            panel3.Controls.Add(answerButton1);
            panel3.Controls.Add(NextQ);
            panel3.Controls.Add(answerButton2);
            panel3.Controls.Add(answerButton3);
            panel3.Location = new Point(244, 81);
            panel3.Name = "panel3";
            panel3.Size = new Size(554, 300);
            panel3.TabIndex = 8;
            // 
            // btnFInish
            // 
            btnFInish.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnFInish.Location = new Point(24, 395);
            btnFInish.Name = "btnFInish";
            btnFInish.Size = new Size(199, 41);
            btnFInish.TabIndex = 7;
            btnFInish.Text = "Завершить тренеровку";
            btnFInish.UseVisualStyleBackColor = true;
            btnFInish.Click += btnFinish_Click;
            // 
            // labelDifficulty
            // 
            labelDifficulty.Dock = DockStyle.Top;
            labelDifficulty.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelDifficulty.Location = new Point(0, 0);
            labelDifficulty.Name = "labelDifficulty";
            labelDifficulty.Size = new Size(800, 79);
            labelDifficulty.TabIndex = 9;
            labelDifficulty.Text = "Сложность";
            labelDifficulty.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 448);
            Controls.Add(btnFInish);
            Controls.Add(labelDifficulty);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label questionLabel;
        private Label resultLabel;
        private Button answerButton1;
        private Button answerButton2;
        private Button answerButton3;
        private Button NextQ;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btnFInish;
        private Label label1;
        private Label labelDifficulty;
    }
}
