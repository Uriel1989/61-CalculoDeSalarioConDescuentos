using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculoDeSalarioConDescuentos
{
    class Program
    {
        static void Main(string[] args)
        {
            double trab, can, total, neto, isss, renta, AFP;
            Console.Write("introduzca el numero de horas trabajadas: ");
            can = double.Parse(Console.ReadLine());
            Console.Write("introduzca el numero de trabajadores: ");
            trab = double.Parse(Console.ReadLine());
            total = 8 * trab * can;
            isss = total * 0.34 / trab;
            Console.WriteLine("el descuento de isss es: ${0} ", isss);
            renta = total * 0.20 / trab;
            Console.WriteLine("el descuento de renta es: ${0}", renta);
            AFP = total * 0.15 / trab;
            Console.WriteLine("el descuento de AFP es: ${0}", AFP);
            neto = total - isss - renta - AFP;
            Console.WriteLine("el sueldo neto de los trabajadores es de : ${0}", neto / trab);
            Console.Write("");
            Console.WriteLine("El valor de la planilla total es de:  ${0} ", total);

            Console.ReadKey();
        }
    }
}
