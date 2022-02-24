using CMS.DocumentEngine;
using XperienceAdapter.Models;
using XperienceAdapter.Repositories;
using XperienceAdapter.Services;

namespace Business.Repositories
{
    /// <summary>
    /// Stores pages without page type-specific data (coupled data).
    /// </summary>
    public class BasicPageRepository : BasePageRepository<BasicPage, TreeNode>
    {
        public BasicPageRepository(IRepositoryServices repositoryDependencies) : base(repositoryDependencies)
        {
        }
    }
}
