using System;
using System.Collections.Generic;
using System.Text;

namespace UD10
{
    public interface ISerie: IEntregable
    {
        int Temporada { get; set; }
        string Creador { get; set; }
    }
}
