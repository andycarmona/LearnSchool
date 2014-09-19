using System.Data.Entity;
using Abp.Domain.Repositories.EntityFramework;

namespace LearnSchool.EntityFramework
{
    public class LearnSchoolDbContext : AbpDbContext
    {
        //TODO: Define an IDbSet for each Entity...

        //public virtual IDbSet<Person> People { get; set; } //Sample

        public LearnSchoolDbContext()
            : base("MainDb")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //TODO: Make additional model setup...

            //modelBuilder.Entity<Person>().ToTable("TsPeople"); //Sample
        }
    }
}
