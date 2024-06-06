namespace MauiAppHotel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new views.contratasaoHospedagem());
        }

        protected override Window CreateWindow(IActivationState ActivationState)
        {
            var window = base.CreateWindow(ActivationState);

            window.Width = 400;
            window.Height = 700;

            return window;
        }
    }
}
