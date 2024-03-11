namespace Hw1;

public class Type1
{
    public void Start()
    {
        while (true)
        {

            int number1 = Getnumber("1");

            string choice = GetChoice();

            int number2 = Getnumber("2");

            if (choice == "+")
            {
                Sum(number1, number2);
            }

            else if (choice == "-")
            {
                Minus(number1, number2);
            }

            else if (choice == "x")
            {
                Mult(number1, number2);
            }

            else if (choice == "/")
            {
                Divide(number1, number2);
            }

            else
            {
                Console.WriteLine("This charecter is not available");
                break;
            }
        }
    }

    public int Getnumber(string numberprefix)
    {
        Console.WriteLine("Enter the number " + numberprefix);
        return Convert.ToInt32(Console.ReadLine());
    }

    public string GetChoice() 
    {
        Console.WriteLine("Add:+ Minus:- Mult:x Divide:/");
        return Console.ReadLine();
    }

    public void Sum(int number1, int number2) 
    {
        int sum = number1 + number2;
        Console.WriteLine(sum);
    }

    public void Minus(int number1, int number2) 
    {
        int min = number1 - number2;
        Console.WriteLine(min);
    }

    public void Mult(int number1, int number2)
    {
        int mult = number1 - number2;
        Console.WriteLine(mult);
    }

    public void Divide(int number1, int number2) 
    {
        int div = number1 - number2;
        Console.WriteLine(div);
    }
}