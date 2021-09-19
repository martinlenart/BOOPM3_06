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

    record ArrayRecord<T> (T[] MyArray);

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

            ArrayRecord<int> arrayRecord = new ArrayRecord<int> (MyArray:new int[] { 1, 2, 3 } );
        }
    }

    //Exercises
    //1.    Use List<T> to Create one list of type int, one list of type string and one list of type tuple. Loop through and printout
    //2.    Create a member in ArrayRecord<T> to printout the content of the MyArray. Try close the generic T with different types.
    //3.    Create struct ArrayStruct<T>, class ArrayClass<T> with a nested array of type T. Initialize, loop through and printout 


    //
    //
    //class type and create a List of that Type. Implement IEquality<T> on your class type and 
    //      compare some of your instances.
}
