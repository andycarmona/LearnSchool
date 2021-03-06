﻿// --------------------------------------------------------------------------------------------------------------------
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

        public PhraseDictionaryDto GetADictionary(int id)
        {
            GetMappedEntities();

            var aDictionary = this._phraseDictionaryRepository.Get(id);
            
            var aPDictionary = Mapper.Map<PhraseDictionary, PhraseDictionaryDto>(aDictionary);
           
            return aPDictionary;
        }

       

        public List<PhraseDictionaryDto> GetPhraseDictionaries()
        { 
            GetMappedEntities();

            var phraseDictionaries = this._phraseDictionaryRepository.GetAllList();
            
            var dictionaryList = Mapper.Map<List<PhraseDictionary>, List<PhraseDictionaryDto>>(phraseDictionaries);
            return dictionaryList;
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
            GetMappedEntities();

            var dictionaryEntity = new PhraseDictionary();
            dictionaryEntity = Mapper.Map<CreatePhraseDictionaryInput, PhraseDictionary>(input);
           
            _phraseDictionaryRepository.Insert(dictionaryEntity);
        }

        private static void GetMappedEntities()
        {
            Mapper.CreateMap<CreatePhraseDictionaryInput, PhraseDictionary>()
           .ForMember(c => c.Phrases, option => option.MapFrom(src => src.Phrases));
            Mapper.CreateMap<PhraseDictionary, PhraseDictionaryDto>()
                .ForMember(c => c.Phrases, option => option.MapFrom(src => src.Phrases));
            Mapper.CreateMap<Phrase, PhraseDto>();
            Mapper.CreateMap<Word, WordDto>();
        }
    }
}
