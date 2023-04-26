using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetQuestion.Example
{
    internal class Ex6a
    {
        public int num = 6;

        public int FOO()
        {
            try
            {
                return num;
            }
            catch(Exception ex)
            {
                num = 7;
            }
            finally
            {
                num = 100;
            }
            return -10;
        }
    }
}
