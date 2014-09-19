// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IPhraseDictionaryService.cs" company="ui-app">
//   -
// </copyright>
// <summary>
//   -
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace LearnSchool.Interfaces
{
    using System.Collections.Generic;

    using Abp.Application.Services;

    public interface IPhraseDictionaryService : IApplicationService
    {
        List<PhraseDictionary> GetPhraseDictionaries();

        void UpdatePhraseDictionary(int id);

        void CreatePhraseDictionary();
    }
}
