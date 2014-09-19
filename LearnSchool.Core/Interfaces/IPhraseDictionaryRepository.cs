// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IPhraseDictionaryRepository.cs" company="uni-app">
//   -
// </copyright>
// <summary>
//   -
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace LearnSchool.Interfaces
{
    using System.Collections.Generic;

    using Abp.Domain.Repositories;

    using LearnSchool.EntityModels;

    public interface IPhraseDictionaryRepository : IRepository<PhraseDictionary>
    {
        List<PhraseDictionary> GetDictionaries();
    }
}
