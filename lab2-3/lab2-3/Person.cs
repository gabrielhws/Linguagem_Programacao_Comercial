using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_3
{
    public abstract class Person
    {
        String _name;
        String _age;

        public Person() { }

        public abstract void Save();
        public virtual void Travel()
        {
            Console.WriteLine("Method Travel called in class Person");
        }
    }
}
