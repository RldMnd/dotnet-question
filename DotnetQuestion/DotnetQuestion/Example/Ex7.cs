using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DotnetQuestion.Example
{
    internal class Ex7
    {
        class User
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Group { get; set; }
        }

        List<User> users = new List<User>();
        public void Foo()
        {
            IEnumerable users2 = users.Distinct();
            IEnumerable users3 = users.DistinctBy(u=>u.Name);
        }
        
        public void Populate ()
        {
            users.Clear();
            users.Add(new User { Id = 1, Name="Иван", Group=2 }) ;
            users.Add(new User { Id = 2, Name="Петр", Group=1 }) ;
            users.Add(new User { Id = 3, Name="Петр", Group=2 }) ;
        }
    }
}
