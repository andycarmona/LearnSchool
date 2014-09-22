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
    using System.Linq;

    using Abp.Application.Services;

    using LearnSchool.Dto;
    using LearnSchool.EntityModels;

    public interface IPhraseDictionaryService : IApplicationService
    {

        PhraseDictionaryDto GetADictionary(int id);
       
        List<PhraseDictionaryDto> GetPhraseDictionaries();

        void UpdatePhraseDictionary(UpdatePhraseDictionaryInput input);

        void CreatePhraseDictionary(CreatePhraseDictionaryInput input);
    }
}
