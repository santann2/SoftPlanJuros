using Juros.Core.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Juros.Core.Application.Interface
{
    public interface ICalculaJurosAppService
    {
        public string calculaJuros(CalculaJurosViewModel request);

        public string ShowMeTheCode();
    }
}
