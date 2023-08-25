using System;

namespace MovendoElementosDeUmArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 3, 5, 8, 9, 6, 1 };
            int k = 3;

            foreach(int numero in numeros)
            {
                Console.Write(numero);
            }

            int[] numerosModificados = mudandoKCasasParaFrente(numeros, k);
            Console.WriteLine();

            foreach (int numero in numerosModificados)
            {
                Console.Write(numero);
            }
            Console.WriteLine();
            Console.ReadKey();

        }
        static int[] mudandoKCasasParaFrente(int[] numeros, int k) {

            int[] arrayModificado = new int[numeros.Length];
            
            for(int i=0; i<k; i++)
            {
                if(i != 0)
                {
                    numeros = igualandoArrays(arrayModificado);
                }
                for (int y=0; y < numeros.Length; y++)
                {

                    if(y == numeros.Length - 1)
                    {
                        arrayModificado[0] = numeros[numeros.Length - 1];
                    }
                    else
                    {
                        arrayModificado[y + 1] = numeros[y]; 
                    }
                }
            }
            return arrayModificado;
        }

        static int[] igualandoArrays(int[] arrayModificado)
        {
            int[] copia = new int[arrayModificado.Length];

            for(int i=0; i< arrayModificado.Length; i++)
            {
                copia[i] = arrayModificado[i];
            }
            return copia;
        }
    }
}
