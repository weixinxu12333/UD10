using System.Linq;

namespace UD10
{
    public class Electrodomestico : IElectrodomestico
    {
        public const double PRECIO_BASE = 100;
        public const string COLOR = "BLANCO";
        public const char CONSUMO = 'F';
        public const double PESO = 5;

        private static string[] colores = new string[] { "BLANCO", "NEGRO", "ROJO", "AZUL", "GRIS" };
        private static char[] consumos = new char[] { 'A', 'B', 'C', 'D', 'E', 'F' };

        public double PrecioBase { get; } = PRECIO_BASE;

        public string Color { get; } = COLOR;

        public char Consumo { get; } = CONSUMO;

        public double Peso { get; } = PESO;

        public Electrodomestico()
        {
        }

        public Electrodomestico(double precioBase, double peso)
        {
            PrecioBase = precioBase;
            Peso = peso;
        }

        public Electrodomestico(double precioBase, string color, char consumo, double peso)
        {
            PrecioBase = precioBase;
            Color = ComprobarColor(color);
            Consumo = ComprobarConsumo(consumo);
            Peso = peso;
        }

        public virtual double PrecioFinal()
        {
            double precioFinal = PrecioBase;
            switch (Consumo)
            {
                case 'A':
                    precioFinal += 100;
                    break;
                case 'B':
                    precioFinal += 80;
                    break;
                case 'C':
                    precioFinal += 60;
                    break;
                case 'D':
                    precioFinal += 50;
                    break;
                case 'E':
                    precioFinal += 30;
                    break;
                case 'F':
                    precioFinal += 10;
                    break;
            }

            if (Peso >= 0 && Peso < 20)
                precioFinal += 10;
            else if (Peso >= 20 && Peso < 50)
                precioFinal += 50;
            else if (Peso >= 50 && Peso < 80)
                precioFinal += 80;
            else if (Peso >= 80)
                precioFinal += 100;

            return precioFinal;
        }

        private string ComprobarColor(string color)
        {
            if (!colores.Contains(color.ToUpper()))
                return COLOR;
            return color.ToUpper();
        }

        private char ComprobarConsumo(char consumo)
        {
            if (!consumos.Contains(char.ToUpper(consumo)))
                return CONSUMO;
            return char.ToUpper(consumo);
        }
    }
}
