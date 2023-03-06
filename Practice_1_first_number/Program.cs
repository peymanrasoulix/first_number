// Peyman rasouli -- Practice_2_first_number

// tarif motaghayer
int num_min; int num_max;int num_revers;
int count = 0;
int Sqrt;
bool check;

// daryafte dade
Console.ForegroundColor = ConsoleColor.White;
Console.Write("First Number: ");num_min = int.Parse(Console.ReadLine());
Console.Write("Second Number: ");num_max = int.Parse(Console.ReadLine());
if (num_min > num_max)
{
    num_revers = num_max;
    num_max = num_min;
    num_min = num_revers;
    execute();
}
else
    execute();

// print dade
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine();
Console.WriteLine("{0} is the first number between {1} and {2}",count,num_min,num_max);
Console.ReadKey();

void execute()
{
    for (int i = num_min+1 ; i < num_max; i++)
    {
        check = true;
        Sqrt = Convert.ToInt32(Math.Sqrt(i));

        for (int j = 2; (check && j <= Sqrt); j++)
            if (i % j == 0)
                check = false;
        if (check)
        {
            Console.Write("{0} ", i);
            count++;
        }
    }
}
