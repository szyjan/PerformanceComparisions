namespace Domain.RegularEntities
{
    public class Address
    {
        public int Id { get; set; }
        public string Country { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string StreetName { get; set; } = string.Empty;
        public string Building { get; set; } = string.Empty;
        public string Apartment { get; set; } = string.Empty;
        public virtual IEnumerable<Person> People { get; set; }
            = Enumerable.Empty<Person>();
    }
}
