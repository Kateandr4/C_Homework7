// В прямоугольной матрице найти строку с наименьшей суммой элементов.
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

 int[] SumElement(int[,] matr)
{
   int[] arrey =new int [matr.GetLength(1)];
   int[] temp =new int [matr.GetLength(0)];
   int sum = 0;
   int count = 0; 
    for(int i = 0; i<matr.GetLength(0); i++) 
    { 
       for(int j = 0; j<matr.GetLength(1); j++)  
        {
          sum = sum + matr[i, j];
        }
       temp[i]=sum;
       sum =0;
    }
    int min = temp[0];
    for(int i = 1; i<temp.Length; i++) 
    {  
       if (temp[i] < min)
        {
         min = temp[i];
         count =i;
        }
    }
    for(int i = 0; i<arrey.Length; i++) 
    {
        arrey[i]=matr[count,i];
    }
    return arrey;
}

Console.WriteLine("Введите n");
int n= int.Parse(Console.ReadLine());
Console.WriteLine("Введите m ");
int m= int.Parse(Console.ReadLine());
int[,] mass = new int[n,m];
Console.WriteLine("");
FillArray(mass);
PrintArrye(mass);
Console.WriteLine("");
//SumElement(mass, m);
int[] arr = SumElement(mass);
for(int i = 0; i<arr.Length; i++) 
Console.Write($" {arr[i]}" ); 

