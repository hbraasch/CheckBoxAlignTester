namespace CheckBoxAlignTester;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new StartupPage()) { BarBackgroundColor = Colors.Grey, BarTextColor = Colors.Black }; ;
	}
}
