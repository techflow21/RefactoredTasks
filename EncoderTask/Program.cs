namespace Class1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter En to Encrypt or \nDE for Decrypt: ");
            var input = Console.ReadLine();

            if (input?.ToUpper() == "EN")
            {
                Console.WriteLine("Enter text to encrypt: ");
                var encryptInput = Console.ReadLine();

                string output = Class1.encrypt1(encryptInput);
                Console.WriteLine(output);

            }
            else if (input?.ToUpper() == "DE")
            {
                Console.WriteLine("Enter text to decrypt: ");
                var decryptInput = Console.ReadLine();
                string output = Class1.decrypt1(decryptInput);
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("You entered invalid characters");
            }

            Console.ReadLine();
        }
    }
}
