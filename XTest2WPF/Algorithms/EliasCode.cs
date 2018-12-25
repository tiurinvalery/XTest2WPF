using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XTest2WPF.Algorithms
{
	class EliasCode
	{
		/// <summary>
		/// Кодирование:
		/// //1) Вывести массив из метода FirstArr();
			//int[,] c = FirstArr();//начальный массив
			//Console.WriteLine();

			////2) Вызвать метод Coding передав в него массив с. Это нужно для сравнения результатов
			//int[,] codingRes = Coding(c);//правильный результат
			//Console.WriteLine();

			////3) Собрать все ответы пользователя и добавить в массивы 
			//int[] stolb = new int[5] { 0, 1, 1, 0, 1 };//данные по вертикали
			//int[] strok = new int[5] { 1, 0, 1, 1, 1 };//данные по горизонтали

			////4) Вызвать метод CodingWithUser который принимает массивы с ответами и начальный массив
			//int[,] userRes = CodingWithUser(stolb, strok, c);
			//Console.WriteLine();

			////5) Сравнить два массива
			////Основная проблема потому что хз как это сделать, метод ниже не работает
			//bool isEqual = false;
			//for (int i = 0; i < 6; i++)
			//    for (int j = 0; j < 6; j++)
			//    {
			//		if (codingRes[i, j] == userRes[i, j])
			//		{
			//			isEqual = true;
			//		}
			//		else
			//		{
			//			isEqual = false;
			//		}
			//     }
			//if (isEqual)
			//{
			//	Console.WriteLine("Fine");
			//}
			//else
			//{
			//	Console.WriteLine("Bad");
			//}
			//Console.ReadKey();
		/// </summary>
		public static int[,] FirstArr()
		{
			int[,] c = new int[6, 6];
			Random ran = new Random();
			for (int i = 0; i < 5; i++)
			{
				for (int j = 0; j < 5; j++)
				{
					c[i, j] = ran.Next(0, 2);
				}
			}
			return c;
		}
		public static int[,] Coding(int[,] c)
		{
			int[,] p = new int[6, 6];
			p = c;
			for (int i = 0; i < 6; i++)
			{
				int resStr = Sum(p[i, 0], p[i, 1], p[i, 2], p[i, 3], p[i, 4]);
				if (resStr % 2 != 0)
				{
					p[i, 5] = 1;
				}
				else
				{
					p[i, 5] = 0;
				}
				for (int j = 0; j < 6; j++)
				{
					int resStolb = Sum(p[0, j], p[1, j], p[2, j], p[3, j], p[4, j]);
					if (resStolb % 2 != 0)
					{
						p[5, j] = 1;
					}
					else
					{
						p[5, j] = 0;
					}
				}
			}
			return p;
		}
		public static int[,] CodingWithUser(int[] stolb, int[] strok, int[,] c)
		{
			int[,] p = new int[6, 6];
			p = c;
			p[0, 5] = stolb[0];
			p[1, 5] = stolb[1];
			p[2, 5] = stolb[2];
			p[3, 5] = stolb[3];
			p[4, 5] = stolb[4];

			p[5, 0] = strok[0];
			p[5, 1] = strok[1];
			p[5, 2] = strok[2];
			p[5, 3] = strok[3];
			p[5, 4] = strok[4];
			return p;
		}
		public static void Decoding()
		{
			int[,] p = new int[6, 6];
			Random ran = new Random();
			p = FirstArr();
			for (int i = 0; i < 6; i++)
			{
				int resStr = Sum(p[i, 0], p[i, 1], p[i, 2], p[i, 3], p[i, 4]);
				if (resStr % 2 != 0)
				{
					p[i, 5] = 1;
				}
				else
				{
					p[i, 5] = 0;
				}
				for (int j = 0; j < 6; j++)
				{
					int resStolb = Sum(p[0, j], p[1, j], p[2, j], p[3, j], p[4, j]);
					if (resStolb % 2 != 0)
					{
						p[5, j] = 1;
					}
					else
					{
						p[5, j] = 0;
					}
				}
			}
			Random newRand = new Random();
			bool val = true;
			for (int i = 0; i < 6; i++)
			{
				for (int j = 0; j < 6; j++)
				{
					if (newRand.Next(0, 8) == 5 && val)
					{
						if (p[i, j] == 1)
						{
							p[i, j] = 0;
						}
						else
						{
							p[i, j] = 1;
						}
						val = false;
					}
				}
			}
			CheckError(p);
		}
		public static int Sum(int first, int second, int third, int fourth, int fifth)
		{
			return first + second + third + fourth + fifth;
		}
		public static void CheckError(int[,] arr)
		{
			int str = -1;
			int stolb = -1;
			bool valStr = true;
			bool valStolb = true;
			for (int i = 0; i < 6; i++)
			{
				int resStr = Sum(arr[i, 0], arr[i, 1], arr[i, 2], arr[i, 3], arr[i, 4]);
				if (resStr % 2 == 0 && arr[i, 5] != 0 && valStr)
				{
					str = i;
					valStr = false;
				}
				else if (resStr % 2 == 1 && arr[i, 5] != 1)
				{
					str = i;
					valStr = false;
				}
				for (int j = 0; j < 6; j++)
				{
					int resStolb = Sum(arr[0, j], arr[1, j], arr[2, j], arr[3, j], arr[4, j]);
					if (resStolb % 2 == 0 && arr[5, j] != 0 && valStolb)
					{
						stolb = j;
						valStolb = false;
					}
					else if (resStolb % 2 == 1 && arr[5, j] != 1 && valStolb)
					{
						stolb = j;
						valStolb = false;
					}

					if (str != -1 && stolb != -1)
					{
						if (arr[str, stolb] == 0)
						{
							arr[str, stolb] = 1;
						}
						else
						{
							arr[str, stolb] = 0;
						}
					}
					Console.Write("{0}\t", arr[i, j]);
				}
				Console.WriteLine();
			}
			Console.Write("Ошибка строка: {0} , столбец: {1}", str + 1, stolb + 1);
		}
	}
}
