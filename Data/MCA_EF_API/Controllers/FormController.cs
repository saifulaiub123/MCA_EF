using MCA_EF.Core.Interface.IService;
using MCA_EF.Core.Model;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace MCA_EF_API.Controllers
{
    public class FormController : BaseController
    {
        private readonly IFormService _formService;
        public FormController(IFormService formService)
        {
            _formService = formService;
        }

        [HttpGet]
        [Route("GetAll")]
        [SwaggerResponse(StatusCodes.Status200OK, "Return all forms", typeof(List<FormViewModel>))]
        public async Task<ActionResult> GetAll()
        {
            var result = await _formService.GetAll();
            return Ok(result);
        }
    }
}
