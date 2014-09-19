// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WordRepository.cs" company="uni-app">
//   -
// </copyright>
// <summary>
//   -
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace LearnSchool.Repositories
{
    using LearnSchool.EntityFramework.Repositories;
    using LearnSchool.EntityModels;
    using LearnSchool.Interfaces;

    public class WordRepository : LearnSchoolRepositoryBase<Word>, IWordsRepository
    {
    }
}
