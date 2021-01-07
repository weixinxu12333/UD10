using System;
using System.Linq;

namespace UD10
{
    class Program
    {
        static void Main(string[] args)
        {
            var salir = false;
            var menu = new EasyConsole.Menu()
                .Add("Ex1", () => {
                    Cuenta cuenta = new Cuenta("ABC");
                    cuenta.Ingresar(100);
                    Console.WriteLine(cuenta);
                    cuenta.Retirar(50);
                    Console.WriteLine(cuenta);
                    cuenta.Retirar(300);
                    Console.WriteLine(cuenta);

                    Cuenta cuenta2 = new Cuenta("ABC", 200);
                    Console.WriteLine(cuenta2);
                })
                .Add("Ex2", () => {
                    PruebaPersona.Inicio();
                })
                .Add("Ex3", () => {
                    Console.WriteLine("Introduce tamaño de un array: ");
                    int cantidad = Convert.ToInt32(Console.ReadLine());
                    Password[] arrayPassword = new Password[cantidad];
                    Console.WriteLine("Introduce longitud de los passwords: ");
                    int lon = Convert.ToInt32(Console.ReadLine());

                    bool[] arraySeguro = new bool[cantidad];

                    for (int i = 0; i < arrayPassword.Length; i++)
                    {
                        arrayPassword[i] = new Password(lon);
                        arraySeguro[i] = arrayPassword[i].esFuerte();
                        Console.WriteLine("{0} {1}", arrayPassword[i].contraseña, arraySeguro[i]);
                    }
                })
                .Add("Ex4", () =>
                {
                    Electrodomestico[] arrElectrodomesticos = new Electrodomestico[10];
                    Random rd = new Random();
                    for (int i = 0; i < 5; i++)
                        arrElectrodomesticos[i] = new Electrodomestico(rd.Next(0, 500), rd.Next(0, 100));
                    for (int i = 5; i < 8; i++)
                        arrElectrodomesticos[i] = new Lavadora(rd.Next(0, 500), "VERDE", 'A', rd.Next(0, 100), rd.Next(1, 50));
                    for (int i = 8; i < 10; i++)
                        arrElectrodomesticos[i] = new Television(rd.Next(0, 500), "NEGRO", 'B', rd.Next(0, 100), rd.Next(0, 100), rd.Next(0,100) > 50);
                    var precioFinalElectrodomesticos = arrElectrodomesticos.Sum(x => x.PrecioFinal());
                    var precioFinalLavadoras = arrElectrodomesticos.Where(x => x is Lavadora).Sum(x => x.PrecioFinal());
                    var precioFinalTelevisiones = arrElectrodomesticos.Where(x => x is Television).Sum(x => x.PrecioFinal());
                    Console.WriteLine("Suma de precios de los electrodomésticos: {0}€\nLavadoras: {1}€\nTelevisiones: {2}€", precioFinalElectrodomesticos, precioFinalLavadoras, precioFinalTelevisiones);
                })
                .Add("EX5", () => 
                {
                    Serie[] arrSeries = new Serie[5];
                    Videojuego[] arrVideojuegos = new Videojuego[5];
                    Random rd = new Random();

                    arrSeries[0] = new Serie("Soul", "Disney");
                    arrSeries[1] = new Serie("Yanxi Palace", 1, "Drama", "Alguien");
                    arrSeries[2] = new Serie("Wall-E", 1, "Anime", "Disney");
                    arrSeries[3] = new Serie("Miauu", 5, "Anime", "Alguien");
                    arrSeries[4] = new Serie();

                    foreach (var serie in arrSeries)
                    {
                        if (rd.Next(0, 100) > 50) serie.Entregar();
                    }

                    arrVideojuegos[0] = new Videojuego("GTA 1", 5, "Accion", "Alguien");
                    arrVideojuegos[1] = new Videojuego("GTA 2", 11);
                    arrVideojuegos[2] = new Videojuego("GTA 3", 9, "Accion", "Alguien");
                    arrVideojuegos[3] = new Videojuego("GTA 4", 50, "Accion", "Alguien");
                    arrVideojuegos[4] = new Videojuego();

                    foreach (var videojuego in arrVideojuegos)
                    {
                        if (rd.Next(0, 100) > 50) videojuego.Entregar();
                    }

                    Console.WriteLine("Series entregadas: {0}", arrSeries.Count(x => x.IsEntregado()));
                    Console.WriteLine("Videojuegos entregados: {0}", arrVideojuegos.Count(x => x.IsEntregado()));

                    //son array de objetos, porque hecho icomparable, por eso puedo ordenar, sino no.
                    Array.Sort(arrSeries);
                    Array.Sort(arrVideojuegos);

                    Console.WriteLine("Serie con más temporadas:");
                    Console.WriteLine(arrSeries.Last());
                    Console.WriteLine("----------");
                    Console.WriteLine("Videojuego con más horas estimadas:");
                    Console.WriteLine(arrVideojuegos.Last());

                })
                .Add("Salir", () => salir = true);
            while (!salir)
                menu.Display();
            
        }
    }
}
