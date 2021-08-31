using System;
using System.Collections.Generic;
using System.Text;

namespace Juros.Core.Application.ViewModels
{
    public class TaxaJurosResponseViewModel
    {
        public string Valor { get; set; }
    }

    public class TaxaJurosRequestViewModel
    {
        public decimal Valor { get; set; }
    }
}
