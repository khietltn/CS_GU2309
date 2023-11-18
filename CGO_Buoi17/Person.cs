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

        public virtual void Show()
        {
            Console.WriteLine("Name={0}", Name);
        }
        public override string ToString()
        {
            return string.Format("Name={0}", Name);
                //base.ToString();
        }
    }
    //TH1. Lớp con ko có hàm -> sài hàm của lớp cha
    //TH2. Lớp con có hàm riêng trùng tên hàm lớp cha (warning!)-> ưu tiên gọi hàm lớp con
    //TH3. Lớp con muốn ghi đè (định nghĩa lại hàm lớp cha) -> virtual (lớp cha), override (lớp con) -> mất warning!
    //TH4. Lớp con tái sử dụng nội dung định nghĩa hàm của lớp cha -> base
    class Citizen: Person
    {
        private string ID;
        private string location;

        public Citizen(string name, string location): base(name)
        {
            this.Location = location;
        }

        public string Location { get => location; set => location = value; }

        public override void Show()
        {
            base.Show();
            //Console.WriteLine("Name={0}", Name);
            Console.WriteLine("Location={0}", Location);
        }
        public override string ToString()
        {
            return string.Format(base.ToString()+" Location={0}", Location);
        }
    }
}
