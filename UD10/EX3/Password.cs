using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UD10
{
    public class Password
    {
        public int longitud { get; set; } = 8;
        public string contraseña { get; private set; }

        public Password()
        {
        }

        public Password(int longitud)
        {
            this.longitud = longitud;
            this.contraseña = generarContraseña();
        }

        private string generarContraseña()
        {
            Random rd = new Random();
            string cont = "";
            string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890%$#@";
            char letra;
            for (int i = 0; i < longitud; i++)
            {
                letra = caracteres[rd.Next(caracteres.Length)];
                cont += letra.ToString();
            }
            return cont;
        }

        public bool esFuerte()
        {
            int mayuscula = 0,  minuscula = 0, numeros = 0;

            for (int i = 0; i < contraseña.Length; i++)
            {
                if (Regex.Match(contraseña, @"[a-z]", RegexOptions.ECMAScript).Success)
                    minuscula++;
                if (Regex.Match(contraseña, @"[A-Z]", RegexOptions.ECMAScript).Success)
                    mayuscula++;
                if (Regex.Match(contraseña, @"[0-9]", RegexOptions.ECMAScript).Success)
                    numeros++;
            }

            if (mayuscula >= 2 && minuscula >=1 & numeros >=5)
                return true;
            else
                return false;
        }

    }
}
