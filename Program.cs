using System; // Подключаем пространсво имён | Connecting the namespace

Random random = new Random(); // Создаём объект класса для использовании метода Random | Creating a class object to use the Random method
while (true)
{
    Console.WriteLine("Укажите кол-во бросков | Specify the number of throws\n ");
  
    ulong number;
    while (!ulong.TryParse(Console.ReadLine(), out number)) // Скрипт позволяющий вводить только целые числа | A script that allows you to enter only ulongegers
    {
        Console.WriteLine("Укажите целое положительное число | Specify a positive integer ");
    }
  
    ulong r = 0; // Счётчик "Решка" | Tails Counter
    ulong o = 0; // Счётчик "Орёл" | The Eagle counter
    ulong?[] c = new ulong?[number]; // Вводим массив с числом элементов равному количеству брасков | We enter an array with the number of elements equal to the number of braces
    for (ulong i = 0; i < number; i++) // цикл что делает расчеты и помещает элементы в массив | a loop that does calculations and puts elements in an array
    {
        ulong b = (ulong)random.Next(0, 2);
        c[i] = b;
    }

    foreach (var C in c) // Счёт значений и передача их в счётчики | Counting values and passing them to counters
    {
        if (C == 0)
        {
            r++;
        }
        else
        {
            o++;
        }
    }
    Console.WriteLine($"\tВСЕГО БРОСКОВ {number} | TOTAL THROWS {number} \n\t{r} - Решка {o} -Орёл | {r}- Tails {o}-Heads"); // Выводим результат на консоль  | Output the result to the console

    // Небольшой анализ данных | A little data analysis
    double analis;
    if (r > o) 
    {
        analis = ((double)r / (double)o * 100 - 100); //Подсчет процентах | Percentage calculation
        //Math.Round(Переменная\Значение | Variable\Value ,X) - Позволяет округлить переменную или значении до X после запятой | Allows you to round a variable or value to X after the decimal point
        Console.WriteLine($"\tКоличество решек больше чем орлов на {r - o} |The number of tails is more than the number of heads on {r - o}\n\tВ процентах {Math.Round(analis, 3)} | As a percentage {Math.Round(analis, 3)}\n  "); 
    }

    else if (o > r)
    {
        analis = ((double)o / (double)r * 100 - 100); //Подсчет процентах | Percentage calculation
        Console.WriteLine($"\tКоличество орлов больше чем решек на {o - r} |The number of heads is more than tails on {o - r}\n\tВ процентах {Math.Round(analis, 3)} | As a percentage {Math.Round(analis, 3)}\n ");
    }

    else { Console.WriteLine("\tДанные равны\n | The data is equal\n"); }
    }

