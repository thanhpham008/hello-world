﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new AA();
            Console.Write(a==true);
        }
    }
    class AA
    {
        public AA()
        {
            throw new NotImplementedException();
        }
    }
}
