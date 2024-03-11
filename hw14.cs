namespace Hw14;

public class Type14
{
    public void Start()
    {
        int note = GetNumber();

        Process(note);
    }

    public int GetNumber()
    {
        Console.WriteLine("Enter the note");
        return Convert.ToInt32(Console.ReadLine());
    }

    public void Process(int note)
    {
        switch (note)
        {
            case 10:
                Console.WriteLine("A+");
                break;
            case 9:
                Console.WriteLine("A");
                break;
            case 8:
                Console.WriteLine("B");
                break;
            case 7:
                Console.WriteLine("B");
                break;
            case 6:
                Console.WriteLine("C");
                break;
            case 5:
                Console.WriteLine("E");
                break;
            default: 
                Console.WriteLine("F");
                break;

        }
    }

}
