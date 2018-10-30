using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Employee
    {
        private Store storeMember;
        private string name;
        private int age;
        private static long id;
        
        static long getId()
        {
            return id;
        }

        public void setInfo( string name, int age )
        {
            this.age = age;
            this.name = name;
        }

        public void setStoreMember( Store storeMember )
        {
            this.storeMember = storeMember;
        }

        public string getName()
        {
            return name;
        }

        public void printInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("ID: " + id);
        }
    }
}
