using System;

class guessinggame
{
    static void Main()
    {
        Random random = new Random();
        bool jogar = true;

        while (jogar)
        {
            jogarpartida(random);
            jogar = jogarnovamente();
        }

        Console.WriteLine("fim de jogo");
    }

    static void jogarpartida(Random random)
    {
        int numerosecreto = random.Next(1, 101);
        int chute = 0;
        int tentativas = 0;

        Console.WriteLine("\ntente acertar o número de 1 a 100");

        while (chute != numerosecreto)
        {
            Console.Write("seu chute: ");
            chute = GetRespostaValida();

            tentativas++;

            if (chute < numerosecreto)
                Console.WriteLine("maior, tente novamente");
            else if (chute > numerosecreto)
                Console.WriteLine("menor, tente novamente");
        }

        Console.WriteLine($"correto, você acertou em {tentativas} tentativa(s).");
    }

    static int GetRespostaValida()
    {
        while (true)
        {
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number) && number >= 1 && number <= 100)
                return number;

            Console.Write("input inválido, tente um número de 1 a 100: ");
        }
    }

    static bool jogarnovamente()
    {
        while (true)
        {
            Console.Write("jogar novamente? (s/n): ");
            string answer = Console.ReadLine().Trim().ToLower();

            if (answer == "s" || answer == "sim") return true;
            if (answer == "n" || answer == "nao") return false;

            Console.WriteLine("por favor responda com 's' ou 'n'.");
        }
    }
}