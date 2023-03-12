Console.Clear();
string[] array = new string[] { "Sunday", "Mon", "Tuesday", "Wed", "Thu", "Friday", "Sat" };
string[] newArray = new string[array.Length];

void CreateArray (string[] inArray, string[] outArray)
{   
    int index = 0;
    for (int i = 0; i < inArray.Length; i++)
    {   if(inArray[i].Length <= 3) {outArray[index]=inArray[i]; index++;}}
}
CreateArray(array, newArray);
   

void PrintArray(string[] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        Console.Write($"{inArray[i]} ");
    }
        Console.WriteLine();
}

PrintArray(newArray);