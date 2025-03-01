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
            tableLayoutPanel.Dock = DockStyle.Bottom;
            tableLayoutPanel.ForeColor = Color.Transparent;
            tableLayoutPanel.Location = new Point(0, 93);
            tableLayoutPanel.Margin = new Padding(1);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RightToLeft = RightToLeft.Yes;
            tableLayoutPanel.RowCount = 5;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel.Size = new Size(605, 472);
            tableLayoutPanel.TabIndex = 0;
            // 
            // labelTop
            // 
            labelTop.BackColor = Color.FromArgb(24, 69, 74);
            labelTop.Dock = DockStyle.Left;
            labelTop.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTop.ForeColor = Color.White;
            labelTop.Location = new Point(0, 0);
            labelTop.Name = "labelTop";
            labelTop.Size = new Size(484, 93);
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
            labelTimer.Location = new Point(482, 0);
            labelTimer.Name = "labelTimer";
            labelTimer.Size = new Size(123, 93);
            labelTimer.TabIndex = 2;
            labelTimer.Text = "00:00";
            labelTimer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // FormMiniGames
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(605, 565);
            Controls.Add(labelTimer);
            Controls.Add(labelTop);
            Controls.Add(tableLayoutPanel);
            Name = "FormMiniGames";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMiniGames";
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel;
        private Label labelTop;
        private Label labelTimer;
        private System.Windows.Forms.Timer timer;
    }
}