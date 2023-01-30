namespace MauiAppActivatedProblem;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}

    protected override Window CreateWindow(IActivationState activationState)
    {
        System.Diagnostics.Debug.WriteLine("CreateWindow", "CreateWindow");

        Window window = base.CreateWindow(activationState);

        window.Created += (s, e) =>
        {
            System.Diagnostics.Debug.WriteLine("Created", "CreateWindow");
        };

        window.Activated += (s, e) =>
        {
            System.Diagnostics.Debug.WriteLine("Activated", "CreateWindow");
        };

        window.Deactivated += (s, e) =>
        {
            System.Diagnostics.Debug.WriteLine("Deactivated", "CreateWindow");
        };

        return window;
    }

}
