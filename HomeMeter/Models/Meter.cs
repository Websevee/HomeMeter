using System.ComponentModel.DataAnnotations;

namespace HomeMeter.Models
{
    public class Meter
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public double Readings { get; set; }

        public int HouseId { get; set; }
        public House House { get; set; }
    }
}
