namespace FlyoutPageSample;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        //NOT Working, does not show Hamburger icon
        MainPage = new NavigationPage( new AppFlyout());

		//Working, shows Hamburger icon
        //MainPage = new AppFlyout();
    }
}
