using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TestSolutionAPI.MODELS.Loads;
using TestSolutionAPI.SERVICES.Interfaces;

namespace TestSolutionAPI.WEB.Controllers.Ussers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddUsserController : ControllerBase
    {
        #region Dependency
        private readonly IAddUsserService _add;
        #endregion

        #region Constructor
        public AddUsserController(IAddUsserService add)
        {
            _add = add;
        }
        #endregion

        #region Methods
        [HttpPost]
        public async Task<IActionResult> Add(UsserLoad usser)
        {
            try
            {
                var result = await _add.Add(usser);
                return result != false ? Ok(result) : (NoContent());
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
        #endregion
    }
}
