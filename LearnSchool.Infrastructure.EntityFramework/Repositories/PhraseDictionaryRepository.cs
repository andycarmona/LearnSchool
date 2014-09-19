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

    using LearnSchool.EntityFramework.Repositories;
    using LearnSchool.Interfaces;

    public class PhraseDictionaryRepository : LearnSchoolRepositoryBase<PhraseDictionary>, IPhraseDictionaryRepository
    {
        public List<PhraseDictionary> GetDictionaries()
        {
            throw new System.NotImplementedException();
        }
    }
}
