// using System.Runtime.CompilerServices;
// using System.Runtime.Serialization.Formatters;

// int totalExercises = 8;
// for (int number = 8; number <= totalExercises; number--)
// {
//     Console.WriteLine($"Упражнение {number}");
// }

// Console.WriteLine("Домашнее задание готово");


// for (int room = 5; room <= 50; room += 5 )
// {
//     Console.WriteLine($"Кабинет {room}");
// }


// int totalWeeks = 3;

// for (int week = 1; week <= totalWeeks; week++)
// {
//     for (int day = 1; day <= 5; day++)
//     {
//         Console.WriteLine($"Неделя {week}, день {day}");
//         if (int >= 5)
//         {
//             Console.WriteLine("^_^");
//         }
//     }
// }


// using System.Data.Common;

// int as3 = 0;
// for (int ticket = 1; ticket <= 30; ticket++)
// {
//     if (ticket == 4 || ticket == 12 || ticket == 19)
//     {
//         as3++;
//         continue;
//     }
//     Console.WriteLine($"Первый доступный билет: {ticket}, пропущено билетов {as3}");
//     break;
// }


// for(; ; )
// {
//     Console.Write("Введите код группы (для выхода - 'выход'): ");
//     string groupCode = Console.ReadLine();

//     if (groupCode == "выход")
//     {
//         break;
//     }

//     Console.WriteLine($"Записан код группы: {groupCode}");
// }
// Console.WriteLine("Работа с журналом завершена");


//Сам. задания
//Задача А
// int N = int.Parse(Console.ReadLine());
// for (int number = 1; number <= N; number += 2)
// {
//     Console.WriteLine($"Все нечетные числа от 1 до N: {number}");
// }

//Задача Б
// int B = 0;
// for (int number = 100; number >= B; number -= 10)
// {
//     Console.WriteLine($"{number}");
// }


// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname))
// {
//     Console.WriteLine("Фамилия не введена. Завершение работы.");
//     return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
// .OrderBy(_ => rnd.Next())
// .Take(2)
// .OrderBy(x => x)
// .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");


//Вариант 3
using System.Runtime.CompilerServices;
int cube1 = 0;
int N = int.Parse(Console.ReadLine());
for (int number = 1; number <= N; number++)
{
    cube1 = number * number * number;
    Console.WriteLine($"{number} - {cube1}");
}

