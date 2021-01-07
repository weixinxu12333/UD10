namespace UD10
{
    public class Serie : ISerie
    {
        public string Titulo { get; set; }
        public int Temporada { get; set; } = 3;

        //esto he escrito yo, porque no puede tener get ni set, en interface no deja
        private bool Entregado = false;
        public string Genero { get; set; }
        public string Creador { get; set; }

        public Serie()
        {
        }

        public Serie(string titulo, string creador)
        {
            Titulo = titulo;
            Creador = creador;
        }

        public Serie(string titulo, int temporada, string genero, string creador)
        {
            Titulo = titulo;
            Temporada = temporada;
            Genero = genero;
            Creador = creador;
        }

        //estos vienen por defecto de INTERFACE
        public bool Devolver()
        {
            return Entregado = false;
        }

        public bool Entregar()
        {
            return Entregado = true;
        }

        public bool IsEntregado()
        {
            return Entregado;
        }

        //escrito yo porque es override, no tiene herencia entre ellos
        public override string ToString()
        {
            return @$"
                Serie: {Titulo}
                Número Temporadas: {Temporada}
                Entregado: {Entregado}
                Genero: {Genero}
                Creador: {Creador}
            ";
        }

        public int CompareTo(object obj)
        {
            if(obj is Serie s)
            {
                if (s.Temporada > Temporada) return -1;
                else if (s.Temporada < Temporada) return 1;
                else return 0;
            }
            else
                throw new System.ArgumentException("No es del tipo Serie", nameof(obj));
        }
    }
}
