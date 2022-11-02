namespace Ecommerce.Shared
{
    public class ServiceResponse<T>
    {
        public T? Data { get; set; }

        public bool Success { get; set; } = true;

        public string Msg { get; set; } = string.Empty;
    }
}
