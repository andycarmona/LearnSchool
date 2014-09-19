// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IPhraseRepository.cs" company="uni-app">
//   -
// </copyright>
// <summary>
//   -
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace LearnSchool.Interfaces
{
    using Abp.Domain.Repositories;

    using LearnSchool.EntityModels;

    public interface IPhraseRepository : IRepository<Phrase>
    {
    }
}
