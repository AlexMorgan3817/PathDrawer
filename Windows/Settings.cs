using System.Drawing;
using System.Windows.Forms;

namespace PathDrawer.Windows;

public partial class Settings : Form
{
	//TODO make windows for movement bindings

	public int     SleepTime      = 200; //ms
	public bool    TopMostMapping = false;
	public bool    TapMovement    = false;
	public Color   Nothing = Color.Black,
		           Step = Color.White,
				   Current = Color.Green;
				   //Flag    = Color.Purple,
				   //Deadend = Color.Red;
	public Mapping map      => Program.Mapping         ;
	public int     GetX     => (int)GridX.Value        ;
	public int     GetY     => (int)GridY.Value        ;
	public int     GetScale => (int)MapScaleInput.Value;

	public Settings()
	{
		InitializeComponent();
	}
	#region Controls
	private void MovementDelayInput_ValueChanged(object sender, EventArgs e)
	{
		SleepTime = (int)MovementDelayInput.Value;
	}
	private void MapScaleInput_ValueChanged(object sender, EventArgs e)
	{
		map.ChangeScale(GetScale);
	}
	private void TapMovementCheckbox_CheckedChanged(object sender, EventArgs e)
	{
		TapMovement = TapMovementCheckbox.Checked;
	}
	private void TopMostMappingInput_CheckedChanged(object sender, EventArgs e)
	{
		TopMostMapping = TopMostMappingInput.Checked;
		map.TopMost = TopMostMapping;
	}
	private void GridX_ValueChanged(object sender, EventArgs e)
	{
		GridY.Maximum = GridX.Value;
		StartPosX.Maximum = GridX.Value;
		StartPosY.Maximum = GridX.Value;
	}
	private void apply_Click(object sender, EventArgs e)
	{
		map.CreateNewBitmap(GetX, GetY, GetScale);
		map.SetCurrentPosition((int)StartPosX.Value, (int)StartPosY.Value);
		map.MapImage.SetPixel(map.CurrentPosition.Item1, map.CurrentPosition.Item2, Current);
	}
	#endregion
}