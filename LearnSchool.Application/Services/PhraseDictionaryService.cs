// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PhraseDictionaryService.cs" company="uni-app">
//   -
// </copyright>
// <summary>
//   -
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace LearnSchool.Services
{
    using System.Collections.Generic;
    using System.Linq;

    using Abp.Application.Services;

    using AutoMapper;

    using LearnSchool.Dto;
    using LearnSchool.EntityModels;
    using LearnSchool.Interfaces;

    public class PhraseDictionaryService : ApplicationService, IPhraseDictionaryService
    {
        private readonly IPhraseDictionaryRepository _phraseDictionaryRepository;

        public PhraseDictionaryService(IPhraseDictionaryRepository phraseDictionaryRepository)
        {
            _phraseDictionaryRepository = phraseDictionaryRepository;
        }

        public GetPhraseDictionaryOutput GetADictionary(int id)
        {
            var aDictionary = this._phraseDictionaryRepository.Get(id);
            var dictionaryDto = Mapper.Map<GetPhraseDictionaryOutput>(aDictionary);
            return dictionaryDto;
        }

        public List<GetPhraseDictionaryOutput> GetPhraseDictionaries()
        {
            var phraseDictionaries = this._phraseDictionaryRepository.GetDictionaries();
            var aListOfDictionaries = Mapper.Map<List<GetPhraseDictionaryOutput>>(phraseDictionaries);
            return aListOfDictionaries;
        }

        public void UpdatePhraseDictionary(UpdatePhraseDictionaryInput input)
        { 
            Logger.Info("Updating a dictionary for input: " + input);

            var phraseDictionary = _phraseDictionaryRepository.Get(input.DictionaryId);

            phraseDictionary.DictionaryName = input.DictionaryName;
        }

        public void CreatePhraseDictionary(CreatePhraseDictionaryInput input)
        {
            Logger.Info("Creating a new dictionary: " + input);

            var phraseDictionary = new PhraseDictionary();

            _phraseDictionaryRepository.Insert(phraseDictionary);
        }
    }
}
