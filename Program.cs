

// содание исходного массива строк


System.Console.WriteLine("Ведите количество строк: " );
int line = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите строки: " );
string[] origArray = new string[line];

for (int i = 0; i < line; i++)
{
    origArray[i] = Console.ReadLine();
}

// вывод массивов
void PrintArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]+ " ");
    }
}



// содание нового массива
string[] newArray(string[] array, int length)
{
    int newI = 0;
    string[] newArray = new string[length];
    for (int i = 0; i < array.Length; i++)
    {    
        if (array[i].Length <= 3)
        {
            newArray[newI] = array[i];
            newI++;
        }

    }
    return newArray;
}

//определене длинны нового массива
int indexNewArray(string[] array)
 {
    
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
           count += 1;
        }
    }   
    return count;
    }

 // вывод результата

PrintArray(origArray);
int newLine = indexNewArray(origArray);
string[] newOrigArray = newArray(origArray, newLine);
System.Console.Write(" => ");
PrintArray(newOrigArray);


 