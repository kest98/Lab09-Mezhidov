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
//             continue;
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
int N = int.Parse(Console.ReadLine());
for (int number = 1; number <= N; number += 2)
{
    Console.WriteLine($"Все нечетные числа от 1 до N {number}");
}


