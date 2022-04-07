using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_HomeWork_1
{
    internal class Program
    {
        //проверка входных значений, при отсутствии значения, значение = "Undefined"
        static string GetCorrectInStrData(string inString)
        {
            return (inString.Length > 0) ? inString : "Undefined";
        }

        //lastName - Фамилия; firstName - Имя; patronymic - Отчество
        static string GetFullName(string lastName, string firstName, string patronymic)
        {
            return $"{GetCorrectInStrData(lastName)} " +
                   $"{GetCorrectInStrData(firstName)} " +
                   $"{GetCorrectInStrData(patronymic)}";
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Урок 4, домашнее задание № 1");

            //
            Console.WriteLine(GetFullName("Иванов", "Иван", "Иванович"));
            Console.WriteLine(GetFullName("Петров", "Петр", "Петрович"));
            Console.WriteLine(GetFullName("Сидоров", "Николай", "Александрович"));
            Console.WriteLine(GetFullName("", "", ""));

            //
            Console.ReadLine();
        }
    }
}
