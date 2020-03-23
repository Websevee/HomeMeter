namespace HomeMeter.Models
{
    public class House
    {
        public int Id { get; set; }
        
        public string Zip { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }

        public Meter Meter { get; set; }
    }
}
