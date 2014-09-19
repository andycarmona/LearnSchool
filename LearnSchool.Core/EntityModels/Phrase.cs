// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Phrase.cs" company="uni-app">
//   -
// </copyright>
// <summary>
//   -
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace LearnSchool.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    using Abp.Domain.Entities;

    public class Phrase : Entity 
    {
        public Phrase()
        {
            this.CreationTime = DateTime.Now;
        }

        [ForeignKey("AssignedDictionaryId")]
        public virtual PhraseDictionary AssignedToDictionary { get; set; }

        public int AssignedDictionaryId { get; set; }

        public string PhraseText { get; set; }

        public DateTime CreationTime { get; set; }

        public List<Word> Words { get; set; }
    }
}
