using Microsoft.AspNetCore.Identity;

namespace EQrent___Projekt.Models
{
    public class Rent
    {
        public int Id { get; set; }

        public int ItemId { get; set; }
        public virtual Item? Item { get; set; }

        public string? userId { get; set; }
        public virtual IdentityUser? user { get; set; }

        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
}
