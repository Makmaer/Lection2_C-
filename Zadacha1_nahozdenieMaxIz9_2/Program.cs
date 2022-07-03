void RandomMassiv(int[] collect)
{
int length = collect.Length;
int i = 0;
while (i < length)
 {  
     collect[i] = new Random().Next(1, 10);
     i++;
 }
}
void PrintArray(int[] col)

{
   int count = col.Length;
   int position = 0;
   while (position < count)
   {
    Console.WriteLine(col[position]);
    position++;
   }
}
int Max(int[] mas)
{
   int count = mas.Length;
   int position = 0;
   int maxIndex = 0;
   int result = mas[0];
   while (position < count)
   {
     if(mas[position] > result) {result = mas[position]; maxIndex=position;}
     position++;}
  Console.WriteLine("Maximum = " + result);   
  Console.WriteLine("Индекс макисамльного числа = " + maxIndex);
  return result; return maxIndex;
 
}

int [] array = new int[10];
RandomMassiv (array);
PrintArray(array);
Max(array);