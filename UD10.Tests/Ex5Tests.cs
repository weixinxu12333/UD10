using System;
using Xunit;

namespace UD10.Tests
{
    public class Ex5Tests
    {
        [Fact]
        public void ConstructorSinParametros()
        {
            IEntregable serie = new Serie();

            Assert.Equal(default(string), serie.Titulo);

        }

    }
}
