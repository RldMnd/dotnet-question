using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetQuestion.Example
{
    internal class Ex5
    {
        public void Foo()
        {
            try
            {
                using (var f = new FileStream("1.txt", FileMode.OpenOrCreate))
                {
                    f.Write(Encoding.UTF8.GetBytes("1"));
                    f.Write(Encoding.UTF8.GetBytes("2"));
                    throw new Exception();
                }
            }
            catch
            {

            }
        }

        public void Bar()
        {
            try
            {
                var f = new FileStream("1.txt", FileMode.OpenOrCreate);
                f.Write(Encoding.UTF8.GetBytes("1"));
                f.Write(Encoding.UTF8.GetBytes("2"));
                throw new Exception();
            }
            catch { 
            }

        }
    }
}
