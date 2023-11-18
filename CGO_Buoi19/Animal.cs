using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi19
{
    public abstract class Animal
    {
        public abstract string MakeSound(); //hàm đa hình , hàm trừu tượng !!!
    }

    public class Tiger : Animal
    {
        public override string MakeSound()
        {
            return "Tiger: hummmm!";
        }
    }
    /// <summary>
    /// 
    /// </summary>
    //
    public class Chicken : Animal
    {
        public override string MakeSound()
        {
            return "Chicken: cuc tac cuc to!";
        }
    }

}
