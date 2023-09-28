using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 4.1, 4.2 и домашнее задание 4.1(нужно считать с экрана число от 1 до 365, перевести этот число в месяц и день месяца, а также определить год високосный или нет)");
            Console.WriteLine("Введите год(после ввода нажмите enter): ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер дня в году(после ввода нажмите enter): ");
            int dayOfYear = int.Parse(Console.ReadLine());
            int month = 0;
            int dayOfMonth = dayOfYear;
            bool isLeapYear = IsLeapYear(year);
            if (isLeapYear)
            {
                if (dayOfMonth > 366 || dayOfMonth < 1)
                {
                    Console.WriteLine("Неверно введён день!");
                }
                else if (dayOfMonth <= 31)
                {
                    month = 1;
                }
                else if (dayOfMonth <= 60)
                {
                    month = 2;
                    dayOfMonth -= 31;
                }
                else if (dayOfMonth <= 91)
                {
                    month = 3;
                    dayOfMonth -= 60;
                }
                else if (dayOfMonth <= 121)
                {
                    month = 4;
                    dayOfMonth -= 91;
                }
                else if (dayOfMonth <= 152)
                {
                    month = 5;
                    dayOfMonth -= 121;
                }
                else if (dayOfMonth <= 182)
                {
                    month = 6;
                    dayOfMonth -= 152;
                }
                else if (dayOfMonth <= 213)
                {
                    month = 7;
                    dayOfMonth -= 182;
                }
                else if (dayOfMonth <= 244)
                {
                    month = 8;
                    dayOfMonth -= 213;
                }
                else if (dayOfMonth <= 274)
                {
                    month = 9;
                    dayOfMonth -= 244;
                }
                else if (dayOfMonth <= 305)
                {
                    month = 10;
                    dayOfMonth -= 274;
                }
                else if (dayOfMonth <= 335)
                {
                    month = 11;
                    dayOfMonth -= 305;
                }
                else if (dayOfMonth <= 366)
                {
                    month = 12;
                    dayOfMonth -= 335;
                }
            }
            else
            {
                if (dayOfMonth > 365 || dayOfMonth < 1)
                {
                    Console.WriteLine("Неверно введён день!");
                }
                else if (dayOfMonth <= 31)
                {
                    month = 1;
                }
                else if (dayOfMonth <= 59)
                {
                    month = 2;
                    dayOfMonth -= 31;
                }
                else if (dayOfMonth <= 90)
                {
                    month = 3;
                    dayOfMonth -= 59;
                }
                else if (dayOfMonth <= 120)
                {
                    month = 4;
                    dayOfMonth -= 90;
                }
                else if (dayOfMonth <= 151)
                {
                    month = 5;
                    dayOfMonth -= 120;
                }
                else if (dayOfMonth <= 181)
                {
                    month = 6;
                    dayOfMonth -= 151;
                }
                else if (dayOfMonth <= 212)
                {
                    month = 7;
                    dayOfMonth -= 181;
                }
                else if (dayOfMonth <= 243)
                {
                    month = 8;
                    dayOfMonth -= 212;
                }
                else if (dayOfMonth <= 273)
                {
                    month = 9;
                    dayOfMonth -= 243;
                }
                else if (dayOfMonth <= 304)
                {
                    month = 10;
                    dayOfMonth -= 273;
                }
                else if (dayOfMonth <= 334)
                {
                    month = 11;
                    dayOfMonth -= 304;
                }
                else if (dayOfMonth <= 365)
                {
                    month = 12;
                    dayOfMonth -= 334;
                }
            }

            Console.WriteLine("Дата: " + dayOfMonth + " " + GetMonthName(month));
        }

        static string GetMonthName(int month)
        {
            switch (month)
            {
                case 1:
                    return "января";
                case 2:
                    return "февраля";
                case 3:
                    return "марта";
                case 4:
                    return "апреля";
                case 5:
                    return "мая";
                case 6:
                    return "июня";
                case 7:
                    return "июля";
                case 8:
                    return "августа";
                case 9:
                    return "сентября";
                case 10:
                    return "октября";
                case 11:
                    return "ноября";
                case 12:
                    return "декабря";
                default:
                    return "";
            }
        }

        static bool IsLeapYear(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }
}