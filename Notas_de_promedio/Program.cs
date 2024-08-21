// See https://aka.ms/new-console-template for more information

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace notasdepromedio
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int ap = 0;
            float nota, acAprobadas = 0, acReprobadas = 0;

            for (int x = 0; x < 40; x++)
            {
                Console.WriteLine("Favor ingresar Nota: ");
                nota = float.Parse(Console.ReadLine());

                if (nota >= 3)
                {
                    acAprobadas = acAprobadas + nota;
                    ap++;
                }
                else
                    acReprobadas = acReprobadas + nota;

            }
            Console.WriteLine("El promedio de notas Aprobadas es: " + acAprobadas / ap);
            Console.WriteLine("El promedio de notas Reprobadas es: " + acReprobadas / (40 - ap));
            Console.ReadKey();
        }
    }

}