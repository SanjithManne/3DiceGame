Random dice = new();

int roll1 = dice.Next(1,7);
int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7);
int sum = roll1 + roll2 + roll3;

Console.WriteLine("First Roll: "+roll1);
Console.WriteLine("Second Roll: "+roll2);
Console.WriteLine("Third Roll: "+roll3);
Console.WriteLine("Sum of all Rolls: "+sum);


if((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if((roll1 == roll2) && (roll2 == roll3))
    {
    sum +=6;
    Console.WriteLine("Since all three rolls are same 6 points are added");
    Console.WriteLine("New Total: "+ sum);
    }
else
{
    sum +=2;
    Console.WriteLine("You got two similar roles so 2 points are added.");
    Console.WriteLine("New Total: "+ sum);
}
}
//else if((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
//{
//sum +=2;
//    Console.WriteLine("You got two similar roles so 2 points are added.");
//    Console.WriteLine("New Total: "+ sum);
//}

if(sum >= 10)
{
    if(sum >= 16)
    {
        Console.WriteLine("You Win a Car!");
    }
    else
    {
        Console.WriteLine("You win a new Laptop!");
    }
}

else if(sum == 7)
{
    Console.WriteLine("You win a Trip!");
}

else
{
    Console.WriteLine("You win a Kitten!");
}
