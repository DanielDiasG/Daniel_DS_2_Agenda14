namespace Agenda13.Views;

public partial class PaginaContratacao : ContentPage
{
    App PropiedadesApp;

    public PaginaContratacao()
    {
        InitializeComponent();
        PropiedadesApp = (App)Application.Current;

        pck_quarto.ItemsSource = PropiedadesApp.lista_quartos;

        dtpck_checkin.MinimumDate = DateTime.Now;
        dtpck_checkin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

        dtpck_checkout.MinimumDate = dtpck_checkin.Date.AddDays(1);
        dtpck_checkout.MaximumDate = dtpck_checkin.Date.AddMonths(6);

    }

    private async void OnButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Sobre());
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new HospedagemContratada());
        }
        catch (Exception ex)
        {
            DisplayAlert("Erro", $"Ocorreu um erro: {ex.Message}", "OK");
        }
    }

    private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
               DatePicker elemento = sender as DatePicker;
        DateTime data_selecionada_checkin = elemento.Date;
        dtpck_checkout.MinimumDate = data_selecionada_checkin.AddDays(1);
        dtpck_checkout.MaximumDate = data_selecionada_checkin.AddMonths(6);
    }

    private void BtnSuites(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Suites());
        }
        catch (Exception ex)
        {
            DisplayAlert("Erro", $"Ocorreu um erro: {ex.Message}", "OK");
        }
    }
}
