using System;
using System.Collections.Generic;
using System.Text;

namespace UD10
{
    public interface IElectrodomestico
    {
        double PrecioBase { get; }
        string Color { get; }
        char Consumo { get; }
        double Peso { get; }
        double PrecioFinal();
    }
}
