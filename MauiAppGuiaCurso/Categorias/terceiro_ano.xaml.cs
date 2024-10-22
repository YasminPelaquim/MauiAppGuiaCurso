namespace MauiAppGuiaCurso.Categorias;

public partial class Terceiro_ano : ContentPage
{
	public Terceiro_ano()
	{
		InitializeComponent();
	}

    private void btnProgramacaoweb3_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Materias.Programacaoweb3());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private void btnMobile3_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Materias.Mobile3());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private void btnInternet_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Materias.Internet());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private void btnTcc_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Materias.Tcc());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private void btnQualidade_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Materias.Software());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private void btnSistemas_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Materias.Sistemasembarcados());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}