using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetQuestion.Example
{
    internal class Ex6
    {
        class MyExcept : Exception
        {
            public int id { get; set; }
        }

        class AnotgerEx : MyExcept
        {            
            public string name { get; set; }
        }

        public void First()
        {
            try
            {
                throw new AnotgerEx { id=2, name = "БУГОГА" };
            }
            catch(MyExcept ex)
            {
                Console.WriteLine(ex.id);
            }
        }

        public void Second()
        {
            try
            {
                throw new AnotgerEx { id = 2, name = "БУГОГА" };
            }
            catch (AnotgerEx ex)
            {
                Console.WriteLine(ex.name);
            }
            catch (MyExcept ex)
            {
                Console.WriteLine(ex.id);
            }
        }
        public void Third()
        {
            try
            {
                var ex = new AnotgerEx { id = 2, name = "БУГОГА" };
                throw (Exception)ex;
            }
            catch (AnotgerEx ex)
            {
                Console.WriteLine(ex.name);
            }
            catch (MyExcept ex)
            {
                Console.WriteLine(ex.id);
            }
        }
    }
}
