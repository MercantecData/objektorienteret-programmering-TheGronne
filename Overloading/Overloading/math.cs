using System;
using System.IO;

namespace Overloading
{
    public class math
    {
        public int additive(int number1, int number2)
        {
            return number1 += number2;
        }

        public float additive(float number1, float number2)
        {
            return number1 += number2;
        }
        public double additive(string number1, string number2)
        {
            double parsednumber1 = double.Parse(number1);
            double parsednumber2 = double.Parse(number2);

            return parsednumber1 += parsednumber2;
        }



        public int subtraction(int number1, int number2)
        {
            return number1 -= number2;
        }

        public float subtraction(float number1, float number2)
        {
            return number1 -= number2;
        }
        public double subtraction(string number1, string number2)
        {
            double parsednumber1 = double.Parse(number1);
            double parsednumber2 = double.Parse(number2);

            return parsednumber1 += parsednumber2;
        }



        public int multiplication(int number1, int number2)
        {
            return number1 *= number2;
        }

        public float multiplication(float number1, float number2)
        {
            return number1 *= number2;
        }
        public double multiplication(string number1, string number2)
        {
            double parsednumber1 = double.Parse(number1);
            double parsednumber2 = double.Parse(number2);

            return parsednumber1 *= parsednumber2;
        }



        public int division(int number1, int number2)
        {
            return number1 /= number2;
        }

        public float division(float number1, float number2)
        {
            return number1 /= number2;
        }
        public double division(string number1, string number2)
        {
            double parsednumber1 = double.Parse(number1);
            double parsednumber2 = double.Parse(number2);

            return parsednumber1 /= parsednumber2;
        }
    }
}
