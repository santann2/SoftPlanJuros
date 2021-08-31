using AutoMapper;
using Juros.Core.Application.Interface;
using Juros.Core.Application.ViewModels;
using Juros.Core.Domain.Dtos;
using Juros.Core.Domain.Interfaces;


namespace Juros.Core.Application.AppServices
{
    public class CalculaJurosAppService : ICalculaJurosAppService
    {
        private readonly ICalculoJurosService _calculaJurosService;
        
        public CalculaJurosAppService(ICalculoJurosService calculaJurosService)
        {
            _calculaJurosService = calculaJurosService;         
        }
        public string calculaJuros(CalculaJurosViewModel request)
        {
            var requestdto = new CalculoJurosDto
            {
                ValorInicial = request.ValorInicial,
                TempoMeses = request.TempoMeses
            };

            return _calculaJurosService.calculaJuros(requestdto);
        }

        public string ShowMeTheCode()
        {
            return _calculaJurosService.ShowMeTheCode();
        }
    }
}
