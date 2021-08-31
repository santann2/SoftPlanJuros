using System;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Juros.Core.Application.Interface;
using Juros.Core.Domain.Interfaces;
using Juros.Core.Application.AppServices;
using Juros.Core.Domain.Services;

namespace Juros.Core.IoC
{
    public class BootStrapper
    {
        public IServiceProvider ServiceProvider { get; set; }

        public BootStrapper()
        {
            IServiceCollection serviceColletion = new ServiceCollection();

            serviceColletion.AddSingleton((IConfigurationProvider)Application.AutoMapper.AutoMapperConfiguration.RegisterMappings());
            serviceColletion.AddTransient<IMapper>(x => new Mapper(x.GetRequiredService<AutoMapper.IConfigurationProvider>(), x.GetService));

            serviceColletion.AddTransient<ITaxaJurosAppService, TaxaJurosAppService>();
            serviceColletion.AddTransient<ITaxaJurosService, TaxaJurosService>();

            serviceColletion.AddTransient<ICalculaJurosAppService, CalculaJurosAppService>();
            serviceColletion.AddTransient<ICalculoJurosService, CalculoJurosService>();

            ServiceProvider = serviceColletion.BuildServiceProvider();
        }

        public static void RegisterService(IServiceCollection services)
        {
            services.AddSingleton((IConfigurationProvider)Application.AutoMapper.AutoMapperConfiguration.RegisterMappings());

            services.AddTransient<IMapper>(x => new Mapper(x.GetRequiredService<AutoMapper.IConfigurationProvider>(), x.GetService));

            services.AddTransient<ITaxaJurosAppService, TaxaJurosAppService>();
            services.AddTransient<ITaxaJurosService, TaxaJurosService>();

            services.AddTransient<ICalculaJurosAppService, CalculaJurosAppService>();
            services.AddTransient<ICalculoJurosService, CalculoJurosService>();
        }
    }
}
