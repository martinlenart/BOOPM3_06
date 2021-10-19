using System;

namespace BOOPM3_06_01
{
    public class Stack<T>
    {
        int position;
        T[] data = new T[100];
        public void Push(T obj) => data[position++] = obj;
        public T Pop() => data[--position];
    }

    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<int>();
            stack.Push(5);
            stack.Push(10);
            Console.WriteLine(stack.Pop()); // 10
            Console.WriteLine(stack.Pop()); // 5

            var stack1 = new Stack<string>();
            stack1.Push("First Element");
            stack1.Push("Second Element");
            Console.WriteLine(stack1.Pop()); // Second Element
            Console.WriteLine(stack1.Pop()); // First Element

            DoDoublePush(stack1);
            Console.WriteLine(stack1.Pop()); 
            Console.WriteLine(stack1.Pop()); 

            bool[] boolArray = { true, true, true, false, false, false };
            PrintFirstElement<bool>(boolArray);
        }

        //Method using a closed Generic type
        static void DoDoublePush(Stack<string> myStack) 
        {
            myStack.Push("First push");
            myStack.Push("Second push");
        }

        //Method using an open Generic type as an array parameter
        static void PrintFirstElement<T>(T[] myArray)
        {
            foreach (var item in myArray)
            {
                Console.WriteLine(item);
            }
        }
    }

    //Exercises
    //1.    -Create an array of type int[] and initializa it with some value.
    //      -Create a Method that takes int[] as a parameter, loops through the array and print out the values
    //      -Create another array of string[] and a method that loops through the array and print out the values. 
    //      -Notice the small difference in the Methods
    //2.    -Using DRY, make one single method which is using a Generic Parameter T that prints out both arrays
    //3.    -Use the same Method to print out an array of the type PlayingCard
}
