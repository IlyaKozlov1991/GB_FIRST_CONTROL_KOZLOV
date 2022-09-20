// Write a program which will create a string array with strings which length is less or equal 3 from initial (received) string array.

Console.WriteLine("Enter your text:");
Console.WriteLine();

string UserData = Console.ReadLine();

char[] Separators = new char[] {' ', ',', '!', '.'};

string[] UserArray = UserData.Split(Separators, StringSplitOptions.RemoveEmptyEntries);

Console.WriteLine();
Console.WriteLine("Result:\n");

void ProcessArray(string[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (array[i].Length <= 3)
        {
            Console.Write(String.Format("{0,-7}", array[i]));
        }
        else
        {
            Console.Write(" ");
        }
    }
}

ProcessArray(UserArray);
Console.WriteLine("\n");