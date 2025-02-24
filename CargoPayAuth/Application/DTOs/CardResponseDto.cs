namespace CargoPayAuth.Application.DTOs
{
    public class CardResponseDto
    {
        public string CardNumber { get; set; } = string.Empty;
        public decimal CardBalance { get; set; }
    }
}
