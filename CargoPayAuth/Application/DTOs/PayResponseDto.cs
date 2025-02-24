using Microsoft.EntityFrameworkCore.Query.Internal;

namespace CargoPayAuth.Application.DTOs
{
    public class PayResponseDto
    {
        public bool Success { get; set; }
        public string? Message { get; set; }

        public string? CardNumber { get; set; }
    }
}
