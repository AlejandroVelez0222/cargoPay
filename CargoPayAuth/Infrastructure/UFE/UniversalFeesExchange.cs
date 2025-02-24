namespace CargoPayAuth.Infrastructure.UFE
{
    public class UniversalFeesExchange
    {
        private static readonly Lazy<UniversalFeesExchange> _instance =
            new Lazy<UniversalFeesExchange>(() => new UniversalFeesExchange());

        private decimal _currentFee = 1.0m; 
        private readonly Random _random = new Random();
        private readonly Timer _timer;

        private UniversalFeesExchange()
        {
            _timer = new Timer(UpdateFee, null, TimeSpan.Zero, TimeSpan.FromHours(1));
        }

        public static UniversalFeesExchange Instance => _instance.Value;

        public decimal GetCurrentFee()
        {
            return _currentFee;
        }

        private void UpdateFee(object? state)
        {
            decimal randomFactor = (decimal)_random.NextDouble() * 2;
            _currentFee *= randomFactor;
        }
    }

}
