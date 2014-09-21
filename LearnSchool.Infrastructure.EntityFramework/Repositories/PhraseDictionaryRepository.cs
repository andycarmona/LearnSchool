// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PhraseDictionaryRepository.cs" company="uni-app">
//   -
// </copyright>
// <summary>
//   -
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace LearnSchool.Repositories
{
    using System.Collections.Generic;
    using System.Linq;

    using LearnSchool.EntityFramework.Repositories;
    using LearnSchool.EntityModels;
    using LearnSchool.Interfaces;

    public class PhraseDictionaryRepository : LearnSchoolRepositoryBase<PhraseDictionary, int>, IPhraseDictionaryRepository
    {
        public List<PhraseDictionary> GetDictionaries()
        {
            var query = this.GetAll();
            return query.ToList();
        }
    }
}
