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
            panel3 = new Panel();
            button1 = new Button();
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
            labelTop.BackColor = Color.FromArgb(24, 69, 74);
            labelTop.Dock = DockStyle.Left;
            labelTop.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTop.ForeColor = Color.White;
            labelTop.Location = new Point(10, 10);
            labelTop.Name = "labelTop";
            labelTop.Size = new Size(433, 61);
            labelTop.TabIndex = 1;
            labelTop.Text = "Необходимо найти выражение равное ";
            labelTop.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTimer
            // 
            labelTimer.BackColor = Color.FromArgb(24, 69, 74);
            labelTimer.Dock = DockStyle.Right;
            labelTimer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
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
            panelTop.Controls.Add(labelTimer);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(10);
            panelTop.Size = new Size(605, 81);
            panelTop.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Controls.Add(button1);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 512);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(10);
            panel3.Size = new Size(605, 84);
            panel3.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(35, 34, 73);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.White;
            button1.Location = new Point(235, 17);
            button1.Name = "button1";
            button1.Size = new Size(132, 45);
            button1.TabIndex = 0;
            button1.Text = "Выход";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormMiniGames
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 69, 74);
            ClientSize = new Size(605, 596);
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
        private System.Windows.Forms.Timer timer;
        private Panel panelFill;
        private Panel panelTop;
        private Panel panel3;
        private Button button1;
    }
}