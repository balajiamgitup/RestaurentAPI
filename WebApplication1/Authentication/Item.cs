using System.ComponentModel.DataAnnotations;

namespace JWTAuthenticationWithSwagger.Authentication
{
    public class Item
    {
        public int ItemID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}

