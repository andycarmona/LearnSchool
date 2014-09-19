// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Word.cs" company="Uni-App">
//   -
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace LearnSchool.EntityModels
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    using Abp.Domain.Entities;

    public class Word : Entity
    { 
        public Word()
        {
            this.CreationTime = DateTime.Now;
        }

        public string WordName { get; set; }

        public string Image { get; set; }

        public string SoundFile { get; set; }

        public DateTime CreationTime { get; set; }

        [ForeignKey("AssignedPhraseId")]
        public virtual Phrase AssignedToPhrase { get; set; }

        public int AssignedPhraseId { get; set; }
    }
}