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
            panel2 = new Panel();
            panel3 = new Panel();
            btnFInish = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // questionLabel
            // 
            questionLabel.Location = new Point(38, 120);
            questionLabel.Name = "questionLabel";
            questionLabel.Size = new Size(48, 15);
            questionLabel.TabIndex = 0;
            questionLabel.Text = "Вопрос";
            questionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // answerButton1
            // 
            answerButton1.Location = new Point(41, 112);
            answerButton1.Name = "answerButton1";
            answerButton1.Size = new Size(75, 23);
            answerButton1.TabIndex = 2;
            answerButton1.UseVisualStyleBackColor = true;
            answerButton1.Click += AnswerButton_Click;
            // 
            // resultLabel
            // 
            resultLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            resultLabel.Location = new Point(174, 174);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(174, 51);
            resultLabel.TabIndex = 3;
            resultLabel.Text = "Результат";
            // 
            // answerButton2
            // 
            answerButton2.Location = new Point(214, 112);
            answerButton2.Name = "answerButton2";
            answerButton2.Size = new Size(75, 23);
            answerButton2.TabIndex = 4;
            answerButton2.UseVisualStyleBackColor = true;
            answerButton2.Click += AnswerButton_Click;
            // 
            // answerButton3
            // 
            answerButton3.Location = new Point(385, 112);
            answerButton3.Name = "answerButton3";
            answerButton3.Size = new Size(75, 23);
            answerButton3.TabIndex = 5;
            answerButton3.UseVisualStyleBackColor = true;
            answerButton3.Click += AnswerButton_Click;
            // 
            // NextQ
            // 
            NextQ.Location = new Point(332, 240);
            NextQ.Name = "NextQ";
            NextQ.Size = new Size(75, 23);
            NextQ.TabIndex = 6;
            NextQ.Text = "Далее";
            NextQ.UseVisualStyleBackColor = true;
            NextQ.Click += NextQ_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(questionLabel);
            panel1.Location = new Point(0, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(246, 300);
            panel1.TabIndex = 7;
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
            panel3.Controls.Add(btnFInish);
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
            btnFInish.Location = new Point(73, 240);
            btnFInish.Name = "btnFInish";
            btnFInish.Size = new Size(152, 23);
            btnFInish.TabIndex = 7;
            btnFInish.Text = "Завершить тренеровку";
            btnFInish.UseVisualStyleBackColor = true;
            btnFInish.Click += btnFinish_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "Form1";
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
    }
}
