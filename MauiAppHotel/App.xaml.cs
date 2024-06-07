
using MauiAppHotel.model;

namespace MauiAppHotel
{ 

    public partial class App : Application
    {

        public List<quarto> lista_quartos = new List<quarto>
        {
            new quarto()
            {
                Descrisao = "Suite Super Luxo",
                ValorDiariaAdulto = 100.5,
                ValorDiariaCrianca = 50.5
            },
            new quarto()
            {
                Descrisao = "Suite Luxo",
                ValorDiariaAdulto = 80.5,
                ValorDiariaCrianca = 40.5
            },
            new quarto()
            {
                Descrisao = "Suite Single",
                ValorDiariaAdulto = 50.5,
                ValorDiariaCrianca = 25.5
            },
            new quarto()
            {
                Descrisao = "Suite",
                ValorDiariaAdulto = 25.5,
                ValorDiariaCrianca = 12.5
            }
        };

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
