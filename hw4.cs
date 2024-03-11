namespace Hw4;

public class Type4
{
    public void Start()
    {
        int numberx = Getnumber("x");
        int numbery = Getnumber("y");
        int numberz = Getnumber("z");

        Process(numberx, numbery, numberz);
    }

    public int Getnumber(string numberprefix)
    {
        Console.WriteLine("Enter the number " + numberprefix);
        return Convert.ToInt32(Console.ReadLine());
    }

    public void Process(int numberx, int numbery, int numberz)
    {
        if (numberx > numbery)
        {
            if(numberx > numberz)
            {
                Console.WriteLine(numberx);
            }
        }

        if (numbery > numberx)
        {
            if (numbery > numberz)
            {
                Console.WriteLine(numbery);
            }
        }

        if (numberz > numberx)
        {
            if (numberz > numbery)
            {
                Console.WriteLine(numberz);
            }
        }
    }
}