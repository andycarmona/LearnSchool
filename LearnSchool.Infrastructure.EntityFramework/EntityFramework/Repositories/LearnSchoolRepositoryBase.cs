// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LearnSchoolRepositoryBase.cs" company="uni-app">
//   -
// </copyright>
// <summary>
//   -
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace LearnSchool.EntityFramework.Repositories
{
    using Abp.Domain.Entities;
    using Abp.Domain.Repositories.EntityFramework;

    public abstract class LearnSchoolRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<LearnSchoolDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
    }

    public abstract class LearnSchoolRepositoryBase<TEntity> : LearnSchoolRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
    }
}
