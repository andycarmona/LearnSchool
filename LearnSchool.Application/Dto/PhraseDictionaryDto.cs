// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PhraseDictionaryDto.cs" company="uni-app">
//   -
// </copyright>
// <summary>
//   -
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace LearnSchool.Dto
{
    using System.Collections.Generic;

    using Abp.Application.Services.Dto;

    public class PhraseDictionaryDto : EntityDto
    {
        public string DictionaryName { get; set; }

        public virtual List<PhraseDto> Phrases { get; set; }
    }
}
