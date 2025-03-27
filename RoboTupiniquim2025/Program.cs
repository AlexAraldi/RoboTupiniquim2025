
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

            Console.Write("Informe do tamanho do Grid (X espaço Y): ");
            string[] grid = Console.ReadLine().Split(' ');
            int limiteX = int.Parse(grid[0]);
            int limiteY = int.Parse(grid[1]);

            Console.WriteLine("Informe a posição inicial do Robô no grid (X e Y) e o sentido que ele está: (ex: N,S,L, ou O):  ");
            string[] posicoes = Console.ReadLine().Split(' ');
            int posicaoX = int.Parse(posicoes[0]);
            int posicaoY = int.Parse(posicoes[1]);
            char direcao = char.Parse(posicoes[2]);

            Console.WriteLine("Informe os comandos que o Robô01 deve executar:(Ex:EMEMEMEMM) ");
            string comando = Console.ReadLine();
            char[] instrucoes = comando.ToCharArray();
//_____________________________________________________________________________________movimentos do Robô____________

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
//---------------------------------------------------------------------------------------------------------------------------------
            //validar os limites do grid  e criar novo robo
            Console.WriteLine($"{posicaoX} {posicaoY} {direcao}");
            Console.ReadLine();
        }
    }
}


