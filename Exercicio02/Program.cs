int time1, time2;

        Console.Write("Gols do time 1: ");
        time1 = int.Parse(Console.ReadLine());

        Console.Write("Gols do time 2: ");
        time2 = int.Parse(Console.ReadLine());

        if (time1 > time2)
            Console.WriteLine("Time 1 venceu!");
        else if (time2 > time1)
            Console.WriteLine("Time 2 venceu!");
        else
            Console.WriteLine("Empate!");
