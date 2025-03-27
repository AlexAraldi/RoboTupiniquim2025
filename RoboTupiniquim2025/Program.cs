using System.IO;
using System.Runtime.Intrinsics.X86;

namespace RoboTupiniquim2025
{
    // A área escolhida para análise é curiosamente retangular e os robôs devem andar por ela.
    // A posição de um robô é representada por uma combinação de coordenadas X e Y e também uma letra representando a direção que ele está olhando.
    // Use as orientações: N = norte, S = sul, L = leste, O = oeste.
    // E, D e M. As letras E e D fazem o robô virar 90 graus para esquerda e direita respectivamente,sem sair do lugar.
    // A letra M significa se mover uma posição no grid para frente, mantendo a mesma direção.
    // Assuma que mover o robô para frente, significa mover sua posição de (X, Y) para (X, Y+1).
    // Cada comando deve ser enviado em 2 partes: a primeira parte é a posição inicial do robô
    // e a segunda uma série de instruções que aquele robô deve seguir para explorar a área.
    // A posição é dada com 2 inteiros e uma letra, separados por espaços,correspondendo pelas coordenadas X e Y e a orientação do robô.

    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Robo Tupiniquim - Missão Marte");
                Console.WriteLine("---------------------------------------------");

                //------------------------------------------------Criar entrada da posição inicial do robô do grid

                string comando = "EMEMEMEMM";

                char[] instrucoes = comando.ToCharArray();

                int mapaGridX = 5;
                int mapaGridY = 5;
                char direcao = 'N';
                int posicaoX = 1;
                int posicaoY = 2;

                for (int i = 0; i < instrucoes.Length; i++)
                {
                    if (instrucoes[i] == 'D')
                    {
                        if (direcao == 'N')
                            direcao = 'L';
                        else if (direcao == 'L')
                            direcao = 'S';
                        else if (direcao == 'S')
                            direcao = 'O';
                        else if (direcao == 'O')
                            direcao = 'N';
                    }

                    if (instrucoes[i] == 'E')
                    {
                        if (direcao == 'N')
                            direcao = 'O';
                        else if (direcao == 'L')
                            direcao = 'N';
                        else if (direcao == 'S')
                            direcao = 'L';
                        else if (direcao == 'O')
                            direcao = 'S';

                    }
                    if (instrucoes[i] == 'M')
                    {
                        if (direcao == 'N')
                            posicaoY++;
                        else if (direcao == 'S')
                            posicaoY--;
                        else if (direcao == 'O')
                            posicaoX--;
                        else if (direcao == 'L')
                            posicaoX++;
                    }







                }
                    else if (instrucoes[i] == 'M')
                {
                    posicaoY++;
                }


            }
            Console.ReadLine();
        }
    }
}
}

