


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab15
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("---------Арифметическая прогрессия:");
            ArithProgression arithProgression = new ArithProgression();
            arithProgression.setStart(7);
            arithProgression.setStep(4);
            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine(arithProgression.getNext());
            arithProgression.reset();

           
            //ArefmProgr.Funk(3, 2.65, 8);
            Console.WriteLine("---------Геометрическая прогрессия:");

            GeomProgression geomProgression = new GeomProgression();
            geomProgression.setStart(7);
            geomProgression.setStep(4);
            Console.WriteLine(geomProgression.getNext());
            Console.WriteLine(geomProgression.getNext());
            Console.WriteLine(geomProgression.getNext());
            geomProgression.reset();
            //GeomertProgr.Funk(2, 9);
            Console.ReadLine();
        }
    }
    interface ISeries
    {
        void setStart(int x);
        int getNext();
        void reset();
    }
    class ArithProgression : ISeries
    {
        int step;
        int startValue;
        int currentValue;

        public int getNext()
        {
            currentValue += step;
            return currentValue;
        }

        public void reset()
        {
            currentValue = startValue;
        }

        public void setStart(int x)
        {
            startValue = x;
            currentValue = startValue;
        }
        public void setStep(int s)
        {
            step = s;
        }
    }
    class GeomProgression : ISeries

    {
        int step;
        int startValue;
        int currentValue;

        public int getNext()
        {
            currentValue *= step;
            return currentValue;
        }

        public void reset()
        {
            currentValue = startValue;
        }

        public void setStart(int x)
        {
            startValue = x;
            currentValue = startValue;
        }
        public void setStep(int s)
        {
            step = s;
        }
    }
}
