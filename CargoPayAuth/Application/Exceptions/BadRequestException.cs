namespace CargoPayAuth.Application.Exceptions
{
    using CargoPayAuth.API.CQRS.Enums;

    public class BadRequestException : Exception
    {
        public string ErrorCode { get; }

        public  int ErrorStatusCode => 400;

        public ErrorStatusType ErrorStatus => ErrorStatusType.BadRequest;

        public BadRequestException()
            : this("BadRequestException")
        {
        }

        public BadRequestException(string errorCode)
            : base(errorCode)
        {
            ErrorCode = errorCode;
        }
    }


}
