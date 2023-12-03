using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;

namespace safa
{
    class helloWorld
    {
        static void Main()
        {

            byte b = 1;
            sbyte sb = 4;

            short sh = 4;
            ushort us = 6;

            int a = 3;
            Int16 ba = 4;
            Int32 bc = 5;
            Int64 bd = 1;
            long lg = 1;
            ulong ulg = 46;

            float fl = 2;
            double db = 1.5;
            decimal dc = 3;

            char ch = 'k';
            string sg = "safa";

            bool tr = true;
            bool fls = false;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object obj = 4;
            object obj2 = 'a';
            object obj3 = 3.1;
            object obj4 = "safa";

            string ad = "ali";
            string soyad = "kara";
            string adSoyad = ad + soyad;

            int ab = 1;
            int abb = 4;
            int abbb = ab * abb;

            int int20 = 20;
            string str20 = int20.ToString();
            Console.WriteLine(str20);

            int int30 = 30;
            string str30 = Convert.ToString(int30);

            int int50 = int20 + int.Parse(str30);

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);

        }


    }

}

