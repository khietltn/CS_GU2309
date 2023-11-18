using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi19
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> lst = new List<Animal>();
            lst.Add(new Tiger());       //animals[0] class Animal
            lst.Add(new Chicken());     //animals[1] class Animal

            foreach (Animal item in lst)
            {
                Console.WriteLine(item.MakeSound()); //đa hình: item là lớp cha, MakeSound gọi hàm lớp con
            }


            Console.ReadKey();
        }
    }
}
