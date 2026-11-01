using Microsoft.Maui.Controls;

namespace Agenda13.Views
{
    public partial class Sobre : ContentPage
    {
        public Sobre()
        {
            InitializeComponent();
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            // Exemplo: Voltar para a página anterior
            Navigation.PopAsync();
        }
    }
}