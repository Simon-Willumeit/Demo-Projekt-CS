double AnsMath = 0;
double Prob1 = 0;
double Prob2 = 0;
double Sol = 0;
int Symbol = 0;
int score = 0;
bool correct = true;
Random rnd = new Random();

void ProbGen() //generates the math problem when called
{
    Prob1 = rnd.Next(1, 11);
    Prob2 = rnd.Next(1, 11);
}

void Adition()
{
    ProbGen();
    Console.WriteLine(Prob1 + "+" + Prob2 + "=");
    Sol = Math.Round(Prob1 + Prob2, 2, MidpointRounding.AwayFromZero);
    AnsCheck();
    if (Sol == AnsMath)
    {
        correct = true;
        Console.WriteLine("Correct");
    }
    else
    {
        correct = false;
        Console.WriteLine("Inccorect. The Solution was " + Sol);

    }
}

void Subtraction()
{
    ProbGen();
    Sol = Math.Round(Prob1 - Prob2, 2, MidpointRounding.AwayFromZero);
    Console.WriteLine(Prob1 + "-" + Prob2 + "=");
    AnsCheck();
    if (Sol == AnsMath)
    {
        correct = true;
        Console.WriteLine("Correct");
    }
    else
    {
        correct = false;
        Console.WriteLine("Inccorect. The Solution was " + Sol);

    }
}

void Multiplication()
{
    ProbGen();
    Console.WriteLine(Prob1 + "*" + Prob2 + "=");
    Sol = Math.Round(Prob1 * Prob2, 2, MidpointRounding.AwayFromZero);
    AnsCheck();
    if (Sol == AnsMath)
    {
        correct = true;
        Console.WriteLine("Correct");
    }
    else
    {
        correct = false;
        Console.WriteLine("Inccorect. The Solution was " + Sol);

    }
}

void Division()
{
    ProbGen();
    Console.WriteLine(Prob1 + "/" + Prob2 + "=");
    Sol = Math.Round(Prob1 / Prob2, 2, MidpointRounding.AwayFromZero);
    AnsCheck();
    if (Sol == AnsMath)
    {
        correct = true;
        score++;
        Console.WriteLine("Correct");
    }
    else
    {
        correct = false;
        Console.WriteLine("Inccorect. The Solution was " + Sol);

    }
}

void AnsCheck() //takes an input for the answer and checks to make sure it's valid when called.
{
CheckStart:
    string AnsInput = Console.ReadLine();
    bool AnsCheck1 = (String.IsNullOrEmpty(AnsInput));
    bool AnsCheck2 = false;
    decimal value;
    if (Decimal.TryParse(AnsInput, out value))
    {
        AnsCheck2 = true;
    }

    else
        AnsCheck2 = false;
    if (!AnsCheck1)
    {
        if (AnsCheck2)
        {
            AnsMath = Math.Round(Convert.ToDouble(AnsInput), 2, MidpointRounding.AwayFromZero);
        }
        else
        {
            Console.WriteLine("Please input a number.");
            goto CheckStart;
        }
    }
    else
    {
        Console.WriteLine("Please input a number.");
        goto CheckStart;
    }
}
while (correct == true)
{
    Symbol = rnd.Next(1, 5);
    if (Symbol == 1) { Adition(); }
    if (Symbol == 2) { Subtraction(); }
    if (Symbol == 3) { Multiplication(); }
    if (Symbol == 4) { Division(); }
    if (correct == true) { score++; }
    Console.ReadKey();
    Console.Clear();

}
Console.BackgroundColor = ConsoleColor.Red;
Console.Clear();
string GameOver = "Game Over";
string Scoremsg = "your score was " + score;
Console.SetCursorPosition((Console.WindowWidth - GameOver.Length) / 2, Console.CursorTop);
Console.WriteLine(GameOver);
Console.SetCursorPosition((Console.WindowWidth - Scoremsg.Length) / 2, Console.CursorTop); ;
Console.WriteLine(Scoremsg);
Console.ReadKey();



