using AutoMapper;
using Juros.Core.Application.ViewModels;
using Juros.Core.Domain.Dtos;

namespace Juros.Core.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMapTaxaJuros();
            CreateMapCalculaJuros();
        }

        private void CreateMapTaxaJuros()
        {
            CreateMap<TaxaJurosResponseViewModel,TaxaJurosResponseDto>();
        }
        private void CreateMapCalculaJuros()
        {
            CreateMap<CalculaJurosViewModel,CalculoJurosDto>();
        }
    }
}
