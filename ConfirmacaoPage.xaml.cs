namespace MauiAppHotel
{
    public partial class ConfirmacaoPage : ContentPage
    {
        public ConfirmacaoPage(Reserva reserva)
        {
            InitializeComponent();

            // Usa BindingContext para vincular o objeto reserva à página
            BindingContext = reserva;

            // Preenche os labels com os dados recebidos via BindingContext
            lbl_nome.Text = reserva.NomeHospede;
            lbl_checkin.Text = reserva.CheckIn.ToString("dd/MM/yyyy");
            lbl_checkout.Text = reserva.CheckOut.ToString("dd/MM/yyyy");
            lbl_quarto.Text = reserva.TipoQuarto;
            lbl_hospedes.Text = reserva.NumHospedes == 1
                ? "1 hóspede"
                : $"{reserva.NumHospedes} hóspedes";
            lbl_diarias.Text = reserva.Diarias == 1
                ? "1 diária"
                : $"{reserva.Diarias} diárias";
        }

        // Volta para a tela principal
        private void Button_Voltar_Clicked(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }
    }
}
