using AutoMapper;
using TestSolutionAPI.MODELS.Entities;
using TestSolutionAPI.MODELS.Loads;

namespace TestSolutionAPI.WEB
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<UsserLoad, UsserInfo>();
        }
    }
}
