using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace bookwormbackend.Models
{
    public class OrderDetails
    {

        public int Id { get; set; }

        public int bid { get; set; }

        public string purchaseType { get; set; }

        public string? image { get; set; }

        public string? ordered { get; set; }

    }

}
