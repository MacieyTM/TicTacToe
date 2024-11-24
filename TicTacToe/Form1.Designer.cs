namespace TicTacToeGame
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lblPlayer1Score;
        private System.Windows.Forms.Label lblPlayer2Score;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lblPlayer1Score = new System.Windows.Forms.Label();
            this.lblPlayer2Score = new System.Windows.Forms.Label();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();

            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel.AutoSize = true;
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel.WrapContents = false;
            this.flowLayoutPanel.Controls.Add(this.btnStart);
            this.flowLayoutPanel.Controls.Add(this.btnStop);
            this.flowLayoutPanel.Controls.Add(this.btnRestart);
            this.flowLayoutPanel.Controls.Add(this.lblPlayer1Score);
            this.flowLayoutPanel.Controls.Add(this.lblPlayer2Score);

            this.tableLayoutPanel.ColumnCount = 11;
            for (int i = 0; i < 11; i++)
            {
                this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F / 11));
            }
            this.tableLayoutPanel.RowCount = 11;
            for (int i = 0; i < 11; i++)
            {
                this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F / 11));
            }
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.Size = new System.Drawing.Size(800, 800);
            this.tableLayoutPanel.TabIndex = 0;

            this.btnStart.Size = new System.Drawing.Size(75, 30);
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;

            this.btnStop.Size = new System.Drawing.Size(75, 30);
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;

            this.btnRestart.Size = new System.Drawing.Size(75, 30);
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;

            this.lblPlayer1Score.AutoSize = true;
            this.lblPlayer1Score.Location = new System.Drawing.Point(10, 20);
            this.lblPlayer1Score.Name = "lblPlayer1Score";
            this.lblPlayer1Score.Size = new System.Drawing.Size(132, 17);
            this.lblPlayer1Score.TabIndex = 4;
            this.lblPlayer1Score.Text = "Player 1 (X): 0";

            this.lblPlayer2Score.AutoSize = true;
            this.lblPlayer2Score.Location = new System.Drawing.Point(10, 50);
            this.lblPlayer2Score.Name = "lblPlayer2Score";
            this.lblPlayer2Score.Size = new System.Drawing.Size(132, 17);
            this.lblPlayer2Score.TabIndex = 5;
            this.lblPlayer2Score.Text = "Player 2 (O): 0";

            this.ClientSize = new System.Drawing.Size(800, 850);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.flowLayoutPanel);
            this.Name = "MainForm";
            this.Text = "TicTacToe | 2024 \u00A9 M. Grochowski";
            this.ResumeLayout(false);
            this.PerformLayout();

            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
        }
    }
}
