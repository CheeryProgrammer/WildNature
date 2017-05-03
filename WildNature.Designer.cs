namespace WildNature
{
	partial class WildNature
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WildNature));
			this.pbField = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pbField)).BeginInit();
			this.SuspendLayout();
			// 
			// pbField
			// 
			this.pbField.Location = new System.Drawing.Point(12, 12);
			this.pbField.Name = "pbField";
			this.pbField.Size = new System.Drawing.Size(640, 480);
			this.pbField.TabIndex = 0;
			this.pbField.TabStop = false;
			// 
			// WildNature
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(664, 504);
			this.Controls.Add(this.pbField);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "WildNature";
			this.Text = "Wild nature";
			this.Load += new System.EventHandler(this.WildNature_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WildNature_KeyDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.WildNature_KeyUp);
			((System.ComponentModel.ISupportInitialize)(this.pbField)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pbField;
	}
}

