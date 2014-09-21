namespace LearnSchool.Dto
{
    using System;

    using Abp.Application.Services.Dto;

    public class WordDto : EntityDto
    {
        public string WordName { get; set; }

        public string Image { get; set; }

        public string SoundFile { get; set; }

        public DateTime CreationTime { get; set; }
    }
}
