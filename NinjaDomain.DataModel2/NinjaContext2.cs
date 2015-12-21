using NinjaDomain.Classes;
using System.Data.Entity;

namespace NinjaDomain.DataModel2
{
    public class NinjaContext2 : DbContext
    {

        public DbSet<Ninja> Ninjas { get; set; }
        public DbSet<Clan> Clans { get; set; }
        public DbSet<NinjaEquipment> Equipment { get; set; }
    }
}
