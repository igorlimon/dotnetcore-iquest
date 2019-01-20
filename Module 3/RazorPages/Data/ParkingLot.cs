using System.ComponentModel.DataAnnotations;

namespace RazorPages.Data
{
    public class ParkingLot
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Number { get; set; }
    }
}