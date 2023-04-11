namespace Internal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");

            Random randomic = new Random();
            int random_number = randomic.Next(1, 21);
            int secretnumber = random_number;
            int limit = 21;
            int minimum = 0;
            int guess;
            int chances = 5;
            int tries = 0;

            while (tries < chances)
            {
                Console.WriteLine("Digite um número até 20:");

                if (int.TryParse(Console.ReadLine(), out guess))
                {
                    if (guess == secretnumber)
                    {
                        Console.WriteLine("Acertou");
                        break;
                    }
                    else if (guess > limit || guess < minimum)
                    {
                        Console.WriteLine("O número deve estar entre 1 e 20");
                        tries += 1;
                    }
                    else
                    {
                        Console.WriteLine("Resposta errada, tente novamente");
                        tries += 1;
                    }
                }
            }
            if(tries == chances){
                Console.WriteLine("Você perdeu");
            }
        }
    }
}
