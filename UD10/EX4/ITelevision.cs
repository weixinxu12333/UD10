using System;
using System.Collections.Generic;
using System.Text;

namespace UD10
{
    public interface ITelevision : IElectrodomestico
    {
        int Resolucion { get; }
        bool SintonizadorTDT { get; }
    }
}
