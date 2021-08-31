using Microsoft.AspNetCore.Mvc;
using Juros.Core.Application.Interface;
using Juros.Core.Application.ViewModels;

namespace Juros.Core.Api.Controllers
{
    public class TaxaJurosController : ControllerBase
    {
        private readonly ITaxaJurosAppService _taxaJurosAppService;

        public TaxaJurosController (ITaxaJurosAppService taxaJurosAppService)
        {
            _taxaJurosAppService = taxaJurosAppService;
        }

        [HttpPost]
        [Route("api/taxaJuros")]
        public IActionResult TaxaJuros()
        {
            return Ok(_taxaJurosAppService.GetTaxaJuros());
        }
    }
}
