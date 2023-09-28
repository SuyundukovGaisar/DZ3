using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ3
{
    internal class Program
    {
        enum Weekdays
        {
            Понедельник = 1,
            Вторник,
            Среда,
            Четверг,
            Пятница,
            Суббота,
            Воскресенье
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 2.(Игральным картам условно присвоены порядковые номера в зависимости от их достоинства,определить достоинство соответствующей карты):");
            try
            {
                Console.WriteLine("Введите номер карты от 6 до 14(после ввода нажмите enter): ");
                int cardNumber = Convert.ToInt32(Console.ReadLine());
                switch (cardNumber)
                {
                    case 6:
                        Console.WriteLine("шестерка");
                        break;
                    case 7:
                        Console.WriteLine("семёрка");
                        break;
                    case 8:
                        Console.WriteLine("восьмерка");
                        break;
                    case 9:
                        Console.WriteLine("девятка");
                        break;
                    case 10:
                        Console.WriteLine("десятка");
                        break;
                    case 11:
                        Console.WriteLine("валет");
                        break;
                    case 12:
                        Console.WriteLine("дама");
                        break;
                    case 13:
                        Console.WriteLine("король");
                        break;
                    case 14:
                        Console.WriteLine("туз");
                        break;
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Задание 3.(Напишите программу, которая принимает на входе строку и производит выходные данные) ");
            Console.WriteLine("Введите сообщение(после ввода нажмите enter): ");
            string Message = Console.ReadLine().ToLower();
            switch (Message)
            {
                case "jabroni":
                    Console.WriteLine("Patron Tequila");
                    break;
                case "school counselor":
                    Console.WriteLine("Anything with Alcohol");
                    break;
                case "programmer":
                    Console.WriteLine("Hipster Craft Beer");
                    break;
                case "bike gang member":
                    Console.WriteLine("Moonshine");
                    break;
                case "politician":
                    Console.WriteLine("Your tax dollars");
                    break;
                case "rapper":
                    Console.WriteLine("Cristal");
                    break;
                default:
                    Console.WriteLine("Beer");
                    break;
            }

            Console.WriteLine("Задание 4.(составить программу, которая в зависимости от порядкового номера дня недели (1, 2,...,7) выводит на экран его название (понедельник, вторник, ..., воскресенье))");
            Console.WriteLine("Введите порядковый номер от 1 до 7(после ввода нажмите enter):");
            int numberofday = int.Parse(Console.ReadLine());
            if (numberofday <= 7 && numberofday >= 1)
            {
                Weekdays dayofweek = (Weekdays)numberofday;
                Console.WriteLine("День недели: " + dayofweek);
            }
            else
            {
                Console.WriteLine("Некорректно введен порядковый номер дня недели!");
            }
            
            Console.WriteLine("Задание 5.(нужно создать массив и обойти его, собрав нужные элементы в 'сумку')");
            string[] toys = { "Hello Kitty", "Teddy bear", "Dinosaur", "Hello Kitty", "Book", "Car", "Barbie doll" };
            int dollsCount = 0;

            foreach (string toy in toys)
            {
                if (toy == "Hello Kitty" || toy == "Barbie doll")
                {
                    dollsCount++;
                }
            }

            Console.WriteLine("В сумке " + dollsCount + " кукол");


        }
    }
}
