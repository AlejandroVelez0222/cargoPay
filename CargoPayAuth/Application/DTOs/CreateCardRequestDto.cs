namespace CargoPayAuth.Application.DTOs
{
    public class CreateCardRequestDto
    {
        public string? CardNumber { get; set; }
        public string? CardClientName { get; set; }
        public string? CardCVV { get; set; }
        public decimal Balance { get; set; }
    }
}
