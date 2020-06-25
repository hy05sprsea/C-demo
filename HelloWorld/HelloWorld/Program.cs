using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            

            // 変数
            Console.WriteLine("Hello World");

            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "Mmm";
            bool isWorking = false;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            byte b = 1;
            int i = b;
            Console.WriteLine(i);

            int a = 1;
            byte c = (byte) a;
            Console.WriteLine(c);

            var number2 = "1234";
            int z = Convert.ToInt32(number2);
            Console.WriteLine(z);


            // エラー
            try
            {
                var number3 = "1234";
                byte x = Convert.ToByte(number3);
                Console.WriteLine(x);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte.");
            }

            try
            {
                string str = "true";
                bool d = Convert.ToBoolean(str);
                Console.WriteLine(d);

            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte.");
            }


            // 演算子
            var t = 10;
            var l = 3;
            var g = 2;

            Console.WriteLine(t + l);
            Console.WriteLine(t - l);
            Console.WriteLine((float) t / (float) l);
            Console.WriteLine((t + l) * g);
            Console.WriteLine(t > l);
            Console.WriteLine(t == l);
            Console.WriteLine( g < l || g == t);
        }

    }
}
