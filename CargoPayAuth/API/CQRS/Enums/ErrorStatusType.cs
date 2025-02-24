namespace CargoPayAuth.API.CQRS.Enums
{
    public enum ErrorStatusType
    {
        Default,
        BadRequest,
        Unauthorized,
        Forbidden,
        NotFound,
        InternalServerError,
        NotImplemented,
        BadGateway,
        GatewayTimeout
    }
}
