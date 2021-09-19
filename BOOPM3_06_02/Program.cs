using System;

namespace BOOPM3_06_02
{
    public class Stack<T> where T : struct
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

            //var stack1 = new Stack<string>();  // Compiler contraint error
            //stack1.Push("First Element");
            //stack1.Push("Second Element");
            //Console.WriteLine(stack1.Pop());
            //Console.WriteLine(stack1.Pop());

            var stack1 = new Stack<float>();
            stack1.Push(1.234F);
            stack1.Push(5.678F);
            Console.WriteLine(stack1.Pop()); // 5.678
            Console.WriteLine(stack1.Pop()); // 1.234

        }
    }

    //Exercises
    //1.    Modify above code to allow only T as a type of class.
    //2.    Create your own instance of class type and a record type. Use them to close Stack<T>. Test and printout result showing Pop() result
    //3.    Add a constraint that T must have a parameterless construction. Test by declaring only a constructor with parameter.
}
