using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5_T2
{
    internal class Program
    {
        static void Main()
        {
            int[] montoTotalRenta = new int[31];
            int[] rentaPorDepartamento = new int[31];

            Console.WriteLine("NRO. DPTOS | MONTO TOTAL RENTA ");
            for (int n = 1; n <= 31; n++)
            {
                montoTotalRenta[n - 1] = MontoTotalRenta(n);
                rentaPorDepartamento[n - 1] = RentaPorDepartamento(n);

                Console.WriteLine($"{n,10} | {montoTotalRenta[n - 1],17:C}");
                Console.WriteLine("---------------------------------------");
            }

            int maxTotalRenta = montoTotalRenta[0];
            int minTotalRenta = montoTotalRenta[0];

            foreach (int monto in montoTotalRenta)
            {
                if (monto > maxTotalRenta)
                    maxTotalRenta = monto;
                if (monto < minTotalRenta)
                    minTotalRenta = monto;
            }

            Console.WriteLine("Máximo monto total de renta mensual: " + maxTotalRenta);
            Console.WriteLine("Mínimo monto total de renta mensual: " + minTotalRenta);

            int countiDpts = 0;

            foreach (int renta in rentaPorDepartamento)
            {
                if (renta > 700 && renta <= 1000)
                    countiDpts++;
            }

            Console.WriteLine("Departamentos con renta por departamento entre 700 y 1000: " + countiDpts);

            int sumRentaMayor = 0;
            int countRentaMayor = 0;

            foreach (int renta in rentaPorDepartamento)
            {
                if (renta > 1000)
                {
                    sumRentaMayor += renta;
                    countRentaMayor++;
                }
            }

            double promedioRentaMayor = (double)sumRentaMayor / countRentaMayor;

            Console.WriteLine("Promedio de la renta por departamento mayor a 1000: " + promedioRentaMayor);
        }

        static int RentaPorDepartamento(int n)
        {
            return 500 + 25 * n;
        }
        static int MontoTotalRenta(int n)
        {
            return 550 + 25 * n;
        }
    }
}
