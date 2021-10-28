﻿using System;
using System.Collections.Generic;

namespace BOOPM3_06_03
{
    public enum CarMake { BMW, Honda, Jaguar, Volvo}
    public class Car : IEquatable<Car>, IComparable<Car>
    {
        public CarMake Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public override string ToString()
        {
            return $"A {Make} {Model} of year {Year}";
        }

        #region Implementation of IEquatable<T> interface
        public bool Equals(Car car) => (this.Make, this.Model, this.Year) == (car.Make, car.Model, car.Year);

        //Needed to implement as part of IEquatable
        public override int GetHashCode() => (Make, Model, Year).GetHashCode();
        public override bool Equals(object obj) => Equals(obj as Car);
        #endregion

        #region operator overloading
        public static bool operator ==(Car c1, Car c2) => c1.Equals(c2);
        public static bool operator !=(Car c1, Car c2) => !c1.Equals(c2);
        #endregion

        #region Implementation IComparable<T> interface
        public int CompareTo(Car c1)
        {
            //Sort on Make -> Model -> Year
            if (Make != c1.Make)
                return Make.CompareTo(c1.Make);
            else if (Model != c1.Model)
                return Model.CompareTo(c1.Model);
            else
                return Year.CompareTo(c1.Year);
        }
        #endregion
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hash codes");
            var k = 5;
            Console.WriteLine(k.GetHashCode());

            var s = "hello";
            Console.WriteLine(s.GetHashCode());

            s = "heLlo";
            Console.WriteLine(s.GetHashCode());

            //Find with IEquatable interface
            Console.WriteLine("\nIEquatable");
            Car c1 = new Car { Make = CarMake.BMW, Model = "3 series", Year = 2021 };
            Car c2 = new Car { Make = CarMake.Volvo, Model = "V70", Year = 2020 };
            Car c3 = new Car { Make = CarMake.Honda, Model = "Civic", Year = 2019 };
            Car c4 = new Car { Make = CarMake.Volvo, Model = "V70", Year = 2020 };

            Console.WriteLine(c2.Equals(c4)); //true
            Console.WriteLine(c2.Equals(c3)); //false

            Console.WriteLine(c2 == c4); //true
            Console.WriteLine(c2 == c3); //false


            //Implementing List<T>
            Console.WriteLine("\nList<Car>");
            List<Car> cars = new List<Car>();
            cars.Add(c1);
            cars.Add(c2);
            cars.Add(c3);
            cars.Add(new Car { Make = CarMake.Jaguar, Model = "XF", Year = 2009 });
            foreach (var item in cars)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            bool found = cars.Contains(c4);
            Console.WriteLine(found);   //false

            //Find the old fashioned way
            Console.WriteLine("\nFind the old fashioned way"); 
            Car cFound1 = null;
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i]==c4)
                {
                    cFound1 = cars[i];
                }
            }
            Console.WriteLine(cFound1);

            //Find the lambda way
            Console.WriteLine("\nFind the lambda way");
            Car cFound2 = cars.Find(x => x == c4);
            Console.WriteLine(cFound2);

            //Sort with IComparable Interface
            Console.WriteLine("\nSort with IComparable Interface");
            cars.Sort();
            foreach (var item in cars)
            {
                Console.WriteLine(item);
            }

        }
    }

    //Excercises:
    //1.    Implement IEquatable<T> for PlayingCard. Create two instances and test it
    //2.    Overload the "==" and "!=" operators to using Equals(). Test and Printout result
    //3.    Implement IEquatable<T> on Chef and make two Chef instances Equal if they have the same name regardless of child type,
    //      - Overload the == and != operators and create two instance to test it

    //4.    Implement IComparable<T> for PlayingCard. Create two instances and test it

    //5.    Change the array of Stack<Chef> in BOOP3_06_02 exercise 4 and 5 to List<T> (System.Collections.Generic) and fill the lists with instances
    //6.    - Set a variable, findChef, of type Chef to an instance with a certain name
    //      - Loop through the array of List<Chef> and search for first chef that is equals findChef
    //7.    Refracture exercise 6 into a Method
}
