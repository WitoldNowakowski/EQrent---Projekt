using Microsoft.AspNetCore.Identity;

namespace EQrent___Projekt.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string? ImageUrl { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }   
        public int Price { get; set; }

        public int ItemTypeId { get; set; }
        public virtual ItemType? ItemType { get; set; }

        public string? userId { get; set; }
        public virtual IdentityUser? user { get; set; }
    }
}
