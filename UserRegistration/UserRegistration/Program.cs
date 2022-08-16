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
                Console.WriteLine("\n1.Firstname\n2.Lastname\n3.Email\n4.Mobile\n5.Password\n6.Password Include One Uppecase\n7.Password Include One Numeric\n8.Password Include One Special char");
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
                    case 3:
                        Email Evalidation = new Email();
                        Console.WriteLine("Enter Email: ");
                        string Ename = Console.ReadLine();
                        bool Eval = Evalidation.EmailValidation(Ename);
                        if (Eval)
                        {
                            Console.WriteLine("Validate");
                        }
                        else
                        {
                            Console.WriteLine("Not Validate");
                        }
                        break;
                    case 4:
                        Mobile mvalidation = new Mobile();
                        Console.WriteLine("Enter Mobile: ");
                        string Mname = Console.ReadLine();
                        bool Mval =mvalidation.MobileValidation(Mname);
                        if (Mval)
                        {
                            Console.WriteLine("Validate");
                        }
                        else
                        {
                            Console.WriteLine("Not Validate");
                        }
                        break;
                    case 5:
                        Password pvalidation = new Password();
                        Console.WriteLine("Enter Password: ");
                        string Pname = Console.ReadLine();
                        bool Pval = pvalidation.PassValidation(Pname);
                        if (Pval)
                        {
                            Console.WriteLine("Validate");
                        }
                        else
                        {
                            Console.WriteLine("Not Validate");
                        }
                        break;
                    case 6:
                        PassIncludeUppercase pavalidation = new PassIncludeUppercase();
                        Console.WriteLine("Enter Password: ");
                        string pass2 = Console.ReadLine();
                        bool val2 = pavalidation.PassIncludeOneUppercase(pass2);
                        if (val2)
                        {
                            Console.WriteLine("Validate");
                        }
                        else
                        {
                            Console.WriteLine("Not Validate");
                        }
                        break;
                    case 7:
                        PassIncludeNumeric pasvalidation = new PassIncludeNumeric();
                        Console.WriteLine("Enter Password: ");
                        string pass3 = Console.ReadLine();
                        bool val3 = pasvalidation.PassIncludeOneNumeric(pass3);
                        if (val3)
                        {
                            Console.WriteLine("Validate");
                        }
                        else
                        {
                            Console.WriteLine("Not Validate");
                        }
                        break;
                    case 8:
                        PassIncludeSpcialChar passvalidation = new PassIncludeSpcialChar();
                        Console.WriteLine("Enter Password: ");
                        string pass4 = Console.ReadLine();
                        bool val4 = passvalidation.PassIncludeOneSpecialChar(pass4);
                        if (val4)
                        {
                            Console.WriteLine("Validate");
                        }
                        else
                        {
                            Console.WriteLine("Not Validate");
                        }
                        break;
                    case 9:
                        AllEmailSample Emvalidation = new AllEmailSample();
                        Console.WriteLine("Enter Email: ");
                        string emails = Console.ReadLine();
                        bool emval = Emvalidation.EmailValidation(emails);
                        if (emval)
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