
// содание исходного массива строк
System.Console.WriteLine("Ведите количество строк: " );
int line = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите строки: " );
string[] origArray = new string[line + 1];

for (int i = 0; i < line; i++)
{
    origArray[i] = Console.ReadLine();
}
void PrintArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]+ " ");
    }
}
PrintArray(origArray);


// string[] newArray(string[] array)
// {
//     int j = 0;
//     string[] newArray = new string[j];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i].Length <= 3)
//         {
//             newArray[j] = array[i];
//             j++;
//         }

//     }
//     return newArray;
// }
// string[] newOrigArray = newArray(origArray);
// PrintArray(newOrigArray);
 int indexNewArray( string[] array)
 {
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
 }