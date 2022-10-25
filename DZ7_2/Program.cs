// Написать программу, упорядочивания по убыванию элементы каждой 
//строки двумерной массива
void FillArray(int[,] matr )
{
 for ( int i=0; i<matr.GetLength(0); i++)
 {
     for ( int j=0; j<matr.GetLength(1); j++)
     {
       matr[i, j] = new Random().Next(-10,10);
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

 void  SortArrey(int[,] matr)
{ int max = 0;
//int count = 0;
//int N = matr.GetLength(0);
     
     for(int i = 0; i<matr.GetLength(0); i++)
     {
     for(int j = 0; j<matr.GetLength(1)-1; j++)
     {
        for(int k = j+1; k<matr.GetLength(1); k++)
        {
         if(matr[i, j]<matr[i, k] )
        {
        max= matr[i,j];
        matr[i,j] =matr[i,k];
        matr[i,k] = max;
        }
        }
     }
    }
}
Console.WriteLine("Введите n");
int n= int.Parse(Console.ReadLine());
Console.WriteLine("Введите m");
int m= int.Parse(Console.ReadLine());
int[,] mass = new int[n,m];
FillArray(mass);
PrintArrye(mass);
Console.WriteLine("");
SortArrey(mass);
PrintArrye(mass); 

