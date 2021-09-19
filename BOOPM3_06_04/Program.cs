using System;

namespace BOOPM3_06_04
{
    //Base class or Parent class. 
    public class Shape : IEquatable<Shape>
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public virtual bool Equals(Shape s1) => throw new NotImplementedException();
    }
    // Triangle is derived from Shape.  
    public class Triangle : Shape, IEquatable<Shape>, IComparable<Triangle>
    {
        public double Area => Width * Height / 2;
        public override bool Equals(Shape t1) => (this.Width, this.Height) == (t1.Width, t1.Height);

        //Implement IComparable<>
        public int CompareTo(Triangle other) => Area.CompareTo(other.Area);

        //Needed to implement as part of IEquatable
        public override int GetHashCode() => (Width, Height).GetHashCode();  
        public override bool Equals(object obj) => Equals(obj as Triangle); 

    }
    // Rectangle is derived from Shape
    public class Rectangle : Shape, IEquatable<Shape>, IComparable<Rectangle>
    {
        public double Area => Width * Height;
        public override bool Equals(Shape r1) => (this.Width, this.Height) == (r1.Width, r1.Height);

        //Implement IComparable<>
        public int CompareTo(Rectangle other) => Area.CompareTo(other.Area);

        //Needed to implement as part of IEquatable
        public override int GetHashCode() => (Width, Height).GetHashCode();  
        public override bool Equals(object obj) => Equals(obj as Rectangle);
    }
    class Program
    {
        static void Main(string[] args)
        {
            var r1 = new Rectangle() { Height = 100, Width = 200 };
            var r2 = new Rectangle() { Height = 50, Width = 200 };
            Console.WriteLine(r1.Equals(r2));       // False
            Console.WriteLine(r1.CompareTo(r2));    // 1
            Console.WriteLine(r2.CompareTo(r1));    // -1

            var t1 = new Triangle() { Height = 50, Width = 200 };
            var t2 = new Triangle() { Height = 50, Width = 200 };
            Console.WriteLine(t1.Equals(t2));       // True
            Console.WriteLine(t1.CompareTo(t2));    // 0
        }
    }

    //Excercises:
    //1.    Overload the "<", "<=", ">", and ">=" operators. Test
    //2.    In BOOPM3_05_02 make sure IWine forces the user to implement IComparable<T>
    //3.    In BOOPM3_05_02 Implement IComparable in WineStruct and WineClass

}
