namespace MauiAppHotel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // Define a data mínima de checkout como amanhã
            dp_checkin.Date = DateTime.Today;
            dp_checkout.Date = DateTime.Today.AddDays(1);
        }

        // Atualiza o label quando o Stepper muda
        private void OnStepperValueChanged(object sender, ValueChangedEventArgs e)
        {
            int valor = (int)e.NewValue;
            lbl_hospedes.Text = valor == 1 ? "1 hóspede" : $"{valor} hóspedes";
        }

        // Confirma a reserva
        private void Button_Reservar_Clicked(object sender, EventArgs e)
        {
            try
            {
                // Valida nome
                if (string.IsNullOrWhiteSpace(txt_nome.Text))
                {
                    DisplayAlert("Atenção", "Por favor, informe o nome do hóspede.", "OK");
                    return;
                }

                // Valida tipo de quarto
                if (pk_quarto.SelectedIndex == -1)
                {
                    DisplayAlert("Atenção", "Por favor, selecione o tipo de quarto.", "OK");
                    return;
                }

                // Valida datas
                if (dp_checkout.Date <= dp_checkin.Date)
                {
                    DisplayAlert("Atenção", "A data de check-out deve ser posterior ao check-in.", "OK");
                    return;
                }

                // Calcula número de diárias
                int diarias = (dp_checkout.Date - dp_checkin.Date).Days;
                string quarto = pk_quarto.SelectedItem.ToString();
                int hospedes = (int)stp_hospedes.Value;

                // Cria objeto de reserva e passa para a tela de confirmação
                var reserva = new Reserva
                {
                    NomeHospede = txt_nome.Text,
                    CheckIn = dp_checkin.Date,
                    CheckOut = dp_checkout.Date,
                    TipoQuarto = quarto,
                    NumHospedes = hospedes,
                    Diarias = diarias
                };

                Navigation.PushAsync(new ConfirmacaoPage(reserva));
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Fechar");
            }
        }

        // Navega para a tela Sobre
        private void Button_Sobre_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SobrePage());
        }
    }
}
