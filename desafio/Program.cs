using System;

public class Program
{
    // Função para calcular o valor absoluto de um número
    public static int Abs(int number)
    {
        return number < 0 ? -number : number;
    }

    public static void Main()
    {
        int[] array1 = new int[] {-1, 5, 8, 10, 15, 20, 25, 30, 35, 40};
        int[] array2 = new int[] {26, 6, 50, 3, 17, 19, 24, 33, 47, 55};

        int minDistance = int.MaxValue;
        int num1 = 0;
        int num2 = 0;

        for (int i = 0; i < array1.Length; i++)
        {
            for (int j = 0; j < array2.Length; j++)
            {
                int distance = Abs(array1[i] - array2[j]);
                if (distance < minDistance)
                {
                    minDistance = distance;
                    num1 = array1[i];
                    num2 = array2[j];
                }
            }
        }

        Console.WriteLine("A menor distância é " + minDistance + ", entre os números " + num1 + " do array 1 e " + num2 + " do array 2.");
    }
}

