namespace CargoPayAuth.Application.Services.Impl
{
    using CargoPayAuth.Infrastructure.UFE;
    public class PaymentFeeService : IPaymentFeeService
    {
        public async Task<decimal> CalculateFeeAsync(decimal amount)
        {
            return await Task.Run(() =>
            {
                decimal feePercentage = UniversalFeesExchange.Instance.GetCurrentFee();
                return feePercentage; //amount * feePercentage;
            });
        }
    }
}
