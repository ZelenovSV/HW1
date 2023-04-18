    Console.WriteLine("Введите число :");
    string s1 = Console.ReadLine();
    int Number1 = int.Parse(s1);
        
        if (Number1 % 2 > 0)
        {
            Console.WriteLine("Вы ввели нечетное число");
        }
        else
        {
            Console.WriteLine("Вы ввели четное число");
        }
