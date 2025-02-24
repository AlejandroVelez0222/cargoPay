namespace CargoPayAuth.Application.DTOs
{
    public class PayQueryDto
    {
        public string? CardNumber { get; set; }
        public string? CardCVV { get; set; }
        public decimal Amount { get; set; }
    }
}
