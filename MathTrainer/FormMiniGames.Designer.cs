namespace MathTrainer
{
    partial class FormMiniGames
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
            components = new System.ComponentModel.Container();
            tableLayoutPanel = new TableLayoutPanel();
            labelTop = new Label();
            labelTimer = new Label();
            timer = new System.Windows.Forms.Timer(components);
            panelFill = new Panel();
            panelTop = new Panel();
            buttonRules = new Button();
            panel3 = new Panel();
            buttonStart = new Button();
            buttonExit = new Button();
            panelFill.SuspendLayout();
            panelTop.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel.BackColor = Color.FromArgb(24, 69, 74);
            tableLayoutPanel.ColumnCount = 5;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.ForeColor = Color.Transparent;
            tableLayoutPanel.Location = new Point(10, 10);
            tableLayoutPanel.Margin = new Padding(1);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RightToLeft = RightToLeft.Yes;
            tableLayoutPanel.RowCount = 5;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel.Size = new Size(585, 418);
            tableLayoutPanel.TabIndex = 0;
            // 
            // labelTop
            // 
            labelTop.BackColor = Color.Transparent;
            labelTop.Dock = DockStyle.Fill;
            labelTop.Font = new Font("Segoe UI", 14.25F);
            labelTop.ForeColor = Color.White;
            labelTop.Location = new Point(129, 10);
            labelTop.Name = "labelTop";
            labelTop.Size = new Size(386, 61);
            labelTop.TabIndex = 1;
            labelTop.Text = "Необходимо найти выражение = ";
            labelTop.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTimer
            // 
            labelTimer.BackColor = Color.FromArgb(24, 69, 74);
            labelTimer.Dock = DockStyle.Right;
            labelTimer.Font = new Font("Segoe UI", 14.25F);
            labelTimer.ForeColor = Color.White;
            labelTimer.Location = new Point(515, 10);
            labelTimer.Name = "labelTimer";
            labelTimer.Size = new Size(80, 61);
            labelTimer.TabIndex = 2;
            labelTimer.Text = "00:00";
            labelTimer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // panelFill
            // 
            panelFill.Controls.Add(tableLayoutPanel);
            panelFill.Location = new Point(0, 74);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(605, 438);
            panelFill.TabIndex = 3;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(labelTop);
            panelTop.Controls.Add(buttonRules);
            panelTop.Controls.Add(labelTimer);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(10);
            panelTop.Size = new Size(605, 81);
            panelTop.TabIndex = 4;
            // 
            // buttonRules
            // 
            buttonRules.BackColor = Color.FromArgb(35, 34, 73);
            buttonRules.Dock = DockStyle.Left;
            buttonRules.Font = new Font("Segoe UI", 14.25F);
            buttonRules.ForeColor = Color.White;
            buttonRules.Location = new Point(10, 10);
            buttonRules.Name = "buttonRules";
            buttonRules.Size = new Size(119, 61);
            buttonRules.TabIndex = 1;
            buttonRules.Text = "Правила";
            buttonRules.UseVisualStyleBackColor = false;
            buttonRules.Click += buttonRules_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(buttonStart);
            panel3.Controls.Add(buttonExit);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 512);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(10);
            panel3.Size = new Size(605, 84);
            panel3.TabIndex = 5;
            // 
            // buttonStart
            // 
            buttonStart.BackColor = Color.FromArgb(35, 34, 73);
            buttonStart.Font = new Font("Segoe UI", 14.25F);
            buttonStart.ForeColor = Color.White;
            buttonStart.Location = new Point(321, 26);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(209, 45);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "Начать";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.FromArgb(35, 34, 73);
            buttonExit.Font = new Font("Segoe UI", 14.25F);
            buttonExit.ForeColor = Color.White;
            buttonExit.Location = new Point(53, 26);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(209, 45);
            buttonExit.TabIndex = 0;
            buttonExit.Text = "Выход";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // FormMiniGames
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 69, 74);
            ClientSize = new Size(605, 596);
            ControlBox = false;
            Controls.Add(panelTop);
            Controls.Add(panel3);
            Controls.Add(panelFill);
            Name = "FormMiniGames";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMiniGames";
            panelFill.ResumeLayout(false);
            panelTop.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel;
        private Label labelTop;
        private Label labelTimer;
        private Panel panelFill;
        private Panel panelTop;
        private Panel panel3;
        private Button buttonExit;
        private Button buttonRules;
        public System.Windows.Forms.Timer timer;
        private Button buttonStart;
    }
}