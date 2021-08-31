using Juros.Core.Domain.Dtos;

namespace Juros.Core.Domain.Interfaces
{
    public interface ICalculoJurosService
    {
        public string calculaJuros(CalculoJurosDto request);

        public string ShowMeTheCode();
    }
}
