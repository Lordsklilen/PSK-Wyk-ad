using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Person
    {
        string nameString;
        static List<string> list = new List<string>() { "Michał", "Adam", "Bartek", "Weronika" };
        static int next;

        public Person(){
            nameString = list[next++];
        }
        public string Name()
        {
            return nameString;
        }
    };
}
