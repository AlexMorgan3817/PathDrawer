namespace PathDrawer.Windows;
partial class Settings
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
		this.label4 = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.Apply = new System.Windows.Forms.Button();
		this.TopMostMappingInput = new System.Windows.Forms.CheckBox();
		this.GridX = new System.Windows.Forms.NumericUpDown();
		this.GridY = new System.Windows.Forms.NumericUpDown();
		this.MapScaleInput = new System.Windows.Forms.NumericUpDown();
		this.label5 = new System.Windows.Forms.Label();
		this.StartPosX = new System.Windows.Forms.NumericUpDown();
		this.StartPosY = new System.Windows.Forms.NumericUpDown();
		this.TapMovementCheckbox = new System.Windows.Forms.CheckBox();
		this.MovementDelayInput = new System.Windows.Forms.NumericUpDown();
		this.label10 = new System.Windows.Forms.Label();
		((System.ComponentModel.ISupportInitialize)(this.GridX)).BeginInit();
		((System.ComponentModel.ISupportInitialize)(this.GridY)).BeginInit();
		((System.ComponentModel.ISupportInitialize)(this.MapScaleInput)).BeginInit();
		((System.ComponentModel.ISupportInitialize)(this.StartPosX)).BeginInit();
		((System.ComponentModel.ISupportInitialize)(this.StartPosY)).BeginInit();
		((System.ComponentModel.ISupportInitialize)(this.MovementDelayInput)).BeginInit();
		this.SuspendLayout();
		// 
		// label4
		// 
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(89, 85);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(17, 20);
		this.label4.TabIndex = 18;
		this.label4.Text = "Y";
		// 
		// label3
		// 
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(25, 85);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(18, 20);
		this.label3.TabIndex = 17;
		this.label3.Text = "X";
		// 
		// label2
		// 
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(129, 62);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(147, 20);
		this.label2.TabIndex = 16;
		this.label2.Text = "Grid maxX and maxY";
		this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		// 
		// label1
		// 
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(129, 19);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(87, 20);
		this.label1.TabIndex = 13;
		this.label1.Text = "Starting Pos";
		this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		// 
		// Apply
		// 
		this.Apply.FlatAppearance.BorderColor = System.Drawing.Color.Black;
		this.Apply.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Apply.Location = new System.Drawing.Point(12, 108);
		this.Apply.Name = "Apply";
		this.Apply.Size = new System.Drawing.Size(94, 29);
		this.Apply.TabIndex = 19;
		this.Apply.Text = "Apply";
		this.Apply.UseVisualStyleBackColor = true;
		this.Apply.Click += new System.EventHandler(this.apply_Click);
		// 
		// TopMostMappingInput
		// 
		this.TopMostMappingInput.AutoSize = true;
		this.TopMostMappingInput.Location = new System.Drawing.Point(12, 239);
		this.TopMostMappingInput.Name = "TopMostMappingInput";
		this.TopMostMappingInput.Size = new System.Drawing.Size(182, 24);
		this.TopMostMappingInput.TabIndex = 20;
		this.TopMostMappingInput.Text = "Topmost Map Window";
		this.TopMostMappingInput.UseVisualStyleBackColor = true;
		this.TopMostMappingInput.CheckedChanged += new System.EventHandler(this.TopMostMappingInput_CheckedChanged);
		// 
		// GridX
		// 
		this.GridX.Location = new System.Drawing.Point(12, 55);
		this.GridX.Maximum = new decimal(new int[] {
		400,
		0,
		0,
		0});
		this.GridX.Name = "GridX";
		this.GridX.Size = new System.Drawing.Size(53, 27);
		this.GridX.TabIndex = 21;
		this.GridX.Value = new decimal(new int[] {
		200,
		0,
		0,
		0});
		this.GridX.ValueChanged += new System.EventHandler(this.GridX_ValueChanged);
		// 
		// GridY
		// 
		this.GridY.Location = new System.Drawing.Point(70, 55);
		this.GridY.Maximum = new decimal(new int[] {
		400,
		0,
		0,
		0});
		this.GridY.Name = "GridY";
		this.GridY.Size = new System.Drawing.Size(53, 27);
		this.GridY.TabIndex = 22;
		this.GridY.Value = new decimal(new int[] {
		200,
		0,
		0,
		0});
		// 
		// MapScaleInput
		// 
		this.MapScaleInput.Location = new System.Drawing.Point(12, 143);
		this.MapScaleInput.Name = "MapScaleInput";
		this.MapScaleInput.Size = new System.Drawing.Size(111, 27);
		this.MapScaleInput.TabIndex = 23;
		this.MapScaleInput.Value = new decimal(new int[] {
		4,
		0,
		0,
		0});
		this.MapScaleInput.ValueChanged += new System.EventHandler(this.MapScaleInput_ValueChanged);
		// 
		// label5
		// 
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(129, 150);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(74, 20);
		this.label5.TabIndex = 24;
		this.label5.Text = "MapScale";
		// 
		// StartPosX
		// 
		this.StartPosX.Location = new System.Drawing.Point(12, 19);
		this.StartPosX.Maximum = new decimal(new int[] {
		200,
		0,
		0,
		0});
		this.StartPosX.Name = "StartPosX";
		this.StartPosX.Size = new System.Drawing.Size(53, 27);
		this.StartPosX.TabIndex = 25;
		this.StartPosX.Value = new decimal(new int[] {
		50,
		0,
		0,
		0});
		// 
		// StartPosY
		// 
		this.StartPosY.Location = new System.Drawing.Point(70, 19);
		this.StartPosY.Maximum = new decimal(new int[] {
		200,
		0,
		0,
		0});
		this.StartPosY.Name = "StartPosY";
		this.StartPosY.Size = new System.Drawing.Size(53, 27);
		this.StartPosY.TabIndex = 26;
		this.StartPosY.Value = new decimal(new int[] {
		50,
		0,
		0,
		0});
		// 
		// TapMovementCheckbox
		// 
		this.TapMovementCheckbox.AutoSize = true;
		this.TapMovementCheckbox.Location = new System.Drawing.Point(12, 209);
		this.TapMovementCheckbox.Name = "TapMovementCheckbox";
		this.TapMovementCheckbox.Size = new System.Drawing.Size(129, 24);
		this.TapMovementCheckbox.TabIndex = 27;
		this.TapMovementCheckbox.Text = "Tap Movement";
		this.TapMovementCheckbox.UseVisualStyleBackColor = true;
		this.TapMovementCheckbox.CheckedChanged += new System.EventHandler(this.TapMovementCheckbox_CheckedChanged);
		// 
		// MovementDelayInput
		// 
		this.MovementDelayInput.Location = new System.Drawing.Point(12, 176);
		this.MovementDelayInput.Maximum = new decimal(new int[] {
		1000,
		0,
		0,
		0});
		this.MovementDelayInput.Name = "MovementDelayInput";
		this.MovementDelayInput.Size = new System.Drawing.Size(53, 27);
		this.MovementDelayInput.TabIndex = 28;
		this.MovementDelayInput.Value = new decimal(new int[] {
		160,
		0,
		0,
		0});
		this.MovementDelayInput.ValueChanged += new System.EventHandler(this.MovementDelayInput_ValueChanged);
		// 
		// label10
		// 
		this.label10.AutoSize = true;
		this.label10.Location = new System.Drawing.Point(129, 183);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(122, 20);
		this.label10.TabIndex = 29;
		this.label10.Text = "Movement Delay";
		// 
		// Settings
		// 
		this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.ClientSize = new System.Drawing.Size(280, 312);
		this.Controls.Add(this.label10);
		this.Controls.Add(this.MovementDelayInput);
		this.Controls.Add(this.TapMovementCheckbox);
		this.Controls.Add(this.StartPosY);
		this.Controls.Add(this.StartPosX);
		this.Controls.Add(this.label5);
		this.Controls.Add(this.MapScaleInput);
		this.Controls.Add(this.GridY);
		this.Controls.Add(this.GridX);
		this.Controls.Add(this.TopMostMappingInput);
		this.Controls.Add(this.Apply);
		this.Controls.Add(this.label4);
		this.Controls.Add(this.label3);
		this.Controls.Add(this.label2);
		this.Controls.Add(this.label1);
		this.Name = "Settings";
		this.Text = "Settings";
		((System.ComponentModel.ISupportInitialize)(this.GridX)).EndInit();
		((System.ComponentModel.ISupportInitialize)(this.GridY)).EndInit();
		((System.ComponentModel.ISupportInitialize)(this.MapScaleInput)).EndInit();
		((System.ComponentModel.ISupportInitialize)(this.StartPosX)).EndInit();
		((System.ComponentModel.ISupportInitialize)(this.StartPosY)).EndInit();
		((System.ComponentModel.ISupportInitialize)(this.MovementDelayInput)).EndInit();
		this.ResumeLayout(false);
		this.PerformLayout();

	}

	#endregion

	private Label label4;
	private Label label3;
	private Label label2;
	private Label label1;
	private Button Apply;
	private CheckBox TopMostMappingInput;
	private NumericUpDown GridX;
	private NumericUpDown GridY;
	private NumericUpDown MapScaleInput;
	private Label label5;
	private NumericUpDown StartPosX;
	private NumericUpDown StartPosY;
	private CheckBox TapMovementCheckbox;
	private NumericUpDown MovementDelayInput;
	private Label label10;
}