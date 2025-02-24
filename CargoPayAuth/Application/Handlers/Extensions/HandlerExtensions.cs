namespace CargoPayAuth.Application.Handlers.Extensions
{
    public static class HandlerExtensions
    {
        public static IServiceCollection AddApplicationHandlers(this IServiceCollection handlers)
        {
            handlers.AddScoped<CreateCardHandler>();
            handlers.AddScoped<BalanceCardHandler>();
            handlers.AddScoped<PayHandler>();
            handlers.AddScoped<PaymentFeeHandle>();

            return handlers;
        }
    }
}
