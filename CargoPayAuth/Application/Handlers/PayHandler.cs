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

    public class PayHandler(ICardServices cardServices) : IRequestHandler<PayQuery, QueryResponse<PayResponseDto>>
    {
        public Task<QueryResponse<PayResponseDto>> Handle(PayQuery request, CancellationToken cancellationToken)
        {
            if (request?.Request == null && request?.Request?.CardNumber == null)
            {
                throw new BadRequestException(nameof(ErrorCodes.InvalidRequestCreateCardException));
            }

            bool success = cardServices.Pay(request.Request);
            var result = new ResponseObject<PayResponseDto>();
            if (!success)
            {
                result.Result = true;
                result.Data = new PayResponseDto
                {
                    Success = success,
                    Message = "Pago no realizado. Verifique el saldo o el número de tarjeta o el CVV."
                };
            }
            else
            {
                result.Result = true;
                result.Data = new PayResponseDto
                {
                    Success = success,
                    Message = "Pago realizado con éxito",
                    CardNumber = request?.Request?.CardNumber
                };

            }

            var response = new PayQueryResponse
            {
                Result = result
            };

            return Task.FromResult((QueryResponse<PayResponseDto>)response);
        }
    }
}
