using System.Data.Entity;

namespace Project002.Models
{
    public class MenuContext : DbContext
    {
        public DbSet<Menu> Menus { get; set; }
    }
}
