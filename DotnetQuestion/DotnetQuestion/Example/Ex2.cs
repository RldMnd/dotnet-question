using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetQuestion.Example
{
    internal class Ex2
    {
        public class ClassA
        {
            public void Foo()
            {
                Console.WriteLine("BAR");
            }
        }

        public class ClassB : ClassA
        {
            public override void Foo()
            {
                Console.WriteLine("222");
            }
        }

        public class ClassC : ClassA
        {
            public new void Foo()
            {
                Console.WriteLine("333");
            }
        }
    }
}
