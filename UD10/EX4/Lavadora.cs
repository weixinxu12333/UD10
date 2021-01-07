namespace UD10
{
    public class Lavadora : Electrodomestico, ILavadora
    {
        public int Carga { get; } = 5;

        public Lavadora(double precioBase, string color, char consumo, double peso, int carga) : base(precioBase, color, consumo, peso)
        {
            Carga = carga;
        }

        public override double PrecioFinal()
        {
            var precioFinal = base.PrecioFinal();
            if (Carga > 30)
                precioFinal += 50;
            return precioFinal;
        }
    }
}
