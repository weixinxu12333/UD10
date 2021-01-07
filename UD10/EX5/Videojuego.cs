namespace UD10
{
    public class Videojuego : IVideojuego
    {
        //por defecto orden: titulo, genero, horas, compañia
        public string Titulo { get; set; }
        public double HorasEstimadas { get; set; } = 10;
        //escrito yo
        private bool Entregado = false;
        public string Genero { get; set; }
        public string Compañia { get; set; }

        public Videojuego()
        {
        }

        public Videojuego(string titulo, double horasEstimadas)
        {
            Titulo = titulo;
            HorasEstimadas = horasEstimadas;
        }

        public Videojuego(string titulo, double horasEstimadas, string genero, string compañia)
        {
            Titulo = titulo;
            HorasEstimadas = horasEstimadas;
            Genero = genero;
            Compañia = compañia;
        }

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
                Videojuego: {Titulo}
                Horas estimadas: {HorasEstimadas}
                Entregado: {Entregado}
                Genero: {Genero}
                Compañía: {Compañia}
            ";
        }

        public int CompareTo(object obj)
        {
            if (obj is Videojuego v)
            {
                if (v.HorasEstimadas > HorasEstimadas) return -1;
                else if (v.HorasEstimadas < HorasEstimadas) return 1;
                else return 0;
            }
            else
                throw new System.ArgumentException("No es un Videojuego", nameof(obj));
        }
    }
}
