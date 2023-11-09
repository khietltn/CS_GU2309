using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi17
{
    class Person
    {
        private string name;

        public Person(string name="Noname")
        {
            this.Name = name;
        }

        public string Name { get => name; set => name = value; }

        public void Show()
        {
            Console.WriteLine("Name={0}", Name);
        }
    }
    class Citizen: Person
    {
        string location;

        public Citizen(string name, string location): base(name)
        {
            this.location = location;
        }
        public void Show()
        {
            //base.Show();    //cau lenh lop cha
            Console.WriteLine("Location={0}",location);
        }
    }
}
