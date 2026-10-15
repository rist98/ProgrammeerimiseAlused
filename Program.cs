int randomNumber = new Random().Next(1, 101);
Console.WriteLine("Arva millise arvu peale 1 ja 100 vahel ma mõtlen?");
int userGuess = Convert.ToInt32(Console.ReadLine());
bool isCorrect = false;

while (!isCorrect)
{
    if (userGuess < randomNumber)
    {
        Console.WriteLine("Liiga väike! Proovi uuesti.");
        userGuess = Convert.ToInt32(Console.ReadLine());
    }
    else if (userGuess > randomNumber)
    {
        Console.WriteLine("Liiga suur! Proovi uuesti.");
        userGuess = Convert.ToInt32(Console.ReadLine());
    }
    else if (userGuess == randomNumber)
    {
        Console.WriteLine("Õige! Sa arvasid numbri ära!");
        isCorrect = true;
    }
    else
    {
        Console.WriteLine("Error: Sisesta korrektne arv!");
        userGuess = Convert.ToInt32(Console.ReadLine());
    }
    
}
Console.WriteLine("Press any key to exit...");
Console.ReadKey();
