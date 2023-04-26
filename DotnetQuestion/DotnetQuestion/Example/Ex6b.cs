using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetQuestion.Example
{
    internal class Ex6b
    {
        public class Test 
        {
            public string Text { get; set; }
        }

        public Test Foo()
        {
            var tmp = new Test { Text = "OLO!" };
            try
            {
                return tmp;
            }
            catch(Exception ex)
            {
                tmp.Text = "HEHE!";
                return tmp;
            }
            finally
            {
                tmp.Text = "ОЙ что это??:";
            }
        }

    }
}
