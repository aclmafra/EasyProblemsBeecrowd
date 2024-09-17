using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeecrowdC_Iniciante.FirstExercises {
    internal class _1005Media1 {
        static void Main() {

            double A, B, MEDIA;

            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());

            MEDIA = ((A * 3.5) + (B * 7.5)) / 11;

            Console.WriteLine("MEDIA = " + MEDIA.ToString("F5"));
        }
    }
}
