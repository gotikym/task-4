using System;

    internal class Program
    {
        static void Main(string[] args)
        {
        Console.Write("Введите ваше имя: ");
        string name = Console.ReadLine();
        Console.WriteLine($"Добро пожаловать {name}");
        Console.WriteLine("Какой сок вы предпочитаете?");
        string juice = Console.ReadLine();
        Console.WriteLine("Сколько корбок сока в среднем вы выпиваете за неделю?");
        int numberJuiceBoxes = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"{name} предпочитает {juice} сок и в среднем за неделю выпивает {numberJuiceBoxes} коробок сока");
        }
    }