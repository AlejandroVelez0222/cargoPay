using CargoPayAuth.API.CQRS;
using CargoPayAuth.Application.DTOs;
using CargoPayAuth.Application.Exceptions;
using CargoPayAuth.Application.Queries;
using CargoPayAuth.Application.Queries.Results;
using CargoPayAuth.Application.Services;
using CargoPayAuth.Domain.Application.Enums;
using MediatR;

namespace CargoPayAuth.Application.Handlers
{
    public class BalanceCardHandler(ICardServices cardServices) : IRequestHandler<BalanceCardQuery, QueryResponse<CardResponseDto>>
    {
        public Task<QueryResponse<CardResponseDto>> Handle(BalanceCardQuery request, CancellationToken cancellationToken)
        {
            if (request?.Request == null && request?.Request?.CardNumber == null)
            {
                throw new BadRequestException(nameof(ErrorCodes.InvalidRequestCreateCardException));
            }

            var newBalanceCard = cardServices.GetCard(request?.Request?.CardNumber);

            if(newBalanceCard == null || String.IsNullOrEmpty(newBalanceCard.CardNumber) )
            {
                throw new BadRequestException(nameof(ErrorCodes.CardNotFoundException));
            }
            var response = new BalanceCardQueryResponse
            {
                Result = new ResponseObject<CardResponseDto>(true, new CardResponseDto
                {
                    CardBalance = newBalanceCard.Balance,
                    CardNumber = newBalanceCard.CardNumber
                })
            };

            return Task.FromResult((QueryResponse<CardResponseDto>)response);
        }
    }
}
