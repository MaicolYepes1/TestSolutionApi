using Microsoft.EntityFrameworkCore;
using TestSolutionAPI.MODELS.Entities;
namespace TestSolutionAPI.INFRA.Context
{
    public class TestSolutionContext : DbContext
    {
        #region Contructor
        public TestSolutionContext(DbContextOptions<TestSolutionContext> options) : base(options)
        {
        }
        #endregion

        #region DbSets
        public DbSet<UsserInfo> Usser { get; set; }
        #endregion
    }
}
