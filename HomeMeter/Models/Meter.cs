using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace HomeMeter.Models
{
    public class Meter
    {
        public int Id { get; set; }
        [Range(0, int.MaxValue)]
        public int SerialNumber { get; set; }
        [Range(0, double.MaxValue)]
        public double Readings { get; set; }

        public int HouseId { get; set; }
        public House House { get; set; }
    }
}
