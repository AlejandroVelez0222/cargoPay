namespace CargoPayAuth.Application.Queries
{
    using CargoPayAuth.Application.DTOs;
    using CargoPayAuth.Application.Queries.Results;
    using MediatR;
    public class PaymentFeeQuery : IRequest<PaymentFeeQueryResponse>
    {
        public PaymentFeeQueryDto? Request { get; set; }
    }
}
