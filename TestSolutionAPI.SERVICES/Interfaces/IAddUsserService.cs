using System.Threading.Tasks;
using TestSolutionAPI.MODELS.Loads;

namespace TestSolutionAPI.SERVICES.Interfaces
{
    public interface IAddUsserService
    {
        Task<bool> Add(UsserLoad usser);
    }
}
