using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProgramowanieObiektoweStorageProject.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        [DisplayName("Volume of 1 item")]
        public double ItemVolume { get; set; }
        [Required]
        [DisplayName("Price of 1 item")]
        public decimal ItemPrice { get; set; }
        [Required]
        [DisplayName("Last modification date")]
        public DateTime LastModificationDate { get; set; }
    }
}
