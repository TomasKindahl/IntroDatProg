﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random R = new Random();
            int[] rval = new int[10];
            for (int i = 0; i < 10; i++)
            {
                rval[i] = R.Next(1, 11);
            }
            for (int i = 1; i < 10; i = i * 2)
            {
                Console.WriteLine("{0}: {1}", i, rval[i]);
            }
        }
    }
}
