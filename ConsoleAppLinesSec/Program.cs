using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLinesSec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inf = "информатика";
            string infOne = "";
            
            
            inf = inf.Remove(6, 1);    //индекс - кол-во 
            inf = inf.Insert(6, "а ");   //индекс и замена
            
            infOne = inf.Substring(2, 9);

            
            Console.WriteLine(infOne);

            Console.ReadKey();


            //infOne = inf.Substring(2, 5);
            //infTwo = inf.Substring(6, 9);
            //string infSec = inf.Substring(7, 9);


            //inf = inf.Remove(0, 2);

            /*inf = inf.Remove(5, 6);
            inf = inf.Insert(6, "а ");*/

            /*inf = inf.Remove(10);
            inf = inf.Remove(0, 2);
            inf = inf.Remove(3, 3);*/

            //Console.WriteLine(infOne + infTwo);

            
        }
    }
}
