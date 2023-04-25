using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetQuestion.Example
{
    internal class Ex1_GC_
    {
        public static void Task1()
        {
            var sum = 0;
            for (var i = 0; i <= 10; i++;){
                var j = i * 2;
                sum += i;
            }
            Console.WriteLine(j);
            Console.WriteLine(sum);
        }
    }
}
