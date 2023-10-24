using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi05
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("{0:2f}", 1.0 / 3);
            int tuoi =-1;        //while , do _ while
            int luot_dem = 3;   //vi du chi duoc nhap 3 lan
        nhap_du_lieu:
            Console.Write("Nhap tuoi: ");
            //tuoi = int.Parse(Console.ReadLine());
            if (int.TryParse(Console.ReadLine(), out tuoi) && tuoi >0 && tuoi <=120){
                //Xu ly du lieu tuoi
                Console.WriteLine("Tuoi da nhap la " + tuoi);
                Console.WriteLine("So ngay da song la: {0}", tuoi*365); //Hoan tat yeu ve DUNG
            }else {
                luot_dem--;
                if(luot_dem == 0)
                {
                    Console.WriteLine("Qua so lan thu lai!");
                    
                    goto nhiem_vu;
                }
                Console.WriteLine("Tuoi da nhap ko hop le. Luot nhap con lai {0}. Moi ban nhap lai.!", luot_dem);
                goto nhap_du_lieu;
            }
        nhiem_vu:
            Console.WriteLine("======================================");
            Console.ReadKey();
        }
    }
}
