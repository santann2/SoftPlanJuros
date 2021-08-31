using AutoMapper;
using Juros.Core.Application.ViewModels;
using Juros.Core.Domain.Dtos;

namespace Juros.Core.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMapTaxaJuros();
            CreateMapCalculaJuros();
        }

        private void CreateMapTaxaJuros()
        {
            CreateMap<TaxaJurosResponseDto,TaxaJurosResponseViewModel>();
        }
        private void CreateMapCalculaJuros()
        {
            CreateMap<CalculoJurosDto,CalculaJurosViewModel>();
        }
    }
}
