
namespace RegistryCursorTutorial
{
	partial class Form1
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
			this.label1 = new System.Windows.Forms.Label();
			this.picSelectedCursor = new System.Windows.Forms.PictureBox();
			this.lblCursorPath = new System.Windows.Forms.Label();
			this.btnLoadCursor = new System.Windows.Forms.Button();
			this.btnHoverMe = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.picSelectedCursor)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Cursor:";
			// 
			// picSelectedCursor
			// 
			this.picSelectedCursor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picSelectedCursor.Location = new System.Drawing.Point(402, 38);
			this.picSelectedCursor.Name = "picSelectedCursor";
			this.picSelectedCursor.Size = new System.Drawing.Size(32, 32);
			this.picSelectedCursor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.picSelectedCursor.TabIndex = 1;
			this.picSelectedCursor.TabStop = false;
			// 
			// lblCursorPath
			// 
			this.lblCursorPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblCursorPath.Location = new System.Drawing.Point(63, 11);
			this.lblCursorPath.Name = "lblCursorPath";
			this.lblCursorPath.Size = new System.Drawing.Size(387, 15);
			this.lblCursorPath.TabIndex = 2;
			this.lblCursorPath.Text = "CURSOR_PATH";
			this.lblCursorPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnLoadCursor
			// 
			this.btnLoadCursor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnLoadCursor.Location = new System.Drawing.Point(456, 3);
			this.btnLoadCursor.Name = "btnLoadCursor";
			this.btnLoadCursor.Size = new System.Drawing.Size(79, 31);
			this.btnLoadCursor.TabIndex = 3;
			this.btnLoadCursor.Text = "Load Cursor";
			this.btnLoadCursor.UseVisualStyleBackColor = true;
			this.btnLoadCursor.Click += new System.EventHandler(this.LoadCursor);
			// 
			// btnHoverMe
			// 
			this.btnHoverMe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnHoverMe.Location = new System.Drawing.Point(440, 38);
			this.btnHoverMe.Name = "btnHoverMe";
			this.btnHoverMe.Size = new System.Drawing.Size(95, 33);
			this.btnHoverMe.TabIndex = 4;
			this.btnHoverMe.Text = "Hover Me";
			this.btnHoverMe.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(537, 75);
			this.Controls.Add(this.btnHoverMe);
			this.Controls.Add(this.btnLoadCursor);
			this.Controls.Add(this.picSelectedCursor);
			this.Controls.Add(this.lblCursorPath);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(854, 114);
			this.MinimumSize = new System.Drawing.Size(409, 114);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Registry Cursor Tutorial";
			((System.ComponentModel.ISupportInitialize)(this.picSelectedCursor)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox picSelectedCursor;
		private System.Windows.Forms.Label lblCursorPath;
		private System.Windows.Forms.Button btnLoadCursor;
		private System.Windows.Forms.Button btnHoverMe;
	}
}

