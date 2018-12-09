using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XTest2WPF.Algorithms
{
	class EliasCode
	{
		public static void Coding()
		{
			int[,] p = new int[6, 6];
			int[,] c = new int[6, 6];
			Random ran = new Random();
			for (int i = 0; i < 6; i++)
			{
				for (int j = 0; j < 6; j++)
				{
					c[i, j] = ran.Next(0, 2);
					c[i, 5] = -1;
					c[5, j] = -1;
					Console.Write("{0}\t", c[i, j]);
				}
				Console.WriteLine();
			}
			p = c;
			Console.WriteLine();
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
					Console.Write("{0}\t", p[i, j]);
				}
				Console.WriteLine();
			}
			Console.ReadKey();
		}
		public static void Decoding()
		{
			int[,] p = new int[6, 6];
			int[,] c = new int[6, 6];
			Random ran = new Random();
			for (int i = 0; i < 6; i++)
			{
				for (int j = 0; j < 6; j++)
				{
					c[i, j] = ran.Next(0, 2);
					c[i, 5] = -1;
					c[5, j] = -1;
				}
			}
			p = c;
			Console.WriteLine();
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
					Console.Write("{0}\t", p[i, j]);
				}
				Console.WriteLine();
			}
			Console.WriteLine();
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
					Console.Write("{0}\t", p[i, j]);
				}
				Console.WriteLine();
			}
			Console.WriteLine();
			CheckError(p);
			Console.ReadKey();
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
