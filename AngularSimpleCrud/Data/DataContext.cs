using Microsoft.EntityFrameworkCore;

namespace AngularSimpleCrud.Data
{
    public class DataContext : DbContext
    {
#pragma warning disable
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
#pragma warning restore
        public DbSet<Inspection> Inspections { get; set; }
        public DbSet<InspectionType> InspectionTypes { get; set; }
        public DbSet<Status> Statuss { get; set; }
    }
}
