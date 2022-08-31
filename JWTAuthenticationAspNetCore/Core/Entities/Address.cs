using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Address
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        // Configure EF one-to-one relationship between the user and address
        [Required]
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}