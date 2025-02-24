using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CargoPayAuth.API.CQRS
{
    public class BaseResponse<T>
    {
        public Error? Error { get; set; }

        public bool Success
        {
            get
            {
                if (Result != null)
                {
                    return Result.Result;
                }

                return false;
            }
        }

        public ResponseObject<T> ? Result { get; set; }
    }
}
