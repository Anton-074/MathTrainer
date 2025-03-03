namespace MathTrainer
{
    partial class FormRullesMiniGame
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
            panelMain = new Panel();
            buttonExit = new Button();
            labelFill = new Label();
            labelTop = new Label();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Controls.Add(buttonExit);
            panelMain.Controls.Add(labelFill);
            panelMain.Controls.Add(labelTop);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(10, 10);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(10);
            panelMain.Size = new Size(326, 430);
            panelMain.TabIndex = 0;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.FromArgb(35, 34, 73);
            buttonExit.Dock = DockStyle.Bottom;
            buttonExit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonExit.ForeColor = Color.White;
            buttonExit.Location = new Point(10, 364);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(306, 56);
            buttonExit.TabIndex = 3;
            buttonExit.Text = "Выход";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // labelFill
            // 
            labelFill.Dock = DockStyle.Top;
            labelFill.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelFill.ForeColor = Color.White;
            labelFill.Location = new Point(10, 60);
            labelFill.Name = "labelFill";
            labelFill.Size = new Size(306, 301);
            labelFill.TabIndex = 1;
            labelFill.Text = "Правила";
            labelFill.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTop
            // 
            labelTop.Dock = DockStyle.Top;
            labelTop.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTop.ForeColor = Color.White;
            labelTop.Location = new Point(10, 10);
            labelTop.Name = "labelTop";
            labelTop.Size = new Size(306, 50);
            labelTop.TabIndex = 0;
            labelTop.Text = "Правила";
            labelTop.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormRullesMiniGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 69, 74);
            ClientSize = new Size(346, 450);
            ControlBox = false;
            Controls.Add(panelMain);
            Name = "FormRullesMiniGame";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRullesMiniGame";
            Load += FormRullesMiniGame_Load;
            panelMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Label labelTop;
        private Label labelFill;
        private Button buttonExit;
    }
}