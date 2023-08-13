using System;
using System.Linq;

public class Homework
{
    private static string[] GetElementsShorterThan3(string[] array)
    {
        string[] outputArray = new string[array.Length];
        int counter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            {
                outputArray[counter++] = array[i];
            }
        }
        Array.Resize(ref outputArray, counter);
        return outputArray;
    }
}
