namespace BreakingBad;

public partial class AppFlyoutPage : FlyoutPage
{
    public AppFlyoutPage()
    {
        InitializeComponent();

        Detail = new NavigationPage(new MainPage());
    }

    private void OnWalterClicked(object sender, EventArgs e)
    {
        Detail = new NavigationPage(new WalterWhite());
        IsPresented = false;
    }

    private void OnJesseClicked(object sender, EventArgs e)
    {
        Detail = new NavigationPage(new JessePinkman());
        IsPresented = false;
    }

    private void OnSaulClicked(object sender, EventArgs e)
    {
        Detail = new NavigationPage(new SaulGoodman());
        IsPresented = false;
    }

    private void OnMikeClicked(object sender, EventArgs e)
    {
        Detail = new NavigationPage(new MikeEhrmantraut());
        IsPresented = false;
    }
}