namespace Program
{
	class Program
	{
		static void Main(string[] args)
		{
			var watch = System.Diagnostics.Stopwatch.StartNew();
			int[] arr = { 61, 43, 40, 70, 32, 53, 37, 33, 49, 45, 52, 30, 50, 32, 63, 68 };
			Console.WriteLine("Arr before BubbleSort: ");
			OutputArr(arr);
			BubbleSort(ref arr, arr.Length);
			Console.WriteLine("Arr after BubbleSort: ");
			OutputArr(arr);
			watch.Stop();
			Console.WriteLine($"Algorithm Time: {watch.ElapsedMilliseconds} ms");


		}

		public static void BubbleSort(ref int[] A, int n)
		{
			
			for (int i = 0; i < A.Length - 1; i++)
			{
				for (int j = 0; j < A.Length - 1 - i; j++)
				{
					if (A[j] > A[j + 1])
					{
						Swap(ref A[j], ref A[j + 1]);
					}
				}
			}
		}

		public static void Swap(ref int x, ref int y)
		{
			int temp = x;
			x = y;
			y = temp;
		}

		public static void OutputArr(int[] arr)
		{
			foreach(int i in arr)
			{
				Console.Write($"{i},");
			}
			Console.WriteLine();
		}

	}
}
