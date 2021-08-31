using AutoMapper;

namespace Juros.Core.Application.AutoMapper
{
    public class AutoMapperConfiguration
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(mp =>
           {
               mp.AddProfile(new ViewModelToDomainMappingProfile());
               mp.AddProfile(new DomainToViewModelMappingProfile());
           });
        }
    }
}
