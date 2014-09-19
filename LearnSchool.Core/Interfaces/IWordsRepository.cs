namespace LearnSchool.Interfaces
{
    using Abp.Domain.Repositories;

    using LearnSchool.EntityModels;

    public interface IWordsRepository : IRepository<Word>
    {
    }
}
