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

    using Abp.Application.Services;

    using LearnSchool.Interfaces;

    public class PhraseDictionaryService : ApplicationService, IPhraseDictionaryService
    {
        private readonly IPhraseDictionaryRepository _phraseDictionaryRepository;

        private readonly IPhraseRepository _phraseRepository;

        private readonly IWordsRepository _wordRepository;

        public PhraseDictionaryService(IPhraseRepository phraseRepository,
                                       IPhraseDictionaryRepository phraseDictionaryRepository,
                                       IWordsRepository wordRepository)
        {
            _phraseDictionaryRepository = phraseDictionaryRepository;
            _phraseRepository = phraseRepository;
            _wordRepository = wordRepository;
        }

        public List<PhraseDictionary> GetPhraseDictionaries()
        {
            throw new System.NotImplementedException();
        }

        public void UpdatePhraseDictionary(int id)
        {
            throw new System.NotImplementedException();
        }

        public void CreatePhraseDictionary()
        {
            throw new System.NotImplementedException();
        }
    }
}
