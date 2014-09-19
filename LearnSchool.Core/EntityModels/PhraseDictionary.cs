// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PhraseDictionary.cs" company="uni-app">
//   -
// </copyright>
// <summary>
//   -
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace LearnSchool.EntityModels
{
    using System.Collections.Generic;

    using Abp.Domain.Entities;

    public class PhraseDictionary : Entity
    {
        private string _dictionaryName;

        public PhraseDictionary(string dictionaryName)
        {
      
           _dictionaryName = dictionaryName;
        }

        public string DictionaryName { get; set; }
        
        public virtual List<Phrase> Phrases { get; set; }  
    }
}
