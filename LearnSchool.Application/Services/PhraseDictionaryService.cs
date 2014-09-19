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

        private readonly IPhraseRepository _phraseRepository;

        private readonly IWordsRepository _wordRepository;

        public PhraseDictionaryService(
            IPhraseRepository phraseRepository,
            IPhraseDictionaryRepository phraseDictionaryRepository,
            IWordsRepository wordRepository)
        {
            _phraseDictionaryRepository = phraseDictionaryRepository;
            _phraseRepository = phraseRepository;
            _wordRepository = wordRepository;
        }

        public GetPhraseDictionaryOutput GetPhraseDictionaries()
        {
            var phraseDictionaries = this._phraseDictionaryRepository.GetAll().ToList();

            return new GetPhraseDictionaryOutput { Phrases = Mapper.Map<List<PhraseDictionaryDto>>(phraseDictionaries) };
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

            var phraseDictionary = new PhraseDictionary(input.DictionaryName);

            _phraseDictionaryRepository.Insert(phraseDictionary);
        }
    }
}
