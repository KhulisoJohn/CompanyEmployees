using CompanyEmployees.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CompanyEmployees.API.Controllers
{
    [Route("api/Companies")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private readonly IServiceManager _service;
        public CompaniesController(IServiceManager service) => _service = service;

        [HttpGet]
        public IActionResult GetCompanies()
        {
            try
            {
                var companies = _service.CompanyService.GetAllCompanies(trackChanges: false);
                return Ok(companies);
            }
            catch
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
