using Juros.Core.Domain.Dtos;
using Juros.Core.Domain.Interfaces;
using System;
using System.Globalization;

namespace Juros.Core.Domain.Services
{
    public class CalculoJurosService : ICalculoJurosService
    {
        private readonly ITaxaJurosService _taxaJurosService;

        public CalculoJurosService(ITaxaJurosService taxaJurosService)
        {
            _taxaJurosService = taxaJurosService;
        }
        public string calculaJuros(CalculoJurosDto request)
        {
            var vJuros = ValorJuros(request);
            return vJuros.ToString("F");
        }

        public string ShowMeTheCode()
        {
            return "https://github.com/santann2/SoftPlanJuros";
        }

        private decimal ValorJuros (CalculoJurosDto request)
        {
            var TaxaJuros = Convert.ToDecimal(_taxaJurosService.GetTaxaJuros().Valor);            
            var taxaCompostaNoPeriodo = request.ValorInicial * Math.Pow((1 + Convert.ToDouble(TaxaJuros)/100), request.TempoMeses);            
            return Convert.ToDecimal(taxaCompostaNoPeriodo);
        }
    }
}
