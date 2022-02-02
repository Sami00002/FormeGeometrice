using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormeGeometrice
{
    public static class GeometryUtils
    {
        public static void Translate(int ox, int oy, Triunghi[] triunghiuri)
        {
            for(int i=0; i < triunghiuri.Length; i++)
            {
                triunghiuri[i].A.x = triunghiuri[i].A.x + ox;
                triunghiuri[i].A.y = triunghiuri[i].A.y + oy;
                triunghiuri[i].B.x = triunghiuri[i].B.x + ox;
                triunghiuri[i].B.y = triunghiuri[i].B.y + oy;
                triunghiuri[i].C.x = triunghiuri[i].C.x + ox;
                triunghiuri[i].C.y = triunghiuri[i].C.y + oy;
            }
        }
        public static void Translate(int ox, int oy, Dreptunghi[] dreptunghiul)
        {
            for (int i = 0; i < dreptunghiul.Length; i++)
            {
                dreptunghiul[i].A.x = dreptunghiul[i].A.x + ox;
                dreptunghiul[i].A.y = dreptunghiul[i].A.y + oy;
                dreptunghiul[i].B.x = dreptunghiul[i].B.x + ox;
                dreptunghiul[i].B.y = dreptunghiul[i].B.y + oy;
                dreptunghiul[i].C.x = dreptunghiul[i].C.x + ox;
                dreptunghiul[i].C.y = dreptunghiul[i].C.y + oy;
            }
        }
    }
}
