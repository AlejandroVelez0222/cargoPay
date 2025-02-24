namespace CargoPayAuth.Application.Queries
{
    using CargoPayAuth.Application.DTOs;
    using CargoPayAuth.Application.Queries.Results;
    using MediatR;
    public class CreateCardQuery : IRequest<CreateCardQueryResponse>
    {
        public CreateCardRequestDto? Request { get; set; }
    }
}
