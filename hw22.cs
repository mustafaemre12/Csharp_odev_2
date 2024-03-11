namespace Hw22;

public class Type22
{
    public void Start()
    {
        int price = GetNumber("price");
        int given_money = GetNumber("given money");

    }

    public int GetNumber(string prefix)
    {
        Console.WriteLine("Enter the number" + prefix);
        return Convert.ToInt32(Console.ReadLine());
    }
}