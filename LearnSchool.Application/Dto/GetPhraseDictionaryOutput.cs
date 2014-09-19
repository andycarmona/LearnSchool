namespace LearnSchool.Dto
{
    using System.Collections.Generic;

    using Abp.Application.Services.Dto;

   public class GetPhraseDictionaryOutput : IOutputDto
    {
       public virtual List<PhraseDictionaryDto> Phrases { get; set; }  
    }
}
