//Написать программу, которая в двумерном массиве заменяет 
//строки на столбцы или сообщить, 
//что это невозможно (в случае, если матрица не квадратная)
void FillArray(int[,] matr )
{
 for ( int i=0; i<matr.GetLength(0); i++)
 {
     for ( int j=0; j<matr.GetLength(1); j++)
     {
       matr[i, j] = new Random().Next(0,10);
     }
    }

}
 void PrintArrye(int[,] matr)
 {
    for ( int i=0; i<matr.GetLength(0); i++)
 {
     for ( int j=0; j<matr.GetLength(1); j++)
     {
        Console.Write($"{matr[i, j]} ");
     }
     Console.WriteLine();
 }
 }

 void ChengeStrng(int[,] matr)
{
    int count = 0;
    int a = 0;
    for(int i = 0; i<matr.GetLength(0); i++)  
    {
        for(int j = count+1; j<matr.GetLength(1); j++)  
        {a = matr[i, j];
        matr[i, j] = matr[j, i];
        matr[j, i] = a;
        }
        count++;
    }    
    
}

Console.WriteLine("Введите n");
int n= int.Parse(Console.ReadLine());
Console.WriteLine("Введите k");
int k= int.Parse(Console.ReadLine());
int[,] mass = new int[n,k];
FillArray(mass);
PrintArrye(mass);
Console.WriteLine("");
if (n!=k) 
{
Console.WriteLine("Матрица не квадратная");
}
else
{
ChengeStrng(mass);
PrintArrye(mass);
}

