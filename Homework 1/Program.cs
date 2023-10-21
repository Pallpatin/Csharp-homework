using System;
using System.Text;

internal class Program
{

    private static void Main(string[] args)
    {
        byte Tasknumber = 1;
       
        /*Задвние 1 
        Пользователь вводит с клавиатуры число в диапазоне от 1 до 100. Если число кратно 3 (делится на 3 без 
остатка) нужно вывести слово Fizz. Если число кратно 5
нужно вывести слово Buzz. Если число кратно 3 и 5 нужно 
вывести Fizz Buzz. Если число не кратно не 3 и 5 нужно 
вывести само число.
Если пользователь ввел значение не в диапазоне от 1
до 100 требуется вывести сообщение об ошибке*/
        Console.Clear();
        Console.WriteLine("задание №"+Tasknumber++);
        Console.WriteLine(" Пользователь вводит с клавиатуры число в диапазоне от 1 до 100. Если число кратно 3 (делится на 3 без \r\nостатка) нужно вывести слово Fizz. Если число кратно 5\r\nнужно вывести слово Buzz. Если число кратно 3 и 5 нужно \r\nвывести Fizz Buzz. Если число не кратно не 3 и 5 нужно \r\nвывести само число.\r\nЕсли пользователь ввел значение не в диапазоне от 1\r\nдо 100 требуется вывести сообщение об ошибке");
        FirstTask();
        Console.WriteLine("нажмите любую кнопку чтобы продолжить");
        Console.ReadKey(true);
        /*Задание 2
                Пользователь вводит с клавиатуры два числа. Первое
        число — это значение, второе число процент, который
        необходимо посчитать. Например, мы ввели с клавиатуры
        90 и 10.Требуется вывести на экран 10 процентов от 90.
        Результат: 9*/
        Console.Clear();
        Console.WriteLine("задание №" + Tasknumber++);
        Console.WriteLine("Пользователь вводит с клавиатуры два числа. Первое\n        число — это значение, второе число процент, который\n        необходимо посчитать. Например, мы ввели с клавиатуры\n        90 и 10.Требуется вывести на экран 10 процентов от 90.\n        Результат: 9");
        SecondTask();
        Console.WriteLine("нажмите любую кнопку чтобы продолжить");
        Console.ReadKey(true);
        /*Задание 3
         Пользователь вводит с клавиатуры четыре цифры. 
Необходимо создать число, содержащее эти цифры. Например, если с клавиатуры введено 1, 5, 7, 8 тогда нужно 
сформировать число 1578*/
        Console.Clear();
        Console.WriteLine("задание №" + Tasknumber++);
        Console.WriteLine("         Пользователь вводит с клавиатуры четыре цифры. \nНеобходимо создать число, содержащее эти цифры. Например, если с клавиатуры введено 1, 5, 7, 8 тогда нужно \nсформировать число 1578");
        ThriedTask();
        Console.WriteLine("нажмите любую кнопку чтобы продолжить");
        Console.ReadKey(true);
        /*Задание 4 
         Пользователь вводит шестизначное число. После чего 
пользователь вводит номера разрядов для обмена цифр. 
Например, если пользователь ввёл один и шесть — это 
значит, что надо обменять местами первую и шестую 
цифры.
Число 723895 должно превратиться в 523897.
Если пользователь ввел не шестизначное число требуется вывести сообщение об ошибке*/
        Console.Clear();
        Console.WriteLine("задание №" + Tasknumber++);
        Console.WriteLine("Пользователь вводит шестизначное число. После чего \nпользователь вводит номера разрядов для обмена цифр. \nНапример, если пользователь ввёл один и шесть — это \nзначит, что надо обменять местами первую и шестую \nцифры.\nЧисло 723895 должно превратиться в 523897.\nЕсли пользователь ввел не шестизначное число требуется вывести сообщение об ошибке");
        FourthTask();
        Console.WriteLine("нажмите любую кнопку чтобы продолжить");
        Console.ReadKey(true);
        /*Задание 5
         Пользователь вводит с клавиатуры дату. Приложение должно отобразить название сезона и дня недели. 
Например, если введено 22.12.2021, приложение должно 
отобразить Winter Wednesday*/
        Console.Clear();
        Console.WriteLine("задание №" + Tasknumber++);
        Console.WriteLine("Пользователь вводит с клавиатуры дату. Приложение должно отобразить название сезона и дня недели. \r\nНапример, если введено 22.12.2021, приложение должно \r\nотобразить Winter Wednesday");
        FifthTask();
        Console.WriteLine("нажмите любую кнопку чтобы продолжить");
        Console.ReadKey(true);
        /*Задание 6 
         Пользователь вводит с клавиатуры показания температуры. В зависимости от выбора пользователя программа переводит температуру из Фаренгейта в Цельсий 
или наоборот.*/
        Console.Clear();
        Console.WriteLine("задание №" + Tasknumber++);
        Console.WriteLine("Пользователь вводит с клавиатуры показания температуры. В зависимости от выбора пользователя программа переводит температуру из Фаренгейта в Цельсий \r\nили наоборот.");
        SixthTask();
        Console.WriteLine("нажмите любую кнопку чтобы продолжить");
        Console.ReadKey(true);
        
        /*Задание 7
         Пользователь вводит с клавиатуры два числа. Нужно 
показать все четные числа в указанном диапазоне. Если 
границы диапазона указаны неправильно требуется произвести нормализацию границ. Например, пользователь 
ввел 20 и 11, требуется нормализация, после которой 
начало диапазона станет равно 11, а конец 20*/
        Console.Clear();
        Console.WriteLine("задание №" + Tasknumber++);
        Console.WriteLine("Пользователь вводит с клавиатуры два числа. Нужно \r\nпоказать все четные числа в указанном диапазоне. Если \r\nграницы диапазона указаны неправильно требуется про\u0002извести нормализацию границ. Например, пользователь \r\nввел 20 и 11, требуется нормализация, после которой \r\nначало диапазона станет равно 11, а конец 20");
        SeventhTask();
        Console.WriteLine("нажмите любую кнопку чтобы продолжить");
        Console.ReadKey(true);
    }
    public static void FirstTask()
    {
        /*Задвние 1 
        Пользователь вводит с клавиатуры число в диапазоне от 1 до 100. Если число кратно 3 (делится на 3 без 
остатка) нужно вывести слово Fizz. Если число кратно 5
нужно вывести слово Buzz. Если число кратно 3 и 5 нужно 
вывести Fizz Buzz. Если число не кратно не 3 и 5 нужно 
вывести само число.
Если пользователь ввел значение не в диапазоне от 1
до 100 требуется вывести сообщение об ошибке*/
        Console.WriteLine("Введите число : ");
        int num1;
        num1 = Convert.ToInt32(Console.ReadLine());
        if (num1 >= 1 && num1 <= 100)
        {
            bool flag = true;
            if (num1 % 3 == 0)
            {
                flag = false;
                Console.WriteLine("Fizz");
            }
            if (num1 % 5 == 0)
            {
                flag = false;
                Console.WriteLine("Buzz");
            }
            if (flag) Console.WriteLine(num1);
        }
        else Console.WriteLine("Вне диапазона 1-100");
    }
    public static float SecondTask()
    {
        /*Задание 2
                Пользователь вводит с клавиатуры два числа. Первое
        число — это значение, второе число процент, который
        необходимо посчитать. Например, мы ввели с клавиатуры
        90 и 10.Требуется вывести на экран 10 процентов от 90.
        Результат: 9*/
        Console.WriteLine("Введите число ");
        float num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите процент ");
        float persent = Convert.ToInt32(Console.ReadLine());
        float answer = num / 100 * persent;
        Console.WriteLine(persent + "% от числа " + num + " равны " + answer);
        return answer;
    }
    public static float ThriedTask()
    {
        /*Задание 3
 Пользователь вводит с клавиатуры четыре цифры. 
Необходимо создать число, содержащее эти цифры. Например, если с клавиатуры введено 1, 5, 7, 8 тогда нужно 
сформировать число 1578*/
        Console.WriteLine("введите число");
        return Convert.ToSingle(Console.ReadLine());
    }
    public static int FourthTask()
    {
        /*Задание 4 
 Пользователь вводит шестизначное число. После чего 
пользователь вводит номера разрядов для обмена цифр. 
Например, если пользователь ввёл один и шесть — это 
значит, что надо обменять местами первую и шестую 
цифры.
Число 723895 должно превратиться в 523897.
Если пользователь ввел не шестизначное число требуется вывести сообщение об ошибке*/
        Console.WriteLine("введите шестизначное число ");
        StringBuilder sixchared=new StringBuilder(Console.ReadLine());
        if (sixchared.Length!=6)
        {
            Console.WriteLine("введено не шестизначное число");
            return 0;
        }
        else
        {
            Console.WriteLine("введите номера чисел,которые нужно поменять местами");
            Console.WriteLine("введите первое число ");
            int num1=Convert.ToInt32(Console.ReadLine());
            if (num1 < 1 || num1 > 6)
            {
                do
                {
                    Console.WriteLine("вы неправильно ввели первое число, введите его заново ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                } while (num1 < 1 || num1 > 6);
            }
            Console.WriteLine("введите второе число");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num2 < 1 || num2 > 6)
            {
                do
                {
                    Console.WriteLine("вы неправильно ввели второе число, введите его заново ");
                    num2 = Convert.ToInt32(Console.ReadLine());
                } while (num2 < 1 || num2 > 6);
            }
            num1--;
            num2--;
            char buf = sixchared[num1];
            sixchared[num1] = sixchared[num2];
            sixchared[num2] = buf;
            Console.WriteLine(sixchared);
            return Convert.ToInt32(sixchared.ToString());
        }
    }
    public static void FifthTask()
    {
        /*Задание 5
 Пользователь вводит с клавиатуры дату. Приложение должно отобразить название сезона и дня недели. 
Например, если введено 22.12.2021, приложение должно 
отобразить Winter Wednesday*/
        Console.WriteLine("введите дату : ");
        string? inputedstr = Console.ReadLine();
        DateTime date;
        if (DateTime.TryParse(inputedstr, out date))
        {
            string season = GetSeason(date.Month);
            
            string dayOfWeek = date.DayOfWeek.ToString();
            Console.WriteLine($"{season} {dayOfWeek}");
        }
        else Console.WriteLine(" не получилось считать дату");
        
    }
    static string GetSeason(int month)
    {
        switch (month)
        {
            case 12:
            case 1:
            case 2:
                return "Winter";
            case 3:
            case 4:
            case 5:
                return "Spring";
            case 6:
            case 7:
            case 8:
                return "Summer";
            case 9:
            case 10:
            case 11:
                return "Autumn";
            default:
                throw new ArgumentException("Invalid month.");
        }
    }
    public static void SixthTask()
    {
        /*Задание 6 
         Пользователь вводит с клавиатуры показания температуры. В зависимости от выбора пользователя программа переводит температуру из Фаренгейта в Цельсий 
или наоборот.*/
        Console.WriteLine("введите значение для конвертации ");
        float degree;
        if(float.TryParse(Console.ReadLine(),out degree))
        {
            Console.WriteLine(degree +"F = "+(degree-32)/1.8+"C");
            Console.WriteLine(degree + "C = " + (degree * 1.8 + 32)+"F");
        }
        else Console.WriteLine("ошибка преобразования значения");
    } 

    public static void SeventhTask()
    {
        /*Задание 7
         Пользователь вводит с клавиатуры два числа. Нужно 
показать все четные числа в указанном диапазоне. Если 
границы диапазона указаны неправильно требуется произвести нормализацию границ. Например, пользователь 
ввел 20 и 11, требуется нормализация, после которой 
начало диапазона станет равно 11, а конец 20*/
        Console.WriteLine("введите первое число ");
        int firstnum = int.Parse(Console.ReadLine());
        Console.WriteLine("введите второе число");
        int secondnum = int.Parse(Console.ReadLine());
        if (firstnum > secondnum)
        {
            int buf = firstnum;
            firstnum = secondnum;
            secondnum=buf;
        }
        firstnum += firstnum % 2;
        while (firstnum < secondnum) Console.WriteLine(firstnum += 2);
    }

}
