using System;
using System.Threading;
namespace Array
{
    class program
    {
        static void Main(string[] args)
        {
            int[] Tal = new int[5];
            Tal[0] = 148;
            Tal[1] = 669;
            Tal[2] = -137;
            Tal[3] = 734;
            Tal[4] = 999;
            
            string[] d = new string[10000];

            for (int i = 0; true; i++)
            {
                
                string c = Tal[i].ToString();
                 d[i] = c;
                
                Console.Write(d[i]);
                Thread.Sleep(5000);
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                
              
            }
        }
    }
}