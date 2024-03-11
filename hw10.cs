using System.ComponentModel.Design;

namespace Hw10;

public class Type10
{
    public void Start()
    {
        int number = 1;
        while (number < 500)
        {
            number++;

            if (number % 15 == 0)
            {
                Console.WriteLine(number);
            }
        }
    }
}