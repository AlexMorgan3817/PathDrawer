using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using com.jarvisniu.utils;
using System.Windows.Threading;
using System.Threading;
namespace PathDrawer.Windows;

public partial class Mapping : Form
{
	public ScaledBitmap MapImage = new ScaledBitmap(1, 1);
	public int[,]       path     = new int[1, 1];

	private Settings settings    => Program.Settings;

	public Mapping(int mx, int my, int scale = 1)
	{
		InitializeComponent();

		TopMost = settings.TopMostMapping;

		CreateNewBitmap(mx, my, scale);

		SetCurrentPosition(CurrentPosition.Item1, CurrentPosition.Item2);

		keyListener.onPress("W", onPressW);     keyListener.onPress("S", onPressS);
		keyListener.onPress("A", onPressA);     keyListener.onPress("D", onPressD);

		keyListener.onRelease("W", onReleaseW); keyListener.onRelease("S", onReleaseS);
		keyListener.onRelease("A", onReleaseA); keyListener.onRelease("D", onReleaseD);

		MovementLoop.Tick += new EventHandler(MoveWithSleepEvent);
	}

	public void CreateNewBitmap(int _x, int _y, int scale = 1)
	{
		path = new int[_x, _y];
		MapImage = new(_x, _y, scale);

		for(int x = 0; x < MapImage.X; x++)
			for(int y = 0; y < MapImage.Y; y++)
			{
				path[x, y] = 0;
				MapImage.SetPixel(x, y, settings.Nothing);
			}
		UpdateBitmap();
		UpdateUI();
	}

	public void UpdateUI()
	{
		mapBox.SetBounds(0, 0, MapImage.src.Width, MapImage.src.Height);
		SetBounds(Location.X, Location.Y, (int)(MapImage.src.Width * (9f / 8f)), (int)(MapImage.src.Height * (9f / 8f)));
	}

	protected Color Num2Color(int s)
	{
		if(s == 1) return settings.ForeColor;
		if(s == 2) return settings.Current;
		return settings.Nothing;
	}

	public void UpdateBitmap()
	{
		mapBox.Image = MapImage.src;
	}

	public void ChangeScale(int s)
	{
		MapImage = new(MapImage.X, MapImage.Y, s);
		for(int x = 0; x < MapImage.X; x++)
			for(int y = 0; y < MapImage.Y; y++)
				MapImage.SetPixel(x, y, Num2Color(path[x, y]));
		UpdateBitmap();
		UpdateUI();
	}

	#region Movement
	//TODO: Move in new class, that will represent entity moving around

	public  Tuple<int, int> CurrentPosition         = Tuple.Create(0, 0);
	public  Tuple<int, int> MovementDirection       = Tuple.Create(0, 0);
	private KeyListener     keyListener             = new();
	private System.Windows.Forms.Timer MovementLoop = new();
	// 1=W 2=S 3=A 4=D
	//private bool[] buttonsPressed = new bool[4]{false, false, false, false};

	public void SetCurrentPosition(int x, int y)
	{
		x = Math.Clamp(x, 0, MapImage.X - 1);
		y = Math.Clamp(y, 0, MapImage.Y - 1);
		path[x, y] = 2;
		CurrentPosition = Tuple.Create(x, y);
	}

	public void VisualizedSetPosition(int x, int y)
	{
		if(CurrentPosition.Item1 == x && CurrentPosition.Item2 == y)
			return;
		path[CurrentPosition.Item1, CurrentPosition.Item2] = 1;
		MapImage.SetPixel(CurrentPosition.Item1, CurrentPosition.Item2, settings.Step);
		SetCurrentPosition(x, y);
		MapImage.SetPixel(CurrentPosition.Item1, CurrentPosition.Item2, settings.Current);
		UpdateBitmap();
	}
	public void VisualizedChangePosition(int dx, int dy)
		=> VisualizedSetPosition(CurrentPosition.Item1 + dx, CurrentPosition.Item2 + dy);

	private void MoveWithSleepEvent(Object myObject, EventArgs myEventArgs) => MoveWithSleep();
	private void MoveWithSleep()
	{
		if(MovementDirection.Item1 == 0 && MovementDirection.Item2 == 0)
			return;
		VisualizedChangePosition(MovementDirection.Item1, MovementDirection.Item2);
	}

	#region Controls
		private void onPress(int key)
		{
			switch(key)
			{
				case 0: MovementDirection = Tuple.Create(0, -1); break;
				case 1: MovementDirection = Tuple.Create(0,  1); break;
				case 2: MovementDirection = Tuple.Create(-1, 0); break;
				case 3: MovementDirection = Tuple.Create( 1, 0); break;
			}
			if(MovementDirection.Item1 != 0 || MovementDirection.Item2 != 0)
			{
				if(!Program.Settings.TapMovement)
				{
					MovementLoop.Interval = settings.SleepTime;
					if(!MovementLoop.Enabled)
						MovementLoop.Start();
				}
				else
				{
					if(MovementLoop.Enabled)
						MovementLoop.Stop();
					VisualizedChangePosition(MovementDirection.Item1, MovementDirection.Item2);
				}
			}
		}

		private void onPressW()   => onPress(0)  ;
		private void onPressS()   => onPress(1)  ;
		private void onPressA()   => onPress(2)  ;
		private void onPressD()   => onPress(3)  ;

		private void onRelease(int s)
		{
			if(s == 0 || s == 1)
				MovementDirection = Tuple.Create(MovementDirection.Item1, 0);
			if(s == 2 || s == 3)
				MovementDirection = Tuple.Create(0, MovementDirection.Item2);
		}

		private void onReleaseW() => onRelease(0);
		private void onReleaseS() => onRelease(1);
		private void onReleaseA() => onRelease(2);
		private void onReleaseD() => onRelease(3);
	#endregion Controls
	#endregion Movement
}