Console.WriteLine("Как тебя зовут?");
string username = Console.ReadLine();

if(username.ToLower() == "art")
{
    Console.WriteLine("Привет, my dear friend");
}
else
{
    Console.Write("Привет,");
    Console.WriteLine(username);
}