using System;
using Xunit;

namespace UD10.Tests
{
    public class Ex5Tests
    {
        [Fact]
        public void ConstructorSinParametros()
        {
            // como que no deja poner genero en constructor, falta un parametro false/true
            IEntregable serie = new Serie("Yanxi Palace", 1, "Drama", "Alguien");

            //Por que pones Electrodomestico.PRECIO_BASE en vez de elec?
            /*
        public void ConstructorSinParametros()
        {
            IElectrodomestico elec = new Electrodomestico();

            Assert.Equal(Electrodomestico.PRECIO_BASE, elec.PrecioBase);
            Assert.Equal(Electrodomestico.COLOR, elec.Color);
            Assert.Equal(Electrodomestico.CONSUMO, elec.Consumo);
            Assert.Equal(Electrodomestico.PESO, elec.Peso);
        }
             */
            Assert.Equal(Serie.titulo, serie.titulo);
        }

    }
}
