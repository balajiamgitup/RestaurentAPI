using System.ComponentModel.DataAnnotations;

namespace JWTAuthenticationWithSwagger.Authentication
{
    public class Order
    {
        public long OrderID { get; set; }
        public string OrderNo { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public string PMethod { get; set; }
        public Nullable<decimal> GTotal { get; set; }
    }
}

