namespace PathDrawer.Windows
{
	partial class Mapping
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
			this.mapBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.mapBox)).BeginInit();
			this.SuspendLayout();
			// 
			// mapBox
			// 
			this.mapBox.Location = new System.Drawing.Point(0, 0);
			this.mapBox.Name = "mapBox";
			this.mapBox.Size = new System.Drawing.Size(60, 60);
			this.mapBox.TabIndex = 0;
			this.mapBox.TabStop = false;
			// 
			// Mapping
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			this.ClientSize = new System.Drawing.Size(282, 253);
			this.Controls.Add(this.mapBox);
			this.Name = "Mapping";
			this.Text = "Mapping";
			((System.ComponentModel.ISupportInitialize)(this.mapBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private PictureBox mapBox;
	}
}