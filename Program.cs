string[] startarray = new string[7] {"men", "99999", "Rus", "computer scine" ,"+", "да" ,"homework" };
string[] finalarray= new string[startarray.Length];
void array(string[] startarray, string[] finalarray)
{
    int count = 0;
    for (int i = 0; i < startarray.Length; i++)
    {
    if(startarray[i].Length <= 3)
        {
        finalarray[count] = startarray[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
array(startarray, finalarray);
PrintArray(finalarray);