namespace Domain.RegularEntities
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        public virtual IEnumerable<Address> Addresses { get; set; }
            = Enumerable.Empty<Address>();
    }
}
