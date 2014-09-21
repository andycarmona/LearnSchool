namespace LearnSchool.Dto
{
    using System;
    using System.Collections.Generic;

    using Abp.Application.Services.Dto;

    public class PhraseDto : EntityDto
    {
        public string PhraseText { get; set; }

        public DateTime CreationTime { get; set; }

        public List<WordDto> Words { get; set; }
    }
}
