namespace Hw11;

public class Type11
{
    public void Start()
    {
        Login();
    }

    public int Getİnfo(string str)
    {
        Console.WriteLine("Enter the " + str);
        return Convert.ToInt32(Console.ReadLine());
    }

    public void Login()
    {
        int real_username = 12;
        int real_password = 1234;

        int try_count = 0;
        while (try_count < 3)
        {
            int username = Getİnfo("username");
            int password = Getİnfo("password");

            if (username == real_username)
            {
                if (password == real_password)
                {
                    Console.WriteLine("Log in succesfull");
                    break;
                }
            }

            else
            {
                Console.WriteLine("Log in unsuccesfull");
                try_count++;
            }

        }
    }
}