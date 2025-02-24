namespace CargoPayAuth.API.CardController
{
    using CargoPayAuth.Application.Handlers;
    using CargoPayAuth.Application.Queries;
    using Microsoft.AspNetCore.Mvc;
    public class PaymentFeeController(PaymentFeeHandle paymentFeeHandle) : ControllerBase
    {
        [HttpPost]
        [Route("api/v1/fee")]
        public async Task<IActionResult> PayCard([FromBody] PaymentFeeQuery query, CancellationToken cancellationToken)
        {
            var response = await paymentFeeHandle.Handle(query, cancellationToken);
            return Ok(response);

        }
    }
}
