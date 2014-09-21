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

    using LearnSchool.Dto;

    public interface IPhraseDictionaryService : IApplicationService
    {

        GetPhraseDictionaryOutput GetADictionary(int id);
       
        List<GetPhraseDictionaryOutput> GetPhraseDictionaries();

        void UpdatePhraseDictionary(UpdatePhraseDictionaryInput input);

        void CreatePhraseDictionary(CreatePhraseDictionaryInput input);
    }
}
