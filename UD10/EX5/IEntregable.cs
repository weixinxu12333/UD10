using System;
using System.Collections.Generic;
using System.Text;

namespace UD10
{
    public interface IEntregable : IComparable
    {
        string Titulo { get; set; }
        string Genero { get; set; }

        string ToString();

        bool Entregar();
        bool Devolver();
        bool IsEntregado();

    }
}
