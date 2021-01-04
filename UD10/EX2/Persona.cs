using System;
using System.Collections.Generic;
using System.Text;

namespace UD10
{
    public class Persona
    {
        #region Constantes
        public const char GENERO_DEFECTO = 'H';
        public const int PESO_LIGERO = -1;
        public const int PESO_NORMAL = 0;
        public const int PESO_EXCESO = 1;
        #endregion

        #region Campos
        private string _nombre;
        private int _edad;
        private string _dni;
        private char _sexo = GENERO_DEFECTO;
        private double _peso;
        private double _altura;
        #endregion

        #region Constructores
        public Persona() {
            _dni = generarDNI();
        }

        public Persona(string nombre, int edad, char sexo)
        {
            _nombre = nombre;
            _edad = edad;
            _sexo = comprobarSexo(sexo);
            _dni = generarDNI();
        }

        public Persona(string nombre, int edad, char sexo, double peso, double altura)
        {
            _nombre = nombre;
            _edad = edad;
            _sexo = comprobarSexo(sexo);
            _peso = peso;
            _altura = altura;
            _dni = generarDNI();
        }
        #endregion


        //Getter y Setter publico
        public string Nombre
        {
            set { _nombre = value; }
        }
        public int Edad
        {
            set { _edad = value; }
        }
        public char Sexo
        {
            set { _sexo = comprobarSexo(value); }
        }
        public double Peso
        {
            set { _peso = value; }
        }
        public double Altura
        {
            set { _altura = value; }
        }

        //Metodes
        public int calcularIMC()
        {
            double res = _peso / Math.Pow(_altura, 2);
            if (res < 20)
                return PESO_LIGERO;
            else if (res >= 20 && res <= 25)
                return PESO_NORMAL;
            else
                return PESO_EXCESO;
        }

        public bool esMayorDeEdad()
        {
            if (_edad >= 18)
                return true;
            else 
                return false;
        }

        private char comprobarSexo(char sexo)
        {
            char gen = Char.ToUpper(sexo);
            if (gen != 'M' && gen != 'H')
                gen = GENERO_DEFECTO;
            return gen;
        }

        public override string ToString()
        {
            string info = "Nombre: " + _nombre + " Edad: " + _edad + " DNI: " + _dni + " Sexo: " + _sexo + " Peso: " + _peso + "kg Altura: " + _altura + "m";
            return info;
        }

        private char letraDNI(string DNI)
        {
            const string CORRESPONDENCIA = "TRWAGMYFPDXBNJZSQVHLCKE";
            int mod = int.Parse(DNI) % 23;
            return CORRESPONDENCIA[mod];
        }

        private string generarDNI()
        {
            Random rd = new Random();
            string dni = "";
            for (int i = 0; i < 8; i++)
                dni += rd.Next(10);
            dni += letraDNI(dni);

            return dni;
        }

    }
}
