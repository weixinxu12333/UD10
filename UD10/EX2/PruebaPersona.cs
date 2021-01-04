using System;
using System.Collections.Generic;
using System.Text;

namespace UD10
{
    class PruebaPersona
    {
        public static void Inicio()
        {
            Console.WriteLine("Indrocude nombre");
            string nombre = Console.ReadLine();

            Console.WriteLine("Indrocude edad");
            int edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Indrocude sexo, solo H o M");
            char sexo = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Indrocude peso en kg");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Indrocude altura en m");
            double altura = Convert.ToDouble(Console.ReadLine());

            Persona p1 = new Persona(nombre, edad, sexo, peso, altura);
            Console.WriteLine(p1);
            imprimirIMC(p1);
            mayorEdad(p1);


            Persona p2 = new Persona("B", 40, 'J');
            Console.WriteLine(p2);
            imprimirIMC(p2);
            mayorEdad(p2);

            Persona p3 = new Persona
            {
                Nombre = "C",
                Edad = 78,
                Sexo = 'H',
                Peso = 100.90,
                Altura = 1.76
            };
            Console.WriteLine(p3);
            imprimirIMC(p3);
            mayorEdad(p3);

        }

        private static void mayorEdad(Persona p)
        {
            Console.WriteLine($"La persona {nameof(p)} {(p.esMayorDeEdad() ? "es" : "no es")} mayor de edad");
        }

        private static void imprimirIMC(Persona p)
        {
            int result = p.calcularIMC();
            if(result == Persona.PESO_LIGERO)
                Console.WriteLine("La persona tiene un peso por debajo del ideal");
            else if(result == Persona.PESO_NORMAL)
                Console.WriteLine("La persona tiene un peso normal");
            else
                Console.WriteLine("La persona tiene sobrepeso");
        }
    }
}
