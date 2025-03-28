
using System.ComponentModel.DataAnnotations;

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

            Console.Clear();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Robo Tupiniquim - Missão Marte");
            Console.WriteLine("---------------------------------------------");

            Console.Write("Informe os valores do tamanho do PRIMEIRO Grid (X espaço Y): ");
            string[] grid = Console.ReadLine().Split(' ');
            int limiteX = int.Parse(grid[0]);
            int limiteY = int.Parse(grid[1]);

            Console.WriteLine("Informe a posição inicial do PRIMEIRO Robô no grid (X e Y) e o sentido que ele está: (ex: N,S,L, ou O):  ");
            string[] posicoes = Console.ReadLine().Split(' ');
            int posicaoX = int.Parse(posicoes[0]);
            int posicaoY = int.Parse(posicoes[1]);
            char direcao = char.Parse(posicoes[2]);

            Console.WriteLine("Informe os comandos que o PRIMEIRO Robô deve executar:(Ex:EMEMEMEMM) ");
            string comando = Console.ReadLine();
            char[] instrucoes = comando.ToCharArray();
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
                else if (instrucoes[i] == 'E')
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
                else if (instrucoes[i] == 'M')
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
            if (posicaoX > limiteX || posicaoY > limiteY)
            {
                Console.WriteLine("O Robô estrapolou o PRIMEIRO grid");
                Console.ReadLine();
            }
            else 
            {
                Console.WriteLine($"{posicaoX} {posicaoY} {direcao}");
                Console.ReadLine();
            }


            //------------------------------------- SEGUNDO ROBÔ --------------------------------------------


            Console.Write("Informe os valores do tamanho do SEGUNDO Grid (X espaço Y): ");
            string[] grid2 = Console.ReadLine().Split(' ');
            int limiteX2 = int.Parse(grid2[0]);
            int limiteY2 = int.Parse(grid2[1]);

            Console.WriteLine("Informe a posição inicial do SEGUNDO Robô no grid (X e Y) e o sentido que ele está: (ex: N,S,L, ou O):  ");
            string[] posicoes2 = Console.ReadLine().Split(' ');
            int posicaoX2 = int.Parse(posicoes2[0]);
            int posicaoY2 = int.Parse(posicoes2[1]);
            char direcao2 = char.Parse(posicoes2[2]);

            Console.WriteLine("Informe os comandos que o SEGUNDO Robô deve executar:(Ex:EMEMEMEMM) ");
            string comando2 = Console.ReadLine();
            char[] instrucoes2 = comando2.ToCharArray();
            for (int i = 0; i < instrucoes.Length; i++)
            {
                if (instrucoes2[i] == 'D')
                {
                    if (direcao2 == 'N')
                        direcao2 = 'L';
                    else if (direcao2 == 'L')
                        direcao2 = 'S';
                    else if (direcao2 == 'S')
                        direcao2 = 'O';
                    else if (direcao2 == 'O')
                        direcao2 = 'N';
                }
                else if (instrucoes2[i] == 'E')
                {
                    if (direcao2 == 'N')
                        direcao2 = 'O';
                    else if (direcao2 == 'L')
                        direcao2 = 'N';
                    else if (direcao2 == 'S')
                        direcao2 = 'L';
                    else if (direcao2 == 'O')
                        direcao2 = 'S';

                }
                else if (instrucoes2[i] == 'M')
                {
                    if (direcao2 == 'N')
                        posicaoY2++;
                    else if (direcao2 == 'S')
                        posicaoY2--;
                    else if (direcao2 == 'O')
                        posicaoX2--;
                    else if (direcao2 == 'L')
                        posicaoX2++;
                }
            }
            if (posicaoX2 > limiteX2 || posicaoY2 > limiteY2)
            {
                Console.WriteLine("O Robô estrapolou o SEGUNDO grid");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"{posicaoX2} {posicaoY2} {direcao2}");
                Console.ReadLine();
            }


        }
    }
}


