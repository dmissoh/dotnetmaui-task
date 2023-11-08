namespace MauiApp4;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Done: {count} time";
        else
            CounterBtn.Text = $"Done: {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }
}