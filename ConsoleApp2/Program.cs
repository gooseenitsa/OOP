using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool booleanV = true;
            byte byteV = 255;
            sbyte sbyteV  = -128;
            char charV = 'A';
            decimal decimalV = 123.45M;
            double doubleV = 123.45;
            float floatV = 123.45F;
            int intV = 123;
            uint uintV = 123;
            long longV = 123;
            ulong ulongV = 123;
            short shortV = 123;
            ushort ushortV = 123;

            //Console.Write("Введите значение для bool: ");
            //booleanV = Convert.ToBoolean(Console.ReadLine());

            //Console.Write("Введите значение для byte: ");
            //byteV = Convert.ToByte(Console.ReadLine());

            //Console.Write("Введите значение для sbyte: ");
            //sbyteV = Convert.ToSByte(Console.ReadLine());

            //Console.Write("Введите значение для char: ");
            //charV = Convert.ToChar(Console.ReadLine());

            //Console.Write("Введите значение для decimal: ");
            //decimalV = Convert.ToDecimal(Console.ReadLine());

            //Console.Write("Введите значение для double: ");
            //doubleV = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Введите значение для float: ");
            //floatV = Convert.ToSingle(Console.ReadLine());

            //Console.Write("Введите значение для int: ");
            //intV = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Введите значение для uint: ");
            //uintV = Convert.ToUInt32(Console.ReadLine());

            //Console.Write("Введите значение для long: ");
            //longV = Convert.ToInt64(Console.ReadLine());

            //Console.Write("Введите значение для ulong: ");
            //ulongV = Convert.ToUInt64(Console.ReadLine());

            //Console.Write("Введите значение для short: ");
            //shortV = Convert.ToInt16(Console.ReadLine());

            //Console.Write("Введите значение для ushort: ");
            //ushortV = Convert.ToUInt16(Console.ReadLine());

            Console.WriteLine("bool: " + booleanV);
            Console.WriteLine("byte: " + byteV);
            Console.WriteLine("sbyte: " + sbyteV);
            Console.WriteLine("char: " + charV);
            Console.WriteLine("decimal: " + decimalV);
            Console.WriteLine("double: " + doubleV);
            Console.WriteLine("float: " + floatV);
            Console.WriteLine("int: " + intV);
            Console.WriteLine("uint: " + uintV);
            Console.WriteLine("long: " + longV);
            Console.WriteLine("ulong: " + ulongV);
            Console.WriteLine("short: " + shortV);
            Console.WriteLine("ushort: " + ushortV);

            byte S = 2;
            short SH = 1;
            ushort sh = (ushort)SH;
            int A = 12;
            A = S;
            A = SH;
            A = (int)sh;
            SH = S;
            ulong BB = (ulong)A;
            BB = (ulong)sh;
            long B = A;
            int C = (int)B;
            C = S;

            int p = 2;
            object o = p;
            o = 2;
            p = (int)o;

            int intVar = 123;
            object boxedInt = intVar;
            double doubleVar = 123.45;
            object boxedDouble = doubleVar;

            char charVar = 'A';
            object boxedChar = charVar;

            bool boolVar = true;
            object boxedBool = boolVar;

            decimal decimalVar = 123.45M;
            object boxedDecimal = decimalVar;

            Console.WriteLine("Упакованные значения:");
            Console.WriteLine("boxedInt: " + boxedInt);
            Console.WriteLine("boxedDouble: " + boxedDouble);
            Console.WriteLine("boxedChar: " + boxedChar);
            Console.WriteLine("boxedBool: " + boxedBool);
            Console.WriteLine("boxedDecimal: " + boxedDecimal);

            int unboxedInt = (int)boxedInt;
            double unboxedDouble = (double)boxedDouble;
            char unboxedChar = (char)boxedChar;
            bool unboxedBool = (bool)boxedBool;
            decimal unboxedDecimal = (decimal)boxedDecimal;

            Console.WriteLine("Распакованные значения:");
            Console.WriteLine("unboxedInt: " + unboxedInt);
            Console.WriteLine("unboxedDouble: " + unboxedDouble);
            Console.WriteLine("unboxedChar: " + unboxedChar);
            Console.WriteLine("unboxedBool: " + unboxedBool);
            Console.WriteLine("unboxedDecimal: " + unboxedDecimal);
            var variable = 123;
            Console.WriteLine(variable);
            variable += 12;
            Console.WriteLine(variable);

            bool? que = null;
            if (!que.HasValue)
            {
                Console.WriteLine("В переменной que нет значения");
            }
            if (que.HasValue)
            {
                Console.WriteLine("В переменной que есть значение");
                Console.WriteLine("que: ", que);
            }
            var celoe = 2; // неявно типизированные локальные переменные строго типизированы.

            string lit1 = "hello";
            string lit2 = "world";
            bool isEqual = lit1.Equals(lit2);
            Console.WriteLine(isEqual);

            String str1 = "yoy man guy duh";
            String str2 = "waw";
            String str3 = "qaa";

            Console.WriteLine(String.Concat(str1, str2));
            Console.WriteLine(str1 + str2 + str3);
            String str3Copy = String.Copy(str3);
            Console.WriteLine(str3Copy);
            String substr = str1.Substring(3,7);
            Console.WriteLine($"Подстрока из str1: {substr}");
            Console.WriteLine($"Подстрока из str1 в str2: {str2.Insert(3,substr)}");
            String[] splitStrs = str1.Split(' ');

            foreach (String str in splitStrs)
            {
                Console.WriteLine($"word:{str}");
            }
            
            Console.WriteLine(str1.Remove(0, 7));
            String empty = String.Empty;
            String space = "   " ;
            String clear = null;
            Console.WriteLine(String.IsNullOrEmpty(empty));
            Console.WriteLine(String.IsNullOrEmpty(space));
            Console.WriteLine(String.IsNullOrEmpty(clear));

            Console.WriteLine(String.IsNullOrWhiteSpace(empty));
            Console.WriteLine(String.IsNullOrWhiteSpace(space));
            Console.WriteLine(String.IsNullOrWhiteSpace(clear));

            StringBuilder sb= new StringBuilder("STRING", 100);
            Console.WriteLine(sb.ToString());
            sb.Append(new char[] { 'D', 'O', 'N' });
            sb.Remove(0, 3);
            sb.Insert(0, "COOK");
            Console.WriteLine(sb.ToString());

            int[,] dvumas = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for(int i=0; i < dvumas.GetLength(0); i++)
            {
                for(int j=0; j < dvumas.GetLength(1); j++)
                {
                    Console.Write($"{dvumas[i, j]} ");
                }
                Console.WriteLine();
            }
            String[] arr = { "Hello", "World", "!" };
            Console.WriteLine(String.Join(" ",arr));
            Console.WriteLine(arr.Length);
            int change = int.Parse(Console.ReadLine());
            String replace = Console.ReadLine();
            if(change>0 && change <= arr.Length)
            {
                arr[change - 1] = replace;
                Console.WriteLine(String.Join(" ", arr));
            }

            double[][] jaggedArray = new double[3][];
            jaggedArray[0] = new double[2];
            jaggedArray[1] = new double[3];
            jaggedArray[2] = new double[4];
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for(int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.WriteLine($"Введите значение элемента [{i}][{j}]");
                    jaggedArray[i][j] = double.Parse(Console.ReadLine());

                }
            }
            var stroka = "Hello";
            var massiv = new[] { 1, 2, 3 };

            (int, string, char, ulong) t1 = (1, "hello", 'a', 999);
            Console.WriteLine(t1);
            Console.WriteLine($"1,2 и 4 элементы кортежа:{t1.Item1},{t1.Item3},{t1.Item4}");

            int qwerty = 0;
            var slovo = "";
            char character = ' ';
            ulong ln = 0;

            (qwerty, slovo, character, ln) = t1;
            (int numb, string worde, var bukva, var chislo) = t1;
            
            var (number, word, symbol, longNumber) = t1;
            Console.WriteLine($"Number:{number}, Symbol:{symbol}");

            var t2 = ("hello", 50);
            var t3 = ("world", 25);
            bool comp = t2==t3;
            Console.WriteLine(comp);

            Console.WriteLine(comp=t3==t3);

            (int,int,int,char) maxMin(int[] arra, string str)
            {
                int min = arra.Min();
                int max = arra.Max();
                int sum = arra.Sum();
                char firstLt = str.First();
                return (min, max,sum,firstLt);
            }
            int[] array = { 1, 2, 3 };
            String slova = "Gorilla";
            Console.WriteLine(maxMin(array, slova));
            int CheckInt()
            {
                checked
                {
                    int a = int.MaxValue;
                    return a;
                }
            }
            int UncheckedInt()
            {
                unchecked
                {
                    int a = int.MaxValue+3;
                    return a;
                }
            }
            Console.WriteLine(CheckInt());
            Console.WriteLine(UncheckedInt());

        }


    }
}
