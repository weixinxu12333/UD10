using System;
using System.Collections.Generic;
using System.Text;

namespace UD10
{
    public class Television : Electrodomestico, ITelevision
    {
        public int Resolucion { get; } = 20;
        public bool SintonizadorTDT { get; } = false;

        public Television(double precioBase, string color, char consumo, double peso, int resolucion, bool sintonizadorTDT) : base(precioBase, color, consumo, peso)
        {
            Resolucion = resolucion;
            SintonizadorTDT = sintonizadorTDT;
        }

        public override double PrecioFinal()
        {
            double precioFinal = base.PrecioFinal();
            if (Resolucion > 40)
                precioFinal += PrecioBase * 0.3;
            if (SintonizadorTDT)
                precioFinal += 50;
            return precioFinal;
        }
    }
}
