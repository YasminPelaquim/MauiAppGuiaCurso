namespace MauiAppGuiaCurso.Categorias;

public partial class Segundo_ano : ContentPage
{
	public Segundo_ano()
	{
		InitializeComponent();
	}

    private void btnMobile1_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Materias.Mobile1());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private void btnBanco2_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Materias.Bancodedados2());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private void btnDs_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Materias.Ds());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private void btnProgramacaoweb2_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Materias.Programacaoweb2());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}