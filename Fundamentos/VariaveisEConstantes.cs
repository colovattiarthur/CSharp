﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Fundamentos {
    class VariaveisEConstantes {


        public static void Executar() {
            //variavel
            double raio = 1.3;

            //constante
            const double pi = 3.14;

            double area = pi * raio * raio;

            Console.WriteLine($"A área total é de:  { area }");

            string nome = "Cleiton";
            int idade = 23;
            double altura = 1.67;
            bool temgato = true;

            Console.WriteLine($" oi {nome} você tem{idade} as sua altura {altura}");

        }
    }
}
