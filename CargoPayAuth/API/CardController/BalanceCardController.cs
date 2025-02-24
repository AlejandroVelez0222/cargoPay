
namespace CargoPayAuth.API.CardController
{
    using CargoPayAuth.Application.Handlers;
    using CargoPayAuth.Application.Queries;
    using Microsoft.AspNetCore.Mvc;
    using System.Web.Http;

    public class BalanceCardController(BalanceCardHandler balanceCardHandler) : ControllerBase
    {
        [Microsoft.AspNetCore.Mvc.HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("api/v1/balanceCard")]
        public async Task<IActionResult> BalanceCard([FromUri] BalanceCardQuery query, CancellationToken cancellationToken)
        {
            var response = await balanceCardHandler.Handle(query, cancellationToken);
            return Ok(response);

        }
    }
}
