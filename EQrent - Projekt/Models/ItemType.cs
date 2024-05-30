using Microsoft.AspNetCore.Identity;

namespace EQrent___Projekt.Models
{
    public class ItemType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? userId { get; set; }
        public virtual IdentityUser? user { get; set; }
    }
}
