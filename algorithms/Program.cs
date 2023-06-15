using System.Reflection.PortableExecutable;

namespace Program
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = { 7, 2, 1, 6, 8, 5, 3, 4 };
			Console.WriteLine("Initial array: ");
			DisplayArr(arr);
			Console.WriteLine("Array after QuickSort: ");
			QuickSort(ref arr, 0,7);
			DisplayArr(arr);

		}

		static void QuickSort(ref int[] A, int start, int end)
		{
			int pIndex;
			if(start < end)
			{
				pIndex = Partition(ref A, start, end);
				QuickSort(ref A, start, pIndex - 1);
				QuickSort(ref A, pIndex + 1, end);
			}
		}

		static int Partition(ref int[] A, int start, int end)
		{
			int pivot = A[end];
			int pIndex = start;
			for(int i = start; i < end ; i++)
			{
                if (A[i]<=pivot)
                {
					Swap(ref A[i], ref A[pIndex]);
					pIndex++;
                }
            }
			Swap(ref A[pIndex], ref A[end]);
			return pIndex;
		}

		static void Swap(ref int x,  ref int y)
		{
			int temp = x;
			x = y;
			y = temp;
		}

		static void DisplayArr(int[] arr)
		{
			foreach(int  i in arr)
			{
				Console.Write($"{i} ");
			}
			Console.WriteLine();
		}

	}
}
