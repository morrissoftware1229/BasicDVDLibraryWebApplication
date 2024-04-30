using System.ComponentModel.DataAnnotations;

namespace BasicDVDLibraryWebApplication.Models
{
    public class DVD
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Genre { get; set; }
        public int Quantity { get; set; }
    }
}
