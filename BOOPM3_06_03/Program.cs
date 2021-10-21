using System;

namespace BOOPM3_06_03
{
    public class Car : IEquatable<Car>
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }

        // Implementation of IEquatable<T> interface
        public bool Equals(Car car) => (this.Make, this.Model, this.Year) == (car.Make, car.Model, car.Year);

        //Needed to implement as part of IEquatable
        public override int GetHashCode() => (Make, Model, Year).GetHashCode();
        public override bool Equals(object obj) => Equals(obj as Car);
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car { Make = "Volvo", Model = "V70", Year = "2020" };
            Car c2 = new Car { Make = "Volvo", Model = "V70", Year = "2020" };
            Car c3 = new Car { Make = "Volvo", Model = "V70", Year = "2019" };

            Console.WriteLine(c1.Equals(c2)); //true
            Console.WriteLine(c2.Equals(c3)); //false
        }
    }

    //Excercises:
    //1.    Overload the "==" and "!=" operators to using Equals(). Test and Printout result
    //2.    Implement IEquatable<T> for PlayingCard. Create two instances and test it
    //3.    Implement IComparable<T> for PlayingCard. Create two instances and test it

    //4.    Implement IEquatable<T> on Chef and make two Chef instances Equal if they have the same name regardless of child type,
    //      - Overload the == and != operators and create two instance to test it

    //5.    Change the array of Stack<Chef> in BOOP3_06_02 exercise 4 and 5 to List<T> (System.Collections.Generic) and fill the lists with instances
    //6.    - Set a variable, findChef, of type Chef to an instance with a certain name
    //      - Loop through the array of List<Chef> and search for first chef that is equals findChef
    //7.    Refracture exercise 6 into a Method
}
