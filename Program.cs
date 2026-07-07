
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
        //ex1
        
        {
            List<string> nomes = new List<string>();

            nomes.Add("Ana");
            nomes.Add("Bruno");
            nomes.Add("Carla");
            nomes.Add("David");
            nomes.Add("Eva");

            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine($"A lista tem {nomes.Count} nomes.");
        }

        Console.WriteLine();

        
        // Ex2
        {
            List<int> numeros = new List<int> { 10, 20, 30, 40, 50 };

            int soma = 0;

            for (int i = 0; i < numeros.Count; i++)
            {
                soma += numeros[i];
            }

            Console.WriteLine($"Soma = {soma}");
        }

        Console.WriteLine();

        
        // Ex 3
        
        {
            List<string> frutas = new List<string>();

            frutas.Add("Maçã");
            frutas.Add("Banana");
            frutas.Add("Pera");
            frutas.Add("Laranja");

            frutas.Insert(1, "Kiwi");

            frutas.RemoveAt(0);

            frutas.Remove("Pera");

            foreach (string fruta in frutas)
            {
                Console.WriteLine(fruta);
            }
        }

        Console.WriteLine();

        
        // Ex4
        
        {
            List<int> numeros = new List<int> { 12, 45, 8, 91, 33, 27 };

            int maior = numeros[0];

            for (int i = 1; i < numeros.Count; i++)
            {
                if (numeros[i] > maior)
                {
                    maior = numeros[i];
                }
            }

            Console.WriteLine($"Maior número:{maior}");
        }

        

        
        // Ex5
        
        {
            List<int> numeros = new List<int> { 8, 2, 15, 1, 10, 5 };

            numeros.Sort();

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }

        

        
        // Ex6
        {
            List<int> numeros = new List<int> { 4, 7, 10, 15, 20, 9, 12, 3, 8, 11 };

            int pares = 0;

            for (int i = 0; i < numeros.Count; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    pares++;
                }
            }

            Console.WriteLine($"Quantidade de números pares: {pares}");
        }

        

        
        // Ex7
        
        {
            List<string> nomes = new List<string>
            {
                "Ana",
                "Bruno",
                "Carla",
                "David",
                "Eva"
            };

            Console.Write("Introduza um nome: ");
            string nome = Console.ReadLine();

            if (nomes.Contains(nome))
            {
                Console.WriteLine("O nome existe.");
                Console.WriteLine($"Posição: {nomes.IndexOf(nome)}");
            }
            else
            {
                Console.WriteLine("Não existe.");
            }
        }

        Console.WriteLine();

        
        // Ex8
        
        {
            List<int> numeros = new List<int> { 5, 10, 15, 20, 25 };

            for (int i = numeros.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(numeros[i]);
            }
        }
    }
}


