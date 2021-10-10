using System;
using Xrandom;

namespace Proxy_using
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte a;
            short b;
            int c;
            long d;
            float e;
            double f;
            decimal g;
            bool h;

            byte aa;
            ushort bb;
            uint cc;
            ulong dd;

            XRandom rnd = new XRandom(63521);
            Random random = new Random();

            for (; ; )
            {
                Console.WriteLine(Math.Round(rnd.Double()));
                Console.ReadKey();
            }
        }
    }
}