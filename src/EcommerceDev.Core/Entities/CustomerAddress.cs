namespace EcommerceDev.Core.Entities
{ 
public class CustomerAddress : BaseEntity
    {
        public CustomerAddress(Guid idCustomer, string recipientName, string addressLine1, string? addressLine2, string zipCode, string district, string state, string city, string country)
        {
            IdCustomer = idCustomer;
            RecipientName = recipientName;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            ZipCode = zipCode;
            District = district;
            State = state;
            City = city;
            Country = country;
        }

        public Guid IdCustomer { get; set; }
        public string RecipientName { get; set; } = string.Empty;
        public string AddressLine1 { get; set; } = string.Empty;
        public string? AddressLine2 { get; set; }
        public string ZipCode { get; set; } = string.Empty;
        public string District { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
    }
}