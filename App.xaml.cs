namespace ProjectExpenseTracker_final;

public partial class App : Application
{  
    private readonly MainPage mainPage;
    public App()
    {
        InitializeComponent();

        MainPage = new MainPage();
    }
}