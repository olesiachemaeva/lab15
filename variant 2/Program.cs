using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variant_2
{
    namespace ConsoleApplication2
    {
        public class Class1
        {

            static void Main(string[] args)
            {
                
                Console.WriteLine("---------Арифметическая прогрессия:");
                ArefmProgr.Funk(3, 2.65, 8);
                Console.WriteLine("---------Геометрическая прогрессия:");
                GeomertProgr.Funk(2, 9);
                Console.ReadLine();
            }
        }
        class ArefmProgr // класс арифметической прогрессии
        {
            // firstElem - первый элемент последовательности
            // stepOfElem - шаг последователности
            // endElem - номер последнего члена прогрессии
            // ArefmSumElem - сумма n-ных членов прогресии

            public static void Funk(double firstElem, double stepOfElem, int endElem)
            {
                double[] ArefmProgrArray = new double[endElem];
                ArefmProgrArray[0] = firstElem;
                double ArefmSumElem = firstElem;

                for (int i = 1; i < endElem; i++)
                {
                    ArefmProgrArray[i] = ArefmProgrArray[0] + (i - 1) * stepOfElem;
                    Console.Write(ArefmProgrArray[i] + " ");
                    ArefmSumElem += ArefmProgrArray[i];
                }
                Console.WriteLine("\nХарактеристики: \nпервый член = {0} \nшаг = {1} \nномер последнего члена = {2}", firstElem, stepOfElem, endElem);
                Console.WriteLine("Sum= " + (ArefmSumElem + firstElem));

            }
        }
        public class GeomertProgr // класс геометрическоц прогрессии
        {
            // firstElem - первый элемент последовательности
            // endElem - номер последнего члена прогрессии

            public static void Funk(double firstElem, int endElem)
            {
                double[] ArefmProgrArray = new double[endElem];
                ArefmProgrArray[0] = firstElem;
                double ArefmSumElem = firstElem;

                for (int i = 1; i < endElem; i++)
                {
                    ArefmProgrArray[i] = Math.Pow(ArefmProgrArray[0], i);
                    Console.Write(ArefmProgrArray[i] + " ");
                    ArefmSumElem += ArefmProgrArray[i];
                }
                Console.WriteLine("\nХарактеристики: \nпервый член = {0}\nномер последнего члена = {1}", firstElem, endElem);
                Console.WriteLine("Sum= " + (ArefmSumElem + firstElem));

            }
        }

    }
}
