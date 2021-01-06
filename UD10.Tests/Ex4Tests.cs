using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace UD10.Tests
{
    public class Ex4Tests
    {
        [Fact]
        public void ConstructorSinParametros()
        {
            IElectrodomestico elec = new Electrodomestico();

            Assert.Equal(Electrodomestico.PRECIO_BASE, elec.PrecioBase);
            Assert.Equal(Electrodomestico.COLOR, elec.Color);
            Assert.Equal(Electrodomestico.CONSUMO, elec.Consumo);
            Assert.Equal(Electrodomestico.PESO, elec.Peso);
        }

        [Fact]
        public void ConstructorPrecioPeso()
        {
            const double precio = 200;
            const double peso = 10.5;
            IElectrodomestico elec = new Electrodomestico(precio, peso);

            Assert.Equal(precio, elec.PrecioBase);
            Assert.Equal(Electrodomestico.COLOR, elec.Color);
            Assert.Equal(Electrodomestico.CONSUMO, elec.Consumo);
            Assert.Equal(peso, elec.Peso);
        }

        [Theory]
        [ClassData(typeof(ElectrodomesticoColorData))]
        public void ComprobarColor(string color, string colorEsperado)
        {
            const double precio = 200;
            const double peso = 10.5;
            IElectrodomestico elec = new Electrodomestico(precio, color, Electrodomestico.CONSUMO, peso);

            Assert.Equal(precio, elec.PrecioBase);
            Assert.Equal(colorEsperado, elec.Color);
            Assert.Equal(Electrodomestico.CONSUMO, elec.Consumo);
            Assert.Equal(peso, elec.Peso);
        }

        [Theory]
        [ClassData(typeof(ElectrodomesticoConsumoData))]
        public void ComprobarConsumo(char consumo, char consumoEsperado)
        {
            const double precio = 200;
            const double peso = 10.5;
            IElectrodomestico elec = new Electrodomestico(precio, Electrodomestico.COLOR, consumo, peso);

            Assert.Equal(precio, elec.PrecioBase);
            Assert.Equal(Electrodomestico.COLOR, elec.Color);
            Assert.Equal(consumoEsperado, elec.Consumo);
            Assert.Equal(peso, elec.Peso);
        }

        [Theory]
        [ClassData(typeof(ElectrodomesticoPrecioFinalData))]
        public void PrecioFinalTheory(char consumo, double peso, double precio)
        {
            IElectrodomestico elec = new Electrodomestico(0, Electrodomestico.COLOR, consumo, peso);
            Assert.Equal(precio, elec.PrecioFinal());
        }

        [Theory]
        [MemberData(nameof(LavadoraPrecioFinalData))]
        public void LavadoraPrecioFinalTheory(char consumo, double peso, int carga, double precio)
        {
            IElectrodomestico elec = new Lavadora(0, Electrodomestico.COLOR, consumo, peso, carga);
            Assert.Equal(precio, elec.PrecioFinal());
        }

        [Theory]
        [InlineData(30, false, 300)]
        [InlineData(50, false, 330)]
        [InlineData(40, true, 350)]
        [InlineData(60, true, 380)]
        public void TelevisionPrecioFinalTheory(int resolucion, bool tdt, double precio)
        {
            IElectrodomestico elec = new Television(Electrodomestico.PRECIO_BASE, Electrodomestico.COLOR, 'A', 90, resolucion, tdt);
            Assert.Equal(precio, elec.PrecioFinal());
        }

        public static IEnumerable<object[]> LavadoraPrecioFinalData =>
            new ElectrodomesticoPrecioFinalData().Select(x => new object[] { x[0], x[1], 8, x[2] })
            .Concat(new ElectrodomesticoPrecioFinalData().Select(x => new object[] { x[0], x[1], 31, (double)x[2] + 50 }));
    }
    class ElectrodomesticoColorData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var colores = new string[] { "blanco", "negro", "roJo", "azul", "gris" };
            foreach(var color in colores)
            {
                yield return new object[] { color, color.ToUpper() };
            }
            // Edge Case
            yield return new object[] { "beige", "BLANCO" };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    class ElectrodomesticoConsumoData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var consumos = new char[] { 'A', 'b', 'c', 'D', 'e', 'F' };
            foreach (var consumo in consumos)
            {
                yield return new object[] { consumo, char.ToUpper(consumo) };
            }
            // Edge Case
            yield return new object[] { 'H', 'F' };
            yield return new object[] { 'â', 'F' };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    class ElectrodomesticoPrecioFinalData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var consumos = new Dictionary<char, double>() {
                { 'A', 100 },
                { 'B', 80 },
                { 'C', 60 },
                { 'D', 50 },
                { 'E', 30 },
                { 'F', 10 }
            };
            var preciosPesos = new Dictionary<double, double[]>() {
                {0, new [] { -5d } },
                {10, new [] { 0, 15.5, 19.9 } },
                {50, new [] { 20, 37.124, 49.998 } },
                {80, new [] { 50, 52.121, 79.99999 } },
                {100, new [] { 80, double.MaxValue } }
            };
            foreach (var (consumo, precioConsumo) in consumos)
            {
                foreach (var (precioPeso, pesos) in preciosPesos)
                {
                    foreach(var peso in pesos)
                    {
                        yield return new object[] { consumo, peso, precioConsumo + precioPeso };
                    }
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
