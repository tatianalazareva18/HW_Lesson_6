//Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

//level

string str = "level";

bool IsPalindrome(string str)
{

    for (int i = 0; i < str.Length / 2; i++)
    {
        if (str[i] != str.Length-1-i)
        {
            return true;
        }
}
    return false;
}


if ( IsPalindrome(str) )
{
    Console.WriteLine(str + " слово палиндром");
}
else 
{
    Console.WriteLine(str + " слово не палиндром");
}