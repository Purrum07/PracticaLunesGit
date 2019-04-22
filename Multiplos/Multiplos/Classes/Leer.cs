using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Multiplos.Classes
{
    class Leer
    {

        string leidos = File.ReadAllText("numeros.txt");
        int contador = 0;

        public int Checar()
        {
            string[] numeros = leidos.Split('\t','\n');

            int[] numeritos = new int[numeros.Length];

            int i = 0;
            foreach (String text in numeros)

            {
                int.TryParse(text, out numeritos[i]);
                ++i;
            }

            for (int j = 0; j < numeritos.Count(); j++)
            {

                if (numeritos[j] % 10 == 0)
                {
                    contador++;
                }
                else
                {
                    continue;
                }

            }
            Console.WriteLine("El número de multiplos de 10 dentro de la lista es de: {0}",contador);

            return 0;
        }
    }
}