namespace TenkUpgraderv2
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
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.tenkPathTxtBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(94, 101);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(96, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Lancer";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(139, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Repertoire à décompiler :";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 72);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(256, 23);
			this.textBox1.TabIndex = 1;
			// 
			// progressBar
			// 
			this.progressBar.Location = new System.Drawing.Point(12, 130);
			this.progressBar.Maximum = 800;
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(256, 23);
			this.progressBar.Step = 1;
			this.progressBar.TabIndex = 3;
			// 
			// tenkPathTxtBox
			// 
			this.tenkPathTxtBox.Location = new System.Drawing.Point(12, 27);
			this.tenkPathTxtBox.Name = "tenkPathTxtBox";
			this.tenkPathTxtBox.Size = new System.Drawing.Size(256, 23);
			this.tenkPathTxtBox.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(133, 15);
			this.label2.TabIndex = 4;
			this.label2.Text = "Chemin d\'accès à Tenk :";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(280, 159);
			this.Controls.Add(this.tenkPathTxtBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.progressBar);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TenkUpgrader v2";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Button button1;
		private Label label1;
		private TextBox textBox1;
		public ProgressBar progressBar;
		private TextBox tenkPathTxtBox;
		private Label label2;
	}
}