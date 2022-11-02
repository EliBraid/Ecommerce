namespace Ecommerce.Server.Util.Api
{
    public class ApiResult
    {
        public int Code { get; set; }

        public int Msg { get; set; }

        public dynamic Data { get; set; }
    }
}
