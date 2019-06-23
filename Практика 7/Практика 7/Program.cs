using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_7
{
    class Program
    {
        static void Main(string[] args)
        {

            int n, k;
            String s;
            Console.WriteLine("Введите n");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите k");
            k = int.Parse(Console.ReadLine());
            s = "";
            string s1 = "";

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    
                    
                        s = i.ToString() + j.ToString();
                        s1 = s1 + s + ", ";
                    
                   
                }
                s = "";

            }
            Console.WriteLine(s1);
           
            Console.Read();
        }
    }
}
