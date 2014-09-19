using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Abp.Domain.Entities;
using Abp.Domain.Repositories.EntityFramework;

namespace LearnSchool.EntityFramework.Repositories
{
    public abstract class LearnSchoolRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<LearnSchoolDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
    }

    public abstract class LearnSchoolRepositoryBase<TEntity> : LearnSchoolRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {

    }
}
