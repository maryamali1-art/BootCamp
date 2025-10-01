using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Sort
    {// Create a linked list of integers(e.g., 10 → 20 → 30). Traverse and print all nodes.
        public static void Create()
        {
            LinkedList<int> list = new LinkedList<int>(new[] { 10, 20, 30 });
            foreach (int value in list)
            {
                Console.Write(value);
            }
        }
        //2 Write a function to count how many nodes are in the linked list.
        public static void Count()
        {
            LinkedList<int> list = new LinkedList<int>(new[] { 10, 20, 30 });
            Console.WriteLine(list.Count);
        }
        // Search for a given value (e.g., 25) inside the linked list and return its position.
public static void Search()
        {
            LinkedList<int> list = new LinkedList<int>(new[] { 10, 20, 30 });

            Console.WriteLine("Enter the number");
            int num =int.Parse( Console.ReadLine());
            foreach (int value in list)
            {
                if (value==num)
                Console.Write(true);
            }
        }
        // Insert a new node at the head of the linked list.
        public static void InsertAtBeginning()
        {

            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(2);
            list.AddFirst(6);
            list.AddFirst(7);
            foreach (int value in list)
            {
                Console.Write(value);
            }
        }
        // Insert a new node at the tail of the linked list.
        public static void InsertAtEnd()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);
            foreach (int value in list)
            {
                Console.Write(value);
            }
        }
        // Insert a new node at a specific position (e.g., 3rd position).

        // Remove the first node from the list.
        public static void DeleteFirstNode()
        {
            LinkedList<int> list = new LinkedList<int>(new[] { 10, 20, 30 });
            list.RemoveFirst();
            foreach (int value in list)
            {
                Console.Write(value);
            }
        }
        //Delete the first occurrence of a given value(e.g., remove node with value 15).
        public static void DeleteByValue()
        {
            LinkedList<int> list = new LinkedList<int>(new[] { 10, 20, 30 });

            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            foreach (int value in list)
            {
                if (value == num)
                    list.Remove(value);
            }
            foreach (int value in list)
            {
                Console.Write(value);
            }
        }
        // Reverse the linked list so that head becomes tail.
        public static void Reverse()
        {
            LinkedList<int> list = new LinkedList<int>(new[] { 10, 20, 30 });
            list.Reverse();
            foreach (int value in list)
            {
                Console.Write(value);
            }
        }
        // Find and print the middle element of the linked list.
           public static void FindMiddleNode()
        {
            LinkedList<int> list = new LinkedList<int>(new[] { 10, 20, 30, 40 });

            int midIndex = list.Count / 2; 
            int currentIndex = 0;
            foreach (int value in list)
            {
                if (currentIndex == midIndex)
                {
                    Console.WriteLine( value);
                    break;
                }
                currentIndex++;
            }

        }
        //  Write two functions to find the length of the list: one using iteration, one using recursion.
        public static void LengthIterative()
        {
            LinkedList<int> list = new LinkedList<int>(new[] { 10, 20, 30, 40 });
            int count = 0;
            foreach (int value in list)
            {
                count++; 
            }

            Console.WriteLine(count);
        }


        // Check if the linked list is empty before performing operations.
        public static void Empty()
        {
            LinkedList<int> list = new LinkedList<int>();

            if (list.First == null)
            {
                Console.WriteLine("The list is empty.");
            }
            else
            {
                Console.WriteLine("The list contains elements.");
            }

        }
        //Traverse and find the largest and smallest value stored in the linked list.Sort Numbers Use selection sort to sort an array of integers: [5, 2, 9, 1, 7].

        public static void FindMaxMin()
        {
            LinkedList<int> list = new LinkedList<int>(new[] { 10, 25, 5, 40, 15 });

            if (list.Count == 0)
            {
                Console.WriteLine("The list is empty.");
                return;
            }

            int max = list.First.Value;
            int min = list.First.Value;

            foreach (int value in list)
            {
                if (value > max) max = value;
                if (value < min) min = value;
            }

            Console.WriteLine("Maximum value: " + max); 
            Console.WriteLine("Minimum value: " + min);
        }
        public static void SelectionSortInArray()
        {
            int k = 0;
            int[] a;
            a = new int[] { 1, 2, 3, 4, 5 };
            int q = 0;
            int n = a.Length;
            for (int i = 0; i < n - 2; i++)
            {
                k = i;
                for (int j = i + 1; j < n - 1; j++)
                {
                    if (a[j] < a[k])
                    {
                        k = j;
                    }
                }
                if (k != i)
                {
                    q = a[i];
                    a[i] = a[k];
                    a[k] = q;
                }
            }
            Console.WriteLine("Sorted array:");
            foreach (int num in a)
            {
                Console.Write(num + " ");
            }

        }
        //14# Sort Floating-Point Numbers Sort a list of decimal numbers: [3.2, 1.5, 4.7, 2.8].
        public static void SortDecimals()
        {
            double[] arr = { 3.2, 1.5, 4.7, 2.8 };

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                        minIndex = j;
                }
                double temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }

            Console.WriteLine("Sorted decimals:");
            foreach (double num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
        //Sort an array of characters: ['z','b','a','c'].

        public static void SortCharacters()
        {
            char[] arr = { 'z', 'b', 'a', 'c' };

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                        minIndex = j;
                }

                char temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }

            Console.WriteLine("Sorted characters:");
            foreach (char ch in arr)
            {
                Console.Write(ch + " ");
            }
            Console.WriteLine();
        }
        //Sort a list of names: ["Ali", "Sara", "Zain", "Maryam"].
        public static void SortNames()
        {
            string[] names = { "Ali", "Sara", "Zain", "Maryam" };

            for (int i = 0; i < names.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < names.Length; j++)
                {
                    if (string.Compare(names[j], names[minIndex]) < 0)
                        minIndex = j;
                }

                string temp = names[i];
                names[i] = names[minIndex];
                names[minIndex] = temp;
            }

            Console.WriteLine("Sorted names:");
            foreach (string name in names)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();
        }

        // 
        public static int FindSmallest(List<int> arr)
        {
            int Smallest;
            int SmallestIndex;
            Smallest = arr[0];
            SmallestIndex = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] < Smallest)
                {
                    Smallest = arr[i];
                    SmallestIndex = i;
                }

            }
            return SmallestIndex;
        }
        public static void SelectionSort(int[] arr)
        {
            List<int> TempList = arr.ToList();
            List<int> SortedList = new List<int>();

            while (TempList.Count > 0)
            {
                int smallestIndex = FindSmallest(TempList);
                SortedList.Add(TempList[smallestIndex]);
                TempList.RemoveAt(smallestIndex);
            }

            Console.WriteLine("Sorted array:");
            foreach (int num in SortedList)
            {
                Console.Write(num + " ");
            }
        
        }

    }
}
