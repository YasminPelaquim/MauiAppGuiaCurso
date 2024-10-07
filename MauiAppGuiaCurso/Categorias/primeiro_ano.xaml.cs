namespace MauiAppGuiaCurso.Categorias;

public partial class Primeiro_ano : ContentPage
{
	public Primeiro_ano()
	{
		InitializeComponent();
	}

    private void btnProgramacaoweb1_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Materias.Programacaoweb1());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private void btnDesigndigital_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Materias.Designdigital());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private void btnAlgoritmo_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Materias.Algoritmo());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private void btnBanco1_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Materias.Bancodados1());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private void btnFundamentos_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Materias.Fundamentos());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private void btnAnalise_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Materias.Analise());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}