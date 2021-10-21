using System;

namespace BOOPM3_06_02
{
    public class Stack<T> where T: struct
    {
        int position = 0;
        T[] data = new T[100];

        public void Push(T value)
        {
            data[position] = value;
            position++;
        }
        public T Pop()
        {
            --position;
            return data[position];
        }
        public T Peek()
        {
            return data[position - 1];
        }
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
    //2.    Create your own instance of class type (For example Chef). Use them to close Stack<T>. Test and printout result showing Pop() result
    //3.    Add a constraint that T must have a parameterless construction. Test by declaring only a constructor with parameter.
    //4.    Create an array of Stack<Chef> which contains 3 Stacks. Initiate each stack with instances of SwedishChef, ItalianChef, FrenchChef.
    //5.    Printout the top element of each Stack<Chef> by looping through the array of Stack<Chef>
}
