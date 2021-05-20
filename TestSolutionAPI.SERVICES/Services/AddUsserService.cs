using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSolutionAPI.INFRA.Context;
using TestSolutionAPI.MODELS.Entities;
using TestSolutionAPI.MODELS.Loads;
using TestSolutionAPI.SERVICES.Interfaces;

namespace TestSolutionAPI.SERVICES.Services
{
    public class AddUsserService : IAddUsserService
    {
        #region Dependency
        private readonly TestSolutionContext _context;
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public AddUsserService(TestSolutionContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        #endregion

        #region Methods
        public async Task<bool> Add(UsserLoad usser)
        {
            try
            {
                var map = _mapper.Map<UsserInfo>(usser);
                _context.Usser.Add(map);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        #endregion
    }
}
