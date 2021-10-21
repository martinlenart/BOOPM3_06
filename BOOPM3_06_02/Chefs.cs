using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOPM3_06_02
{
    public class Chef
    {
        public string Name { get; set; } = "Boring";
        public virtual string Hello => "I'm boring!";

        public virtual string FavoriteDish => "I have none";

        public Chef() { this.Name = "All the same"; }
        public Chef(string Name)
        {
            this.Name = Name;
        }
    }
    public class FrenchChef : Chef
    {
        public override string Hello => "Bonjour";
        public override string FavoriteDish => "Escargot";
        public override string ToString() => $"{Hello} my name is {Name}";
    }
    public sealed class ItalianChef : Chef
    {
        public override string Hello => "Ciao";
        public override string FavoriteDish => "Pizza";
        public override string ToString() => $"{Hello} my name is {Name}";
    }
    public class SwedishChef : Chef
    {
        public override string Hello => "Hej";
        public override string FavoriteDish => "Meatballs";
        public override string ToString() => $"{Hello} my name is {Name}";

        public SwedishChef() { }
        public SwedishChef(string Name) : base(Name) { }

    }
}
