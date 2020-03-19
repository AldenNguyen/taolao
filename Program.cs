using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace in_ra_chuoi_cac_so_nguyen_to
{
    class Program
    {
        static void Main(string[] args)
        {
            int so;
            Console.WriteLine("IN CHUOI CAC SO NGUYEN TO");
            Console.WriteLine("Nhap vao mot so:");
            so = Convert.ToInt32(Console.ReadLine());
            if (check1(so) != 2 )
            {
                Console.WriteLine("So nhap vao khong phai la so nguyen to");                
            }
            else
            {
                System.Console.WriteLine("Chuoi cac so nguyen to la:");
                for (int i=1; i<=so; i++)
                {
                    if (check1(i) == 2)
                    {
                        System.Console.WriteLine(i);
                    }
                }
            }
            Console.ReadKey();
        }
        static int check1(int so)
        {
            int dem = 0;
            for (int i=1 ; i<=so ; i++)
            {
                if (so % i == 0)
                {
                    dem++;
                }
            }
            return dem;
        }
    }
}
