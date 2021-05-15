using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
	class Program
	{
		static void Main(string[] args)
		{
			int i, j, n, m, temp, max;
			Console.WriteLine("Введите верхнюю границу массива");
			max = int.Parse(Console.ReadLine());
			Console.WriteLine("Введите максимальное количество элементов массива");
			n = int.Parse(Console.ReadLine());
			Random rand = new Random();
			int[] arr = new int[n];
			Console.WriteLine("Неотсортированный массив");
			for (i = 0; i < n; i++)
			{
				arr[i] = rand.Next(0, max);
				Console.Write(arr[i] + " ");
			}
			temp = 0;
			for (i = 0; i < arr.Length; i++)
			{
				for (j = 1; j < arr.Length - i; j++)
				{
					if (arr[j] < arr[j - 1])
					{
						temp = arr[j];
						arr[j] = arr[j - 1];
						arr[j - 1] = temp;
					}
				}
			}
			Console.WriteLine();
			Console.WriteLine("Отсортированный массив");
			for (i = 0; i < n; i++)
			{
				Console.Write(arr[i] + " ");
			}
			Console.WriteLine();
			Console.WriteLine("Введите число для поиска");
			m = int.Parse(Console.ReadLine());
			for (i = 0; i < n; i++)
			{
				if (arr[i] == m)
				{
					Console.WriteLine(i);
				}
				else Console.WriteLine("Такого числа нет");
			}
			Console.ReadKey();

		}
	}
}
