namespace JogoDeAdivinhação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random randomico = new Random();
            int numAleatorio = randomico.Next(1, 1001);
            int escolha = 0;
            Console.WriteLine("***************************************");
            Console.WriteLine("* Bem-Vindo(a) ao Jogo da Adivinhação *");
            Console.WriteLine("***************************************");

            Console.WriteLine("Escolha o nivel de dificuldade");
            Console.WriteLine("[1] Fácil       [2] Médio     [3] Dificil");
            int dificuldadeFacil = 15;
            int dificuldadeMedia = 10;
            int dificuldadeMaxima = 5;
            int nivelDeDificuldade = Convert.ToInt32(Console.ReadLine());
            
            int numeroEscolhido;
            int chute = 1;
            int pontos = 1000;
            

            if (nivelDeDificuldade == 1)
            {
                Console.WriteLine("Qual o seu " + chute + "chute?");
                numeroEscolhido = Convert.ToInt32(Console.ReadLine());
                pontos = pontos - Math.Abs(numeroEscolhido - numAleatorio / 2);

                while (escolha < 14) 
                {
                    if (numeroEscolhido != numAleatorio || escolha < 14 || pontos > 0)
                    {
                        chute = chute + 1;
                        escolha = escolha + 1;
                        dificuldadeFacil = dificuldadeFacil - 1;
                        if (numeroEscolhido < numAleatorio)
                        {
                            Console.WriteLine("O numero escolhido é menor que o valor aleatório");

                        }
                        if (numeroEscolhido > numAleatorio)
                        {
                            Console.WriteLine("O numero escolhido é maior que o valor aleatório");

                        }
                        if (numeroEscolhido == numAleatorio)
                        {
                            Console.WriteLine("Parabéns, você acertou!");
                            break;
                        }
                        
                        Console.WriteLine("Tente novamente!");
                        Console.WriteLine("Você fez " + pontos + " pontos!");
                        Console.WriteLine("Qual o seu" + chute + "chute, você tem " + dificuldadeFacil + " tentativas restantes");

                        numeroEscolhido = Convert.ToInt32(Console.ReadLine());
                        pontos = pontos - Math.Abs(numeroEscolhido - numAleatorio / 2);

                    }
                    if (pontos <= 0)
                    {
                        Console.WriteLine("Você estourou o limite de pontuação e perdeu o jogo! :(");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Parabéns, você ganhou!");
                        break;
                    }



                }
                   
                
            }
            if (nivelDeDificuldade == 2)
            {
                Console.WriteLine("Qual o seu " + chute + "chute?");
                numeroEscolhido = Convert.ToInt32(Console.ReadLine());
                pontos = pontos - (numeroEscolhido - numAleatorio / 2);

                while (escolha < 9)
                {
                    if (numeroEscolhido != numAleatorio || escolha < 9 || pontos > 0)
                    {
                        chute = chute + 1;
                        escolha = escolha + 1;
                        dificuldadeMedia = dificuldadeMedia - 1;
                        if (numeroEscolhido < numAleatorio)
                        {
                            Console.WriteLine("O numero escolhido é menor que o valor aleatório");
                        }
                        if (numeroEscolhido > numAleatorio)
                        {
                            Console.WriteLine("O numero escolhido é maior que o valor aleatório");

                        }
                        if (numeroEscolhido == numAleatorio)
                        {
                            Console.WriteLine("Parabéns, você acertou!");
                            break;
                        }
                        Console.WriteLine("Tente novamente!");
                        Console.WriteLine("Você fez " + pontos + " pontos!");
                        Console.WriteLine("Qual o seu" + chute + "chute, você tem " + dificuldadeMedia + " tentativas restantes");
                        numeroEscolhido = Convert.ToInt32(Console.ReadLine());
                        pontos = pontos - Math.Abs(numeroEscolhido - numAleatorio / 2);

                    }
                    if (pontos <= 0)
                    {
                        Console.WriteLine("Você estourou o limite de pontuação e perdeu o jogo! :(");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Parabéns, você ganhou!");
                        break;
                    }



                }



            }
            if (nivelDeDificuldade == 3)
            {
                Console.WriteLine("Qual o seu " + chute + "chute?");
                numeroEscolhido = Convert.ToInt32(Console.ReadLine());
                pontos = pontos - Math.Abs(numeroEscolhido - numAleatorio / 2);

                while (escolha < 4)
                {
                    if (numeroEscolhido != numAleatorio || escolha < 4 || pontos > 0)
                    {
                        chute = chute + 1;
                        escolha = escolha + 1;
                        dificuldadeMaxima = dificuldadeMaxima - 1;
                        if (numeroEscolhido < numAleatorio)
                        {
                            Console.WriteLine("O numero escolhido é menor que o valor aleatório");
                        }
                        if (numeroEscolhido>numAleatorio)
                        {
                            Console.WriteLine("O numero escolhido é maior que o valor aleatório");

                        }
                        if (numeroEscolhido == numAleatorio)
                        {
                            Console.WriteLine("Parabéns, você acertou!");
                            break;
                        }
                        Console.WriteLine("Tente novamente!");
                        Console.WriteLine("Você fez " + pontos + " pontos!");
                        Console.WriteLine("Qual o seu" + chute + "chute, você tem " + dificuldadeMaxima + " tentativas restantes");
                        numeroEscolhido = Convert.ToInt32(Console.ReadLine());
                        pontos = pontos - Math.Abs(numeroEscolhido - numAleatorio / 2);

                    }
                    if (pontos <= 0)
                    {
                        Console.WriteLine("Você estourou o limite de pontuação e perdeu o jogo! :(");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Parabéns, você ganhou!");
                        break;
                    }


                }


            }



        }
    }
}