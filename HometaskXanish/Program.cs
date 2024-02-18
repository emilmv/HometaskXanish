// See https://aka.ms/new-console-template for more information
using System.Buffers;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks.Sources;

Console.WriteLine("Hello, World!");
#region Task1
//Array icinde olan murekkeb ededlerin ededi ortasi

//int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//double sum = 0;
//double count = 0;

//foreach (var item in arr)
//{
//	bool isPrime = false;
//	for (int i = 2; i < item; i++)
//	{
//		if (item % i == 0)
//		{
//			isPrime = true;
//			count++;
//			break;
//		}
//	}
//	if (isPrime)
//	{
//		sum += item;
//	}
//}
//Console.WriteLine(sum/count);

#endregion
#region Task2
//array icinde en cox tekrarlanan eded

//int[] arr = { 2, 2, 5, 5, 5 };
//int maxcount = 0;
//int maxFreq = 0;

//for (int i = 0; i < arr.Length; i++)
//{
//    int count = 0;
//    for (int j = 0; j < arr.Length; j++)
//    {
//        if (arr[i] == arr[j])
//        {
//            count++;
//        }
//    }
//    if(count > maxcount)
//    {
//        maxcount= count;
//        maxFreq = arr[i];
//    }
//}
//Console.WriteLine(maxFreq);
#endregion
#region Task3
// array icinde unique eded

//int[] arr = { 1, 1, 2, 2, 3, 3, 4, 4, 5, 10, 10 };
//bool isPrime = true;
//for (int i = 0; i < arr.Length; i++)
//{
//    isPrime= true;
//    for (int j = 0; j < arr.Length; j++)
//    {
//        if (i != j && arr[i] == arr[j])
//        {
//            isPrime= false;
//            break;
//        }
//    }
//    if (isPrime)
//    {
//        Console.WriteLine(arr[i]);
//    }
//}
#endregion