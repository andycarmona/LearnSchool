// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LearnSchoolDbContext.cs" company="Uni-app">
//   -
// </copyright>
// <summary>
//   -
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace LearnSchool.EntityFramework
{
    using System.Data.Entity;

    using Abp.Domain.Repositories.EntityFramework;

    public class LearnSchoolDbContext : AbpDbContext
    {
        public LearnSchoolDbContext()
            : base("MainDb")
        {
        }

        public virtual IDbSet<Word> Words { get; set; }

        public virtual IDbSet<Phrase> Phrases { get; set; }

        public virtual IDbSet<PhraseDictionary> PhraseDictionaries { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Word>().ToTable("Words");
            modelBuilder.Entity<Phrase>().ToTable("Phrases");
            modelBuilder.Entity<PhraseDictionary>().ToTable("PhraseDictionary");
        }
    }
}
