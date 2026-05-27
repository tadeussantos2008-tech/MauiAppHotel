namespace MauiAppHotel
{
    // Classe que representa uma reserva de hotel
    public class Reserva
    {
        public string NomeHospede { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public string TipoQuarto { get; set; }
        public int NumHospedes { get; set; }
        public int Diarias { get; set; }
    }
}
