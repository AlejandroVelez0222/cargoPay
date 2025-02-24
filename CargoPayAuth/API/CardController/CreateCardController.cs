
namespace CargoPayAuth.API.CardController
{
    using CargoPayAuth.Application.Handlers;
    using CargoPayAuth.Application.Queries;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Authorization;


    public class CreateCardController(CreateCardHandler createCardHandler) : ControllerBase
    {
        [Authorize]
        [HttpPost]
        [Route("api/v1/create")]
        public async Task<IActionResult> CreateCard([FromBody] CreateCardQuery query, CancellationToken cancellationToken)
        {
            var response = await createCardHandler.Handle(query, cancellationToken);
            return Ok(response);

        }
    }
}
