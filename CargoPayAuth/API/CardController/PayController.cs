
namespace CargoPayAuth.API.CardController
{
    using CargoPayAuth.Application.Handlers;
    using CargoPayAuth.Application.Queries;
    using Microsoft.AspNetCore.Mvc;

    public class PayController(PayHandler payHandler) : ControllerBase
    {
        [HttpPost]
        [Route("api/v1/Pay")]
        public async Task<IActionResult> PayCard([FromBody] PayQuery query, CancellationToken cancellationToken)
        {
            var response = await payHandler.Handle(query, cancellationToken);
            return Ok(response);

        }
    }
}
