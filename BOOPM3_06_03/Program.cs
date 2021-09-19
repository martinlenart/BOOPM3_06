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
    //2.    In BOOPM3_05_02 make sure IWine forces the user to implement IEquatable<T>
    //3.    In BOOPM3_05_02 Implement IEquatable in WineStruct and WineClass
}
