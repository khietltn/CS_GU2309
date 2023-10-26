using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi07
{
    class Program
    {
        //Ctrl M L
        static void Main(string[] args)
        {
            Random rd = new Random();
            int n = 10; int[] a = new int[n];
            //Sinh mang ngau nhien (ket hop random)
            //Sinh mang ngau nhien ko trung lap du lieu!!!
            for (int i = 0; i < a.Length; i++) { 
                int temp = rd.Next(1, 11);
                if (a.Contains(temp)) i--;
                else a[i] = temp;
            }
        
            //Duyet phan tu mang
            Console.WriteLine(string.Join(" ", a));
            int dem_cp = 0;
            foreach (int item in a)
            {
                //Xy ly so nguyen to
                if (item > 1)
                {
                    if (item == 2 || item == 3)
                        Console.Write(item + " ");
                    else
                    {
                        if (item%2 != 0)
                        {
                            bool flag = true;
                            for(int i=3; i <= Math.Sqrt(item); i += 3)
                            {
                                if(item % i == 0)
                                {
                                    flag = false; break;
                                }
                            }
                            if (flag) Console.Write(item + " ");
                        }
                    }
                }

                //Xy ly so chinh phuong
                int b = (int)Math.Sqrt(item);
                if (b * b == item) dem_cp++;
            }
            Console.WriteLine("\nSo luong so chinh phuong: " + dem_cp);
            //Console.WriteLine("\nDuyet lenh khac");
            //
            Console.ReadKey();
        }
        static void Cau01()
        {
            Console.WriteLine("ket thuc chuong trinh");
        }

        static void Cau02()
        {
            Console.WriteLine("ket thuc chuong trinh");
        }

        private static void Menu()
        {
            short choice = -1;

            #region Xu ly lua chon
            while (choice != 0)
            {
                #region  Hien thi menu
                Console.WriteLine("Menu");
                Console.WriteLine("1. Draw the triangle");
                Console.WriteLine("2. Draw the square");
                Console.WriteLine("3. Draw the rectangle");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Enter your choice: ");
                choice = short.Parse(Console.ReadLine());
                #endregion

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Draw the triangle");
                        Console.WriteLine("******");
                        Console.WriteLine("*****");
                        Console.WriteLine("****");
                        Console.WriteLine("***");
                        Console.WriteLine("**");
                        Console.WriteLine("*");
                        break;
                    case 2:
                        Console.WriteLine("Draw the square");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        break;
                    case 3:
                        Console.WriteLine("Draw the rectangle");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        break;
                    case 0:
                        //return;
                        Environment.Exit(0);//return có thể được dùng cho hàm
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                }
            }
            #endregion
        }
    }
}
