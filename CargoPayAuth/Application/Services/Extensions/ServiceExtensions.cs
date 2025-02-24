namespace CargoPayAuth.Application.Services.Extensions
{
    using CargoPayAuth.Application.Services.Impl;

    public static class ServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddSingleton<ICardServices, CardServices>();
            services.AddSingleton<IPaymentFeeService, PaymentFeeService>();

            return services;
        }
    }
}
