using System;

class Sample
{
    protected static int origRow;
    protected static int origCol;

    protected static void WriteAt(string s, int x, int y)
    {
        try
        {
            Console.SetCursorPosition(origCol + x, origRow + y);
            Console.Write(s);
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.Clear();
            Console.WriteLine(e.Message);
        }
    }

    public static void Main()
    {
        int sideLenght;
        int count = 0;
        int index;
        int position;       
        sideLenght = Convert.ToInt32(Console.ReadLine());
        int savePos = sideLenght;
        Console.Clear();

        for (index = 0; index < savePos; index++)
        {
            WriteAt("*", sideLenght, index);
            sideLenght--;
            count++;
        }
        sideLenght = 3;
        for (position = count; position < (count+savePos) - 1 ; position++)
        {
            WriteAt("*", sideLenght, index - 1);
            sideLenght = sideLenght + 2;
        }
        for (position = 0; position < savePos - 2; position++)
        {
            WriteAt("*", sideLenght - 3, index - 2);
            sideLenght--;
            index--;
        }
        Console.ReadKey();
    }
}
