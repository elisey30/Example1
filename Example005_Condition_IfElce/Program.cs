Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "кристина") 
{
     Console.WriteLine("Я тебя люблю"); 
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}