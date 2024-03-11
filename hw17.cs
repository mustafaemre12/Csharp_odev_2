namespace Hw17;

public class Type17
{
    public void Start()
    {
        string[] strings = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "İ", "J", "K", "L", "M", "N", "O", "Ö", "P", "R" };
        Process(strings);
    }


    public void Process(string[] strings)
    {
        int count = 0;
        while (count < strings.Length)
        {
            Console.WriteLine(strings[count]);
            count++;
        }
    }
}