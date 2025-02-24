namespace CargoPayAuth.Application.Services
{
    public interface IPaymentFeeService
    {
        public Task<decimal> CalculateFeeAsync(decimal amount);
    }
}
