using AutoMapper;
using Juros.Core.Application.Interface;
using Juros.Core.Application.ViewModels;
using Juros.Core.Domain.Dtos;
using Juros.Core.Domain.Interfaces;

namespace Juros.Core.Application.AppServices
{
    public class TaxaJurosAppService : ITaxaJurosAppService
    {
        private readonly ITaxaJurosService _taxaJurosService;
        private readonly IMapper _mapper;

        public TaxaJurosAppService(ITaxaJurosService taxaJurosService, IMapper mapper)
        {
            _taxaJurosService = taxaJurosService;
            _mapper = mapper;
        }
        public TaxaJurosResponseViewModel GetTaxaJuros () 
        {
            var retorno = _taxaJurosService.GetTaxaJuros();

            var result = _mapper.Map<TaxaJurosResponseDto, TaxaJurosResponseViewModel>(retorno);

            return result;
        }
    }
}
