﻿using System;

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
                .Add("Salir", () => salir = true);
            while (!salir)
                menu.Display();
            
        }
    }
}
