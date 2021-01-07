using System;
using System.Collections.Generic;
using System.Text;

namespace UD10
{
    public interface ILavadora : IElectrodomestico
    {
        int Carga { get; }
    }
}
