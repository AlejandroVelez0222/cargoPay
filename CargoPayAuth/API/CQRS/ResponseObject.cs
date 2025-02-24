namespace CargoPayAuth.API.CQRS
{
    public class ResponseObject<T>
    {
        public bool Result { get; set; }

        public T? Data { get; set; }

        public ResponseObject(bool result, T data)
        {
            Result = result;
            Data = data;
        }

        public ResponseObject()
        {
            
        }
    }
}
