using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetQuestion.Example
{
    internal class Ex4
    {
        public void Foo()
        {
            using (var f = new FileStream("1.txt", FileMode.OpenOrCreate))
            {
                f.Write(Encoding.UTF8.GetBytes("1"));
                f.Write(Encoding.UTF8.GetBytes("2"));
            }
        }
        
        public void Bar()
        {
            var f = new FileStream("1.txt", FileMode.OpenOrCreate);
            f.Write(Encoding.UTF8.GetBytes("1"));
            f.Write(Encoding.UTF8.GetBytes("2"));
            
        }
    }
}
