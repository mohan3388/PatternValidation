namespace UserRegistration
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool check = true;
            Console.WriteLine("Welcome to User Registration Problem");
            while (check)
            {
                Console.WriteLine("\n1.Firstname\n2.Lastname\n");
                Console.WriteLine("Enter the above option");
                int Option = Convert.ToInt32(Console.ReadLine());
                switch (Option)
                {
                    case 1:
                        FirstName validation = new FirstName();
                        Console.WriteLine("Enter First Name: ");
                        string name = Console.ReadLine();
                        bool val = validation.FNameValidation(name);
                        if (val)
                        {
                            Console.WriteLine("Validate");
                        }
                        else
                        {
                            Console.WriteLine("Not Validate");
                        }
                        break;
                    case 2:
                        LastName lvalidation = new LastName();
                        Console.WriteLine("Enter Last Name: ");
                        string lname = Console.ReadLine();
                        bool lval = lvalidation.LNameValidation(lname);
                        if (lval)
                        {
                            Console.WriteLine("Validate");
                        }
                        else
                        {
                            Console.WriteLine("Not Validate");
                        }
                        break;
                    default:
                        Console.WriteLine("Enter Above option");
                        break;

                }
            }
        }
    }
}