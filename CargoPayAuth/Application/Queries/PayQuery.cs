namespace CargoPayAuth.Application.Queries
{
    using CargoPayAuth.Application.DTOs;
    using CargoPayAuth.Application.Queries.Results;
    using MediatR;

    public class PayQuery : IRequest<PayQueryResponse>
    {
        public PayQueryDto? Request { get; set; }
    }
}
