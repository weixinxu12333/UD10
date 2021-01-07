using System;
using System.Collections.Generic;
using System.Text;

namespace UD10
{
    public class Cuenta
    {
        public string titular { get; set; }
        public double cantidad { get; set; }

        public Cuenta(string titular)
        {
            this.titular = titular;
        }

        public Cuenta(string titular, double cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public override string ToString() {
            return titular + " " + cantidad;
        }

        public void Ingresar(double cantidad)
        {
            if (cantidad > 0)
                this.cantidad = cantidad;
        }

        public void Retirar(double cantidad)
        {
            if (this.cantidad - cantidad <= 0)
                this.cantidad = 0;
            else if(cantidad > 0)
                this.cantidad -= cantidad;

        }
    }
}
