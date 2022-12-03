//Доделать ввод многочлена https://github.com/iksergey/multi/blob/lesson7/Program.cs
//*Сделать вывод только нечетных коэффициентов у треугольника распечатайте 
//хотя бы 120 строк
int[,] CreateTriangle(int row)
{
  int[,] triangle = new int[row, row];
  for (int i = 0; i < row; i++)
  {
    triangle[i, 0] = 1; //1 столбец во всех строках
    triangle[i, i] = 1; //диагональ
  }

  for (int i = 2; i < row; i++) // т.к. 1 столбец уже задали
  {
    for (int j = 1; j <= i; j++)
    {
      triangle[i, j] =
      triangle[i - 1, j - 1] + triangle[i - 1, j]; // формула коэффициентов из треуг. Паскаля
    }
  }
  return triangle;
}

void PrintTriangle(int[,] triangle)
{
  int row = triangle.GetLength(0);
  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < row; j++)
    {
      if (triangle[i, j] % 2 != 0) Console.Write("*");
       // Console.Write($"{triangle[i, j],4}"); //4 -кол-во пробелов между цифрами
         // Console.Write("*");
      else  Console.Write(" ");
    }
    Console.WriteLine();
  }
}

//int[] GetKoeff(int[,] tr, int pow) //выборка коэффициентов для создания многочлена
//{
 // int[] row = new int[pow + 1];
  //for (int i = 0; i <= pow; i++)
 // {
 //   row[i] = tr[pow, i];
 // }
  //return row;
//}
//Клиентский код
int[,] tr = CreateTriangle(120);
PrintTriangle(tr);
//int[] koeff = GetKoeff(tr, 2);

//System.Console.WriteLine(String.Join(' ', koeff)); //красивый вывод одномерного массива

//System.Console.WriteLine(koeff.Length);

//for (int i = 0; i < koeff.Length; i++)
//{
 // Console.Write($"{koeff[i]}*a^{koeff.Length - 1 - i}*b^{i} + ");
//}