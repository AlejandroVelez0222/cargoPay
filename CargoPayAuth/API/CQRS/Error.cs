namespace CargoPayAuth.API.CQRS
{
    public class Error
    {

        public Exception? Exception { private get; set; }

        public string Code
        {
            get
            {
                if (Exception == null)
                {
                    return string.Empty;
                }

                if (Exception.GetType().IsSubclassOf(typeof(Exception)))
                {
                    return Exception.HResult.ToString();
                }

                if (Exception?.InnerException != null && Exception.InnerException.GetType().IsSubclassOf(typeof(Exception)))
                {
                    return (Exception.InnerException).HResult.ToString();
                }

                return Exception?.Source != null ? Exception.Source: string.Empty;
            }
        }
        public Error()
        {

        }
        public Error(Exception ex)
        {
            Exception = ex;
        }
    }
}
