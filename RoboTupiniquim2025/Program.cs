
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

            string[] posicoesIniciais = ["1 2 N", "3 3 L"];
            string[] comandosIniciais = ["EMEMEMEMM", "MMDMMDMDDM"];

            #region Movimentos do primeiro robô
            string[] coordenadasAtuais = posicoesIniciais[0].Split(' ');

            int posicaoXRoboUm = Convert.ToInt32(coordenadasAtuais[0]);
            int posicaoYRoboUm = Convert.ToInt32(coordenadasAtuais[1]);
            char direcaoRoboUm = Convert.ToChar(coordenadasAtuais[2]);

            char[] instrucoes = comandosIniciais[0].ToCharArray();

            for (int i = 0; i < instrucoes.Length; i++)
            {
                char instrucaoAtual = instrucoes[i];

                if (instrucaoAtual == 'E')
                    direcaoRoboUm = VirarEsquerdaRoboUm(direcaoRoboUm);

                else if (instrucaoAtual == 'D')
                    direcaoRoboUm = VirarDireitaRoboUm(direcaoRoboUm);

                else if (instrucaoAtual == 'M')
                    MoverRoboUm(ref posicaoXRoboUm, ref posicaoYRoboUm, direcaoRoboUm);
                
            }
            #endregion

            #region Movimentos do segundo robô
            coordenadasAtuais = posicoesIniciais[1].Split(' ');

            int posicaoXRoboDois = Convert.ToInt32(coordenadasAtuais[0]);
            int posicaoYRoboDois = Convert.ToInt32(coordenadasAtuais[1]);
            char direcaoRoboDois = Convert.ToChar(coordenadasAtuais[2]);

            instrucoes = comandosIniciais[1].ToCharArray();

            for (int i = 0; i < instrucoes.Length; i++)
            {
                char instrucaoAtual = instrucoes[i];

                if (instrucaoAtual == 'E')
                {
                    direcaoRoboDois = VirarEsquerdaRoboDois(direcaoRoboDois);
                }
                else if (instrucaoAtual == 'D')
                {
                    direcaoRoboDois = VirarDireitaRoboDois(direcaoRoboDois);
                }
                else if (instrucaoAtual == 'M')
                {
                    MoverRoboDois(ref posicaoXRoboDois, ref posicaoYRoboDois, direcaoRoboDois);
                }
            }
            #endregion

            Console.WriteLine($"{posicaoXRoboUm} {posicaoYRoboUm} {direcaoRoboUm}");
            Console.WriteLine($"{posicaoXRoboDois} {posicaoYRoboDois} {direcaoRoboDois}");

            Console.ReadLine();
        }

        private static void MoverRoboDois(ref int posicaoXRoboDois, ref int posicaoYRoboDois, char direcaoRoboDois)
        {
            if (direcaoRoboDois == 'N')
                posicaoYRoboDois++;

            else if (direcaoRoboDois == 'S')
                posicaoYRoboDois--;

            else if (direcaoRoboDois == 'O')
                posicaoXRoboDois--;

            else if (direcaoRoboDois == 'L')
                posicaoXRoboDois++;
        }

        private static char VirarDireitaRoboDois(char direcaoRoboDois)
        {
            if (direcaoRoboDois == 'N')
                direcaoRoboDois = 'L';

            else if (direcaoRoboDois == 'L')
                direcaoRoboDois = 'S';

            else if (direcaoRoboDois == 'S')
                direcaoRoboDois = 'O';

            else if (direcaoRoboDois == 'O')
                direcaoRoboDois = 'N';
            return direcaoRoboDois;
        }

        private static char VirarEsquerdaRoboDois(char direcaoRoboDois)
        {
            if (direcaoRoboDois == 'N')
                direcaoRoboDois = 'O';

            else if (direcaoRoboDois == 'O')
                direcaoRoboDois = 'S';

            else if (direcaoRoboDois == 'S')
                direcaoRoboDois = 'L';

            else if (direcaoRoboDois == 'L')
                direcaoRoboDois = 'N';
            return direcaoRoboDois;
        }

        private static void MoverRoboUm(ref int posicaoXRoboUm, ref int posicaoYRoboUm, char direcaoRoboUm)
        {
            if (direcaoRoboUm == 'N')
                posicaoYRoboUm++;

            else if (direcaoRoboUm == 'S')
                posicaoYRoboUm--;

            else if (direcaoRoboUm == 'O')
                posicaoXRoboUm--;

            else if (direcaoRoboUm == 'L')
                posicaoXRoboUm++;
        }

        private static char VirarDireitaRoboUm(char direcaoRoboUm)
        {
            if (direcaoRoboUm == 'N')
                direcaoRoboUm = 'L';

            else if (direcaoRoboUm == 'L')
                direcaoRoboUm = 'S';

            else if (direcaoRoboUm == 'S')
                direcaoRoboUm = 'O';

            else if (direcaoRoboUm == 'O')
                direcaoRoboUm = 'N';
            return direcaoRoboUm;
        }

        private static char VirarEsquerdaRoboUm(char direcaoRoboUm)
        {
            if (direcaoRoboUm == 'N')
                direcaoRoboUm = 'O';

            else if (direcaoRoboUm == 'O')
                direcaoRoboUm = 'S';

            else if (direcaoRoboUm == 'S')
                direcaoRoboUm = 'L';

            else if (direcaoRoboUm == 'L')
                direcaoRoboUm = 'N';

            return direcaoRoboUm;
        }
    }
}


