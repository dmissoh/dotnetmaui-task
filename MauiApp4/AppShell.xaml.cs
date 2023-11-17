namespace MauiApp4;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        
        Routing.RegisterRoute(nameof(DetailPage), typeof(DetailPage));
    }
}