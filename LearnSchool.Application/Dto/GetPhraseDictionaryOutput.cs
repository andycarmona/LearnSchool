namespace LearnSchool.Dto
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Abp.Application.Services.Dto;

    public class GetPhraseDictionaryOutput : IOutputDto
    {
        [Required]
        public string DictionaryName { get; set; }

       public virtual List<PhraseDto> Phrases { get; set; }  
    }
}
