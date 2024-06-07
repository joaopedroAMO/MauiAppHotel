namespace MauiAppHotel.views;

public partial class hospedagemContratada : ContentPage
{
	public hospedagemContratada()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PopAsync();
		}catch (Exception ex)
		{
			DisplayAlert("ops", ex.Message, "fechar");
		}
    }
}