namespace CargoPayAuth.Application.Handlers
{
    using CargoPayAuth.API.CQRS;
    using CargoPayAuth.Application.DTOs;
    using CargoPayAuth.Application.Exceptions;
    using CargoPayAuth.Application.Queries;
    using CargoPayAuth.Application.Queries.Results;
    using CargoPayAuth.Application.Services;
    using CargoPayAuth.Domain.Application.Enums;
    using MediatR;

    public class CreateCardHandler(ICardServices cardServices) : IRequestHandler<CreateCardQuery, QueryResponse<CardResponseDto>>
    {
        public Task<QueryResponse<CardResponseDto>> Handle(CreateCardQuery request, CancellationToken cancellationToken)
        {
            if (request?.Request == null)
            {
                throw new BadRequestException(nameof(ErrorCodes.InvalidRequestCreateCardException));
            }

            var newCard = cardServices.CreateCard(request.Request);
            var response = new CreateCardQueryResponse
            {
                Result = new ResponseObject<CardResponseDto>(true, new CardResponseDto
                {
                    CardBalance = newCard.Balance,
                    CardNumber = newCard.CardNumber
                })
            };

            return Task.FromResult((QueryResponse<CardResponseDto>)response);
        }
    }
}
