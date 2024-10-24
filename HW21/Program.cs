using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

        Console.WriteLine("---------The first collection.----------");
Console.Write("How many numbers do you wanna enter?: ");
int q = Convert.ToInt32(Console.ReadLine());
int[] Numbers = new int[q];
bool check = true;
int a = 0;
while (check)
{
    Console.Write("Pleas enter a number: ");
    Numbers[a] = Convert.ToInt32(Console.ReadLine());
    a++;
    if (a == (Numbers.Length))
    {
        check = false;
    }
}
int max = Numbers[Numbers.Length-1];
int min = Numbers[0];
foreach(int Number in Numbers)
{
    if (Number < min) { min = Number; }
    if (Number > max) { max = Number; }
}
Console.WriteLine($"maximum number is {max} and minumum number is {min} ");
int[] Numbers2 = new int[q];
for(int i= 0; i<Numbers.Length; i++)    
{
    Numbers2[i]=Numbers[Numbers.Length-1-i];
}
Console.Write("The reverse of what you entered is : ");
foreach(int Number2 in Numbers2)
{
    Console.Write(Number2 + " ");
}
//int qm;
Console.WriteLine();
for (int i = 0; i < Numbers.Length; i++)
   for (int j = i + 1; j < Numbers.Length; j++)
    {
        if (Numbers[i] > Numbers[j])
        {
            Numbers[i] = Numbers[i] + Numbers[j];
            Numbers[j] = Numbers[i] - Numbers[j];
            Numbers[i] = Numbers[i] - Numbers[j];
        }
    }

Console.Write("The sorted form of the collection you have entered: ");
Console.Write("{ ");
foreach(int Number in Numbers)
{
   Console.Write(Number + ",");
}
Console.WriteLine("} ");
int[] dp = new int[q];
int count = 0;
for(int i=0;i<Numbers.Length;i++)
    for(int j=i+1;j<Numbers.Length;j++)
    {
        if (Numbers[i] == Numbers[j])
        {
            dp[count] = Numbers[i];
            count++;
        }
        else
        {
            
        }
    }
if (count == 0)
{
    Console.WriteLine("There is no duplicated number.");
}
else if(count ==1)
{
    Console.Write("The duplicated number is: ");
    for(int count2=0;count2<count;count2++)
        Console.Write(dp[count2]+"with index "+count2+", ");
}
else if (count > 1 )
{
    Console.Write("The duplicated numbers are: ");
    for (int count2 = 0; count2 < count; count2++)
        Console.Write(dp[count2] + "with index " + count2 + ", ");
}
Console.WriteLine();
        Console.WriteLine("---------The second collection.----------");
Console.Write("How many numbers do you wanna enter?: ");
int y = Convert.ToInt32(Console.ReadLine());
int[] Numbers3 = new int[y];
bool check3 = true;
int d = 0;
while (check3)
{
    Console.Write("Pleas enter a number: ");
    Numbers3[d] = Convert.ToInt32(Console.ReadLine());
    d++;
    if (d == (Numbers3.Length))
    {
        check3 = false;
    }
}
int[] dp2 = new int[y];
int h = 0;
foreach (int number4 in Numbers3)
  foreach(int number in Numbers)
    {
        if (number == number4)
        {
            dp2[h]=number;
            h++;
        }
    }
if (h != 0)
{
    Console.Write("These numbers are in both collections: ");
    for (int count3 = 0; count3 < h; count3++)
    {
        Console.Write(dp2[count3] + " "); 
    }

}

//for(int f=0;f<Numbers.Length;f++)
//    for(int g=0;g<Numbers3.Length;g++)

//    {
//        if(Numbers[f] == Numbers3[g])
//        {
//            dp2[h] = Numbers[f];
//        }
//        h++;
//    }
//foreach(int Number3 in dp2)
//{
//    Console.Write(Number3);

//}?????


