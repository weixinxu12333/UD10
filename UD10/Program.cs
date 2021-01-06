using System;

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
                .Add("Salir", () => salir = true);
            while (!salir)
                menu.Display();
            
        }
    }
}
