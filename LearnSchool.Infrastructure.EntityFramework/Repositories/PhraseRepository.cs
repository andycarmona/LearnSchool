// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PhraseRepository.cs" company="uni-app">
//   -
// </copyright>
// <summary>
//   -
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace LearnSchool.Repositories
{
    using LearnSchool.EntityFramework.Repositories;
    using LearnSchool.Interfaces;

    public class PhraseRepository : LearnSchoolRepositoryBase<Phrase>, IPhraseRepository
    {
    }
}
