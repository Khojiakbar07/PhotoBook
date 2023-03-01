// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Developed by CashOverflow Team
// --------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Photobook photo1 = new Photobook();
            Console.WriteLine(photo1.GetNumberPages());

            Photobook photo2 = new MiddlePhoto();
            Console.WriteLine(photo2.GetNumberPages());

            Photobook photo3 = new BigPhotoBook();
            Console.WriteLine(photo3.GetNumberPages());

            Console.ReadLine()

            Console.WriteLine("Hello World")

        }
    }
}
