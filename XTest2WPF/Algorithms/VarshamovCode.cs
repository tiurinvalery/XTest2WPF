using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XTest2WPF.Algorithms
{
	class VarshamovCode
	{

		/// <summary>
		/// //Задание 1: 
		//Пользователь вводит: 1) количество столбцов, 2) количество исправляемых ошибок, 3)количество строк производящей матрицы
		//if (FirstTask(17, 6, 17, 2, 5))
		//{
		//	Console.WriteLine("Fine");
		//}
		//else
		//{
		//	Console.WriteLine("foooooooo");
		//}

		//Задание 2:
		//Кодирование при помощи матрицы G
		//Первое число в SecondTask это число которое необходимо закодировать. Оно должно быть до 6 цифр включительно и содержать только 0 и 1
		//Второе число это ответ пользователя

		//if (SecondTask(100001, "1000011111"))
		//{
		//	Console.WriteLine("Fine");
		//}
		//else
		//{
		//	Console.WriteLine("foooooooo");
		//}
		/// </summary>


		public static bool FirstTask(int n, int d, int stolb, int mistake, int line)
		{
			bool result = false;
			if (stolb != n || mistake != NumberOfMistakes(d) || line != NumberOfLines(n, d))
			{
				result = false;
			}
			else
			{
				result = true;
			}
			return result;
		}
		public static bool SecondTask(int number, string userAnswer)
		{
			bool result = false;
			if (!userAnswer.Equals(DoResult(number)))
			{
				result = false;
			}
			else
			{
				result = true;
			}
			return result;
		}
		public static string DoResult(int number)
		{
			string smth = number.ToString();
			List<int> nums = new List<int>();
			var chars = smth.ToCharArray();
			for (int i = 0; i < chars.Length; i++)
			{
				if (chars[i] == '1')
				{
					nums.Add(i);
				}
			}
			int[,] hmatr = HMatrix();
			int resStolb = 0;
			List<int> listNum = new List<int>(3);
			for (int i = 0; i < 6; i++)
			{
				for (int j = 0; j < 4; j++)
				{
					foreach (int item in nums)
					{
						resStolb += hmatr[item, j];
					}
					listNum.Add(resStolb % 2);
					resStolb = 0;
				}
			}
			string resH = listNum[0].ToString() + listNum[1].ToString() + listNum[2].ToString() + listNum[3].ToString();
			string finalResult = smth + resH;
			return finalResult;
		}
		public static int[,] GMatrix()
		{
			int[,] p = new int[6, 6];
			Random ran = new Random();
			for (int i = 0; i < 6; i++)
			{
				for (int j = 0; j < 6; j++)
				{
					p[i, j] = 0;
				}
			}
			p[0, 0] = 1;
			p[1, 1] = 1;
			p[2, 2] = 1;
			p[3, 3] = 1;
			p[4, 4] = 1;
			p[5, 5] = 1;
			return p;
		}
		public static int[,] HMatrix()
		{
			int[,] p = new int[6, 4];
			Random ran = new Random();
			for (int i = 0; i < 6; i++)
			{
				for (int j = 0; j < 4; j++)
				{
					p[i, j] = 0;
				}
			}
			p[0, 2] = 1;
			p[0, 3] = 1;
			p[1, 1] = 1;
			p[1, 3] = 1;
			p[2, 0] = 1;
			p[2, 3] = 1;
			p[3, 1] = 1;
			p[3, 2] = 1;
			p[4, 0] = 1;
			p[4, 2] = 1;
			p[5, 0] = 1;
			p[5, 1] = 1;
			return p;
		}
		public static long NumberOfLines(int n, int d)
		{
			long S = 0;
			for (int i = 1; i <= (d - 2); i++)
			{
				S += Math.Abs((Factorial(n - 1)) / (Factorial(i) * Factorial((n - (1 + i)))));
			}
			long r = FindR(S + 1);
			long strok = n - r;
			return strok;
		}
		public static int NumberOfMistakes(int d)
		{
			return (d - 1) / 2;
		}
		public static long Factorial(int num)
		{
			long res = 1;
			for (int i = num; i > 1; i--)
			{
				res *= i;
			}
			return res;
		}
		public static int FindR(long S)
		{
			int r = 1;
			int result = 0;
			for (int i = 1; i < 100; i++)
			{
				if (Math.Pow(2, r) >= S)
				{
					result = r;
					break;
				}
				r++;
			}
			return result;
		}
	}
}
