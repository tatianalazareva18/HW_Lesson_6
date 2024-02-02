//Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами.
// Сформировать строку, в которой слова расположены в обратном порядке. 
//В полученной строке слова должны быть также разделены пробелами.
string str = "green big crocodile";

string ReversTheLine(string str)
{
    string[] words = str.Split(' ');
    Array.Reverse(words);
    str = "";

    foreach (string item in words)
    {
        //Console.WriteLine(item);
        str += item + ' ';
    }
    return str;

}


Console.WriteLine(ReversTheLine(str));

