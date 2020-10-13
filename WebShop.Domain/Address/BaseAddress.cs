namespace WebShop.Domain
{
    public abstract class BaseAddress
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public CountryCode CountryCode { get; set; }
        public string ZipCode { get; set; }
    }
}
