using Microsoft.AspNetCore.Mvc;
using System;
using Juros.Core.Application.Interface;
using Juros.Core.Application.ViewModels;

namespace Juros.Core.Api.Controllers
{
    public class CalculaJurosController : ControllerBase
    {

        private readonly ICalculaJurosAppService _calculaJurosAppService;

        public CalculaJurosController(ICalculaJurosAppService calculaJurosAppService)
        {
            _calculaJurosAppService = calculaJurosAppService;
        }


        [HttpPost]
        [Route("api/calculaJuros")]
        public IActionResult CalculaJuros(CalculaJurosViewModel request)
        {
            return Ok(_calculaJurosAppService.calculaJuros(request));
        }

        [HttpPost]
        [Route("api/showmethecode")]
        public IActionResult ShowMeTheCode()
        {
            return Ok(_calculaJurosAppService.ShowMeTheCode());
        }
    }
}
