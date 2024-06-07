namespace MauiAppHotel.views;

public partial class contratasaoHospedagem : ContentPage
{
	App PropriedadesApp;
	public contratasaoHospedagem()
	{
		InitializeComponent();

		PropriedadesApp = (App)Application.Current;

		pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PushAsync(new hospedagemContratada());
		}catch (Exception ex)
		{
			DisplayAlert("ops",ex.Message,"fechar");
		}
    }
}