namespace WindowsFormsApp5
{
	partial class Form1
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.correctLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.missedLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.totalLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.accuracyLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
			this.difficultyProgressBar = new System.Windows.Forms.ToolStripProgressBar();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 108;
			this.listBox1.Location = new System.Drawing.Point(0, 0);
			this.listBox1.MultiColumn = true;
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(856, 131);
			this.listBox1.TabIndex = 0;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 800;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.correctLabel,
            this.missedLabel,
            this.totalLabel,
            this.accuracyLabel,
            this.toolStripStatusLabel5,
            this.difficultyProgressBar});
			this.statusStrip1.Location = new System.Drawing.Point(0, 109);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(856, 22);
			this.statusStrip1.SizingGrip = false;
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// correctLabel
			// 
			this.correctLabel.Name = "correctLabel";
			this.correctLabel.Size = new System.Drawing.Size(60, 17);
			this.correctLabel.Text = "Correct: 0";
			// 
			// missedLabel
			// 
			this.missedLabel.Name = "missedLabel";
			this.missedLabel.Size = new System.Drawing.Size(58, 17);
			this.missedLabel.Text = "Missed: 0";
			// 
			// totalLabel
			// 
			this.totalLabel.Name = "totalLabel";
			this.totalLabel.Size = new System.Drawing.Size(47, 17);
			this.totalLabel.Text = "Total: 0";
			// 
			// accuracyLabel
			// 
			this.accuracyLabel.Name = "accuracyLabel";
			this.accuracyLabel.Size = new System.Drawing.Size(80, 17);
			this.accuracyLabel.Text = "Accuracy: 0%";
			// 
			// toolStripStatusLabel5
			// 
			this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
			this.toolStripStatusLabel5.Size = new System.Drawing.Size(463, 17);
			this.toolStripStatusLabel5.Spring = true;
			this.toolStripStatusLabel5.Text = "Difficulty";
			this.toolStripStatusLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// difficultyProgressBar
			// 
			this.difficultyProgressBar.Maximum = 701;
			this.difficultyProgressBar.Name = "difficultyProgressBar";
			this.difficultyProgressBar.Size = new System.Drawing.Size(100, 16);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(856, 131);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.listBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "Hit the keys!";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel correctLabel;
		private System.Windows.Forms.ToolStripStatusLabel missedLabel;
		private System.Windows.Forms.ToolStripStatusLabel totalLabel;
		private System.Windows.Forms.ToolStripStatusLabel accuracyLabel;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
		private System.Windows.Forms.ToolStripProgressBar difficultyProgressBar;
	}
}

