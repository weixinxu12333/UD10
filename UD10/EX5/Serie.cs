using System;

namespace UD10
{
    public class Serie : IEntregable 
    {
        public string titulo { get; set; }
        public int temporada { get; set; } = 3;

        //esto he escrito yo, porque no puede tener get ni set, en interface no deja
        public bool entregado = false;
        public string genero { get; set; }
        public string creador { get; set; }

        public Serie()
        {
        }

        public Serie(string titulo, string creador)
        {
            this.titulo = titulo;
            this.creador = creador;
        }

        public Serie(string titulo, int temporada, string genero, string creador)
        {
            this.titulo = titulo;
            this.temporada = temporada;
            this.genero = genero;
            this.creador = creador;
        }

        //estos vienen por defecto de INTERFACE
        public bool devolver()
        {
            throw new NotImplementedException();
        }

        public bool entregar()
        {
            throw new NotImplementedException();
        }

        public bool isEntregado()
        {
            throw new NotImplementedException();
        }

        //escrito yo porque es override, no tiene herencia entre ellos, no se como hacer
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
