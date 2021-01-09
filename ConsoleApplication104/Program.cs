using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication104
{
    class Program
    {
     public static void Main(string[] args)
    {
        string x;
        string name, contactno;
        int order, orderno;
        int[] array = new int[10];
        Program.Menu();
        StringBuilder custInfo = new StringBuilder();
        do
        {
        Console.Write("ORDER NO: ");
        orderno = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Name: ");
        name = Console.ReadLine();
        custInfo.Append("\nName: "+name);
        Console.Write("Enter Contact Number: ");
        contactno = Console.ReadLine();
        custInfo.Append("\nContact Number: "+contactno);
        Console.Write("Enter Coffee Number: ");
        order = Convert.ToInt32(Console.ReadLine());
        custInfo.Append("\nCoffee Number: "+order);
            if (order == 1)
            {
                array[orderno] = 500;
                custInfo.Append("\nCoffee Bill: " + 500);
            }
            else if (order == 2)
            {
                array[orderno] = 400;
                custInfo.Append("\nCoffee Bill: " + 400);
            }
            else if (order == 3)
            {
                array[orderno] = 300;
                custInfo.Append("\nCoffee Bill: " + 300);
            }
            else if (order == 4)
            {
                array[orderno] = 200;
                custInfo.Append("\nCoffee Bill: " + 200);
            }
            else
                Console.WriteLine("Invalid no");
       
        Console.Write("Do u want to continue");
        x = Console.ReadLine();
        custInfo.Append("\n\n");
        }while (x=="y");
        Console.WriteLine(custInfo);
        
        var sortedArr = MergeSort(array, 0, orderno);

        Console.WriteLine("Sorted bill: [{0}]", string.Join(", ", sortedArr));
        Console.WriteLine();
    }

     public static void Menu()
     {
         Console.WriteLine("<<----Coffee Shop---->>");
         Console.WriteLine("   COFFEE  \t\t\t\t   PRICE");
         Console.WriteLine(" 1) MOCHA \t\t\t Rs:500");
         Console.WriteLine(" 2) AMERICANO \t\t\t Rs:400");
         Console.WriteLine(" 3) MILK COFFEE \t\t Rs:300");
         Console.WriteLine(" 4) BLACK COFFEE \t\t Rs:200");
     }
    private static int[] MergeSort(int[] array, int start, int end)
    {
        if (start < end)
        {
            int middle = (end + start) / 2;
            int[] leftArr = MergeSort(array, start, middle);
            int[] rightArr = MergeSort(array, middle + 1, end);
            int[] mergedArr = MergeArray(leftArr, rightArr);
            return mergedArr;
        }
        return new int[] { array[start] };
    }

    private static int[] MergeArray(int[] leftArr, int[] rightArr)
    {
        int[] mergedArr = new int[leftArr.Length + rightArr.Length];

        int leftIndex = 0;
        int rightIndex = 0;
        int mergedIndex = 0;

        // Traverse both arrays simultaneously and store the smallest element of both to mergedArr
        while (leftIndex < leftArr.Length && rightIndex < rightArr.Length)
        {
            if (leftArr[leftIndex] < rightArr[rightIndex])
            {
                mergedArr[mergedIndex++] = leftArr[leftIndex++];
            }
            else
            {
                mergedArr[mergedIndex++] = rightArr[rightIndex++];
            }
        }

        // If any elements remain in the left array, append them to mergedArr
        while (leftIndex < leftArr.Length)
        {
            mergedArr[mergedIndex++] = leftArr[leftIndex++];
        }

        // If any elements remain in the right array, append them to mergedArr
        while (rightIndex < rightArr.Length)
        {
            mergedArr[mergedIndex++] = rightArr[rightIndex++];
        }

        return mergedArr;
    }
}}
  