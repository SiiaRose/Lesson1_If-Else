void getStageByAge(int age)
{
    if (age <= 0)
    {
        Console.WriteLine("Incorrect age!");
        return;
    }
    if (age > 18)
    {
        Console.WriteLine("You are adult");
        return;
    }
    if (age >= 14)
    {
        Console.WriteLine("You are teenager");
        return;
    }
    else
    {
        Console.WriteLine("You are child");
        return;
    }
}


getStageByAge(15);
getStageByAge(23);
getStageByAge(-2);
getStageByAge(3);