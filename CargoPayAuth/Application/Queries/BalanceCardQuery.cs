namespace CargoPayAuth.Application.Queries
{
    using CargoPayAuth.Application.DTOs;
    using CargoPayAuth.Application.Queries.Results;
    using MediatR;

    public class BalanceCardQuery : IRequest<BalanceCardQueryResponse>
    {
        public BalanceCardDto? Request { get; set; }
    }
}
