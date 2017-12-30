using LifeLine.Core;
using System.Data.Entity;

using System.Web.Configuration;

namespace LifeLine.Infrastructure
{
    public class BloodDonorContext : DbContext
    {
        public BloodDonorContext() : base("name=BloodDonorContextConnectionString")
        {
            var a = Database.Connection.ConnectionString;
        }

        public DbSet<BloodDonor> BloodDonors { get; set; }
    }
}