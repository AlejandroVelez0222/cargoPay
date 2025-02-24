namespace CargoPayAuth.Domain.Application.Models
{
    public class Card
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string CardNumber { get; set; } = string.Empty; // 15 dígitos
        public string CardClientName {  get; set; } = string.Empty;
        public string CardType { get; set; } = string.Empty ;
        public string CardCVV {  get; set; } = string.Empty ;
        public decimal Balance { get; set; } = 0;
    }
}
