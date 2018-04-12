using SampleCoding.DAL.Migrations;
using SampleCoding.DAL.Models;
using System.Data.Entity;

namespace SampleCoding.DAL
{
    public class SampleCodingDBContext : DbContext
    {
        public SampleCodingDBContext() : base("SampleCodingDB")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SampleCodingDBContext, Configuration>("SampleCodingDB"));
        }

        public virtual DbSet<User> Users { get; set; }
    }
}

