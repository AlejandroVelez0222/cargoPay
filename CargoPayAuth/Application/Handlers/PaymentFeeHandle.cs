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

    public class PaymentFeeHandle(IPaymentFeeService paymentFeeService) : IRequestHandler<PaymentFeeQuery, QueryResponse<PaymentResponseDto>>
    {
        public async Task<QueryResponse<PaymentResponseDto>> Handle(PaymentFeeQuery request, CancellationToken cancellationToken)
        {
            if (request?.Request == null || request.Request.Amount <= 0)
            {
                throw new BadRequestException(nameof(ErrorCodes.InvalidRequestCreateCardException));
            }

            var feeResult = await paymentFeeService.CalculateFeeAsync(request?.Request?.Amount ?? 0);


            var response = new PaymentFeeQueryResponse
            {
                Result = new ResponseObject<PaymentResponseDto>(true, new PaymentResponseDto
                {
                    Amount = request?.Request?.Amount ?? 0,
                    Fee = feeResult
                })
            };

            return await Task.FromResult((QueryResponse<PaymentResponseDto>)response);
        }
    }
}
