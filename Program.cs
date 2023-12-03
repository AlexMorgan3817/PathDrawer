using PathDrawer.Windows;

namespace PathDrawer;

internal static class Program
{
	public static Settings Settings;
	public static Mapping Mapping;

	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();

		Application.SetCompatibleTextRenderingDefault(true);
		Application.SetHighDpiMode(HighDpiMode.SystemAware);
		Application.SetDefaultFont(new Font(new FontFamily("Microsoft Sans Serif"), 10f));

		Settings = new Settings();
		Mapping = new Mapping(Settings.GetX, Settings.GetY, Settings.GetScale);

		Application.Run(new MultiFormContext(Settings, Mapping));
	}
}
