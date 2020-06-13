using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraksion
{
    class Program
    {
        static void Main(string[] args)
        {
            ruang2d ruang2d;
            ruang2d = new kotak();
            ruang2d.gambar();

            Console.ReadKey();
        }
    }
}
