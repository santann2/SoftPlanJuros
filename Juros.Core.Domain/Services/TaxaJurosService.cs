using System;
using System.Net;
using Juros.Core.Domain.Dtos;
using Juros.Core.Domain.Interfaces;
using Juros.Core.ExceptionManager;

namespace Juros.Core.Domain.Services
{
    public class TaxaJurosService : ITaxaJurosService
    {
        private readonly Random _random = new Random();

        public TaxaJurosResponseDto GetTaxaJuros()
        {
            try
            {
                //var retorno = _random.Next(1, 3);

                //if (retorno == 1)
                //    return new TaxaJurosResponseDto { Valor = "0.01" };
                //else
                //    return new TaxaJurosResponseDto { Valor = "1%" };

                return new TaxaJurosResponseDto { Valor = "0.01" };

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
