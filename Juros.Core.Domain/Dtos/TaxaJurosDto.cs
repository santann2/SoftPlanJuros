
namespace Juros.Core.Domain.Dtos
{
    public class TaxaJurosResponseDto
    {   
        public string Valor { get; set; }
    }

    public class TaxaJurosRequestDto
    {
        public decimal Valor { get; set; }
    }
}
