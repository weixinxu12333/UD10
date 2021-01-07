using System;
using System.Collections.Generic;
using System.Text;

namespace UD10
{
    public interface IVideojuego: IEntregable
    {
        double HorasEstimadas { get; set; }
        string Compañia { get; set; }
    }
}
