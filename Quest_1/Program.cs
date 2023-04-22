
//#define QUEST1
//#define QUEST2
//#define QUEST3
//#define QUEST4
//#define QUEST5
//#define QUEST6
#define QUEST7
using Microsoft.Win32;
using System;
using System.Data;


namespace Quest_1
{
 
    internal class Program
    {
   
        static void Main(string[] args)
        {
#if QUEST1

            Restrat:
            string Fizz = "\tFizz";
            string Buzz = "\tBuzz";
            int Number=0;
            Console.Clear();
            Number = Convert.ToInt16(Console.ReadLine());
            if ((Number < 0) || (Number > 100)) 
            { Console.WriteLine("Вы ввели неверное число, введите его занового (Для продолжения нажмите любую клавишу)"); Console.ReadKey(); goto Restrat; }
            Console.WriteLine("Вы ввели = " + Number);
            if (Number % 3 == 0) Console.Write(Fizz);
            if (Number % 5 == 0) Console.Write(Buzz);
#endif
#if QUEST2
            double Number1;
            double Number2;
            double Result;
            Console.WriteLine("Введите число 1 = ");Number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите % который хотите посчитать ");Number2 = Convert.ToDouble(Console.ReadLine());
            Result = Number1 / 100 * Number2; Console.WriteLine(Number2 + " % от числа " + Number1 + " = " + Result);

#endif
#if QUEST3
            Console.WriteLine("Введите 4 цифры:");
            string Number_1,Number_2, Number_3, Number_4;
            int Result;
            Console.Write("1 = ");Number_1=Console.ReadLine();
            Console.Write("2 = ");Number_2=Console.ReadLine();
            Console.Write("3 = ");Number_3=Console.ReadLine();
            Console.Write("4 = ");Number_4=Console.ReadLine();
            Result = Convert.ToInt16(Number_1+Number_2+Number_3+Number_4);
            Console.Write("Ваше число = " + Result);
#endif
#if QUEST4
            int Number;
            int[] Symbol = { 0, 0, 0, 0, 0, 0 };
            Console.WriteLine("Введите число = ");
            Number = Convert.ToInt32(Console.ReadLine());
            if ((Number >= 100000) || (Number <= 999999))
            {
                for (int i = 0; i < 6; i++)
                {
                    Symbol[5 - i] = Convert.ToInt32(Number % 10);
                    Number = Number / 10;
                    // Console.Write(Symbol[5-i]);
                }
                for (int i = 0; i < 6; i++) Console.Write(Symbol[i]); // Разбив числа на отдельные его элементы, для дальнейшей замены их
                int N_1, N_2;
                Console.WriteLine("\nВведите индексы для замены цифр местами: ");
                Console.Write(" Index #1 = "); N_1 = Convert.ToInt32(Console.ReadLine());
                Console.Write(" Index #2 = "); N_2 = Convert.ToInt32(Console.ReadLine());
                int buffer=Symbol[6 - N_1];
                Symbol[6-N_1] = Symbol[6 - N_2];
                Symbol[6-N_2] = buffer;
                Number = 0;
                for(int i = 0;i<6; i++)
                {
                    Number += (Symbol[i] * Convert.ToInt32(Math.Pow(10, 5 - i)));
                }
                Console.WriteLine(Number);
               
            }
            else Console.WriteLine("Error: Чиссло введено не верно");

#endif
#if QUEST5
            DateTime date = new DateTime();
            date=DateTime.Now;
            int day,month, year;
            Console.WriteLine("Введите дату - ");
        Re:
            Console.Write("День = ");day=Convert.ToInt32(Console.ReadLine());
            Console.Write("Месяц = "); month = Convert.ToInt32(Console.ReadLine()); if (month > 12) { Console.WriteLine("Месяц указан не корректно, повторите ввод");goto Re; }
            Console.Write("Год = "); year =Convert.ToInt32(Console.ReadLine());
            if ((month==4||month==6||month==9||month==11)&&(day>30)){ Console.WriteLine("Дата указана не коррекнто, повторите ввод!");goto Re; }
            if (day % 4 == 0) { if (month == 2 && day > 28) { Console.WriteLine("Дата указана не корректно, повторите ввод!");goto Re; } }
           // Console.WriteLine(date.Day+"/"+date.Month+"/"+date.Year+" ---- "+date.DayOfWeek);
            DateTime MyDate = new DateTime(year: year, month: month, day: day);
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.Write("Winter\t");break;
                case 3:
                case 4:
                case 5:
                    Console.Write("Spring\t"); break;
                case 6:
                case 7:
                case 8:
                    Console.Write("Summer\t"); break;
                case 9:
                case 10:
                case 11:
                    Console.Write("Autumn\t"); break;
                default:
                    break;
            }
            Console.WriteLine(MyDate.Day + "/" + MyDate.Month + "/" + MyDate.Year + " - " + MyDate.DayOfWeek);

#endif
#if QUEST6
            int Default = 0;
            double temp=0.0;
            Console.Write("Введите температуру = "); temp=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Выберите программу 0/1? (где 0 - Фаренгейт в цельсия, а 1 - Цельсия в Фаренгейт) = ");Default = Convert.ToInt16(Console.ReadLine());
            switch (Default)
            {
                case 1:
              
                    Console.Write(temp+ " C'");
                    //F=C*9/5+32
                    temp = (temp * 9) / 5 + 32;
                    Console.Write("\t= "+temp+" F'");
                    break;
                case 0:
               
                    Console.Write(temp + " F'");
                    //C=(F-32)*5/9;
                    temp = (((temp - 32) * 5) / 9);
                    Console.Write("\t= " + temp + "C'");
                    break;
                default:
                    break;
            }
#endif
#if QUEST7
            int Number1, Number2;
            Console.WriteLine("Введите 2 числа = "); Number1=Convert.ToInt32(Console.ReadLine()); Number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("n1 = " + Number1 + "\t\tn2 = " + Number2);
            if (Number1 > Number2)
            {
               int buffer = Number1;
                Number1 = Number2;
                Number2 = buffer;
            }
            Console.WriteLine("n1 = " + Number1 + "\t\tn2 = " + Number2);
            for(int i=Number1;i<=Number2;i++) 
            {
                if (i % 2 == 0) Console.Write(i+"\t");
            }

#endif

            Console.ReadKey();
        }
    }
}
