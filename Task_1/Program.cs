//Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

// using System.Security.Cryptography.X509Certificates;

char[,] charsArray = {
    {'H','e','l','l','o'},
    {'W','o','r','l','d'}//двумерный массив
};
string res = "";//  переменная для создания строки 
for(int x = 0; x < charsArray.GetLength(0); x++)// цикл для перебора строк
{
  for(int y = 0; y < charsArray.GetLength(1); y++)// цикл для перебора столбцов
  {
    res = res + charsArray[x,y];// кладем элемент массива в результат(в строку).
  }
res = res + ' ';
  
}
  Console.WriteLine(res);