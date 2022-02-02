using System;

namespace FormeGeometrice
{
    class Program
    {
        static void Main(string[] args)
        {
            Triunghi[] triunghuri = new Triunghi[] {
                new Triunghi(new Punct (1, 1),new Punct(2, 2),new Punct(3, 3)),
                new Triunghi(new Punct (2, 2),new Punct(3, 3),new Punct(4, 4)) };

            GeometryUtils.Translate(1, 1, triunghuri);
            for (int i = 0; i < triunghuri.Length; i++)
            {
                Console.WriteLine(triunghuri[i].A.x);
                Console.WriteLine(triunghuri[i].A.y);
                Console.WriteLine(triunghuri[i].B.x);
                Console.WriteLine(triunghuri[i].B.y);
                Console.WriteLine(triunghuri[i].C.x);
                Console.WriteLine(triunghuri[i].C.y);
            }
        }
    }
}
