﻿using System;

namespace Exercicio_Condicional_5 {
    class Program {
        static void Main (string[] args) {
            double a, b, c;

            Console.WriteLine ("Qual seu valor 1?: ");
            a = double.Parse (Console.ReadLine ());

            Console.WriteLine ("Qual seu valor 2?: ");
            b = double.Parse (Console.ReadLine ());

            Console.WriteLine ("Qual seu valor?: ");
            c = double.Parse (Console.ReadLine ());

            if (a > b && a > c) {
                Console.WriteLine ($"Seu valor é {a}");
            } else if (b > c) {
                Console.WriteLine ($"Seu valor é {b}");
            } else {
                Console.WriteLine ($"Seu valor é {c}");
            }
        }
    }
}