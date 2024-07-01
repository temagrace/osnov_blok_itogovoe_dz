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