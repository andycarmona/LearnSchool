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
        public string DictionaryName { get; set; }
        
        public virtual List<Phrase> Phrases { get; set; }  
    }
}
