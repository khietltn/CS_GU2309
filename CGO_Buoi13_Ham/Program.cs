using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi13_Ham
{
    class Program
    {
        /// <summary>
        ///  Hàm hoán vị giá trị cho 2 số
        /// </summary>
        /// <param name="a"> tham so 1</param>
        /// <param name="b"> tham so 2</param>
        static void swap(ref int a, int b)
        {
            Console.WriteLine("begin func: a={0}, b={1}", a, b);
            int t = a; a = b; b = t; 
            //neu co ref thi gia tri se duoc su dung tiep, nguoc lai thi gia tri se duoc tra ve nguyen ban
            Console.WriteLine("end func: a={0}, b={1}", a, b);
        }
        /// <summary>
        /// Ham kiem tra lenh swap
        /// </summary>
        static void Test1()
        {
            int a = 3, b = 5;
            Console.WriteLine("begin main: a={0}, b={1}", a, b);
            swap(ref a,  b);
            Console.WriteLine("end main: a={0}, b={1}", a, b);
        }
        static void Main(string[] args)
        {
            List<int> lst = new List<int> { 1, 2, 3, 4, 5, 6,1 ,7 };
            int value = 1;
            while(lst.IndexOf(value) >= 0)
            {
                lst.Remove(value);
            }
            Console.WriteLine(string.Join(" ", lst));
            Console.ReadKey();
        }

        
        private static int TinhTong(int v1, int v2=0, int v3=0)
        {
            return v1 + v2 + v3;
        }
        static void TinhTong(int a, int b, ref int tong)
        {
            tong = a + b;
        }
       
        static int UCLN(int a, int b)
        {
            while ( a*b != 0)
            {
                if (a > b) a %= b;
                else b %= a;
            }
            return a + b;
        }
        static int gcd(int a, int b)
        {
            if (b == 0) return a;
            return gcd(b, a % b); //0 < a
        }
        /***
         * - Viết hàm cho bài toán Fibonacy
	            f(n) = f(n-1) + f(n-2)
	            f(1) = 1
            - Viết hàm truy hồi dãy số
	            f(1)= -2
	            f(n)= 3 f(n-1) -1
         * **/
        static int fib(int n)
        {
            if (n <=1) return 1;
            return fib(n - 1) + fib(n - 2);
        }
        //fib(3) = fib(2) + fib(1) = [fib(1) + fib(0)] + fib(1)
        static int dayso(int n)
        {
            Math.Min(3, 4);
            if (n == 1) return -2;
            return 3 * dayso(n - 1) - 1;
        }
    }
}
