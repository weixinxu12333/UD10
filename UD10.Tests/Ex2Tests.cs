using Xunit;

namespace UD10.Tests
{
    public class Ex2Tests
    {
        [Fact]
        public void SexoEnMinusculas()
        {
            var a = new Persona
            {
                Sexo = 'm'
            };
            Assert.Contains("Sexo: M", a.ToString());
        }

        [Fact]
        public void SexoInvalido()
        {
            var a = new Persona
            {
                Sexo = 'J'
            };
            Assert.Contains("Sexo: H", a.ToString());
        }

        [Fact]
        public void MayorDeEdad()
        {
            var a = new Persona
            {
                Edad = 18,
            };
            Assert.True(a.esMayorDeEdad());
        }

        [Fact]
        public void MayorDeEdad2()
        {
            var a = new Persona
            {
                Edad = 9999,
            };
            Assert.True(a.esMayorDeEdad());
        }

        [Fact]
        public void MenorDeEdad()
        {
            var a = new Persona
            {
                Edad = 17,
            };
            Assert.False(a.esMayorDeEdad());
        }

        [Fact]
        public void MenorDeEdad2()
        {
            var a = new Persona
            {
                Edad = -999,
            };
            Assert.False(a.esMayorDeEdad());
        }
    }
}
