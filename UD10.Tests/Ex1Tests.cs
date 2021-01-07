using System;
using Xunit;

namespace UD10.Tests
{
    public class Ex1Tests
    {
        [Fact]
        public void ConstruirSinCantidad()
        {
            var a = new Cuenta("Test");
            Assert.Equal("Test", a.titular);
            Assert.Equal(default(double), a.cantidad);
        }

        [Fact]
        public void Construir()
        {
            var a = new Cuenta("Test", 50);
            Assert.Equal("Test", a.titular);
            Assert.Equal(50, a.cantidad);
        }

        [Fact]
        public void IngresarPositivo()
        {
            var a = new Cuenta("Test");
            a.Ingresar(50);
            Assert.Equal(50, a.cantidad);
        }

        [Fact]
        public void IngresarNegativo()
        {
            var a = new Cuenta("Test", 50);
            a.Ingresar(-50);
            Assert.Equal(50, a.cantidad);
        }

        [Fact]
        public void RetirarPositivo()
        {
            var a = new Cuenta("Test", 100);
            a.Retirar(50);
            Assert.Equal(50, a.cantidad);
        }

        [Fact]
        public void RetirarDemasiado()
        {
            var a = new Cuenta("Test", 100);
            a.Retirar(150);
            Assert.Equal(0, a.cantidad);
        }

        [Fact]
        public void RetirarNegativo()
        {
            var a = new Cuenta("Test", 100);
            a.Retirar(-150);
            Assert.Equal(100, a.cantidad);
        }
    }
}
