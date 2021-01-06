using System;
using System.Collections.Generic;
using System.Text;

namespace UD10
{
    public interface IEntregable
    {
        // estos son de videojuegos y series
        string titulo { get; set; }
        int temporada { get; set; }
        string genero { get; set; }
        string creador { get; set; }
        //double horasEstimadas { get; set; }
        //string compañia { get; set; }

        string ToString();

        bool entregar();
        bool devolver();
        bool isEntregado();

    }
}
