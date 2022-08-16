namespace UserRegistration
{
    class Program
    {
        public static void Main(string[] args)
        {
            Validation validation = new Validation();
            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();
            bool val = validation.FNameValidation(name);
            if(val)
            {
                Console.WriteLine("Validate");
            }
            else
            {
                Console.WriteLine("Not Validate");
            }
        }
    }
}