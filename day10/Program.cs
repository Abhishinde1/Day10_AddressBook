namespace day10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonDetails contact = new PersonDetails();
            Console.WriteLine("Enter the number of Address Books you want to add:");
            int noOfAddressBooks = Convert.ToInt32(Console.ReadLine());
            int noOfBooks = 0;

            while (noOfBooks != noOfAddressBooks)
            {
                PersonDetails user = new PersonDetails();
                string keyPress = "y";
                Console.WriteLine("Enter the name of address book:");
                string addressBookName = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Enter your Choice to perform specific operation on address book.");
                Console.WriteLine();
                while (keyPress != "n")
                {
                    Console.WriteLine("Choose option\n  1:AddContact");
                    int option = Convert.ToInt32(Console.ReadLine());

                    switch (option)
                    {

                        case 1:
                            Console.WriteLine("Enter how many contacts you want to add to address book:");
                            int number = Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i < number; i++)

                                user.AddContact();
                            break;

                    }
                }
            }
        }
    }
}