
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
            string[] nomesDosRobos = ["Azul", "Vermelho"];

            int quantidadeRobos = 2;

            Robo[] robos = new Robo[quantidadeRobos];

            for (int contador = 0; contador < robos.Length; contador++)
            {
                string[] coordenadasAtuais = posicoesIniciais[contador].Split(' ');

                Robo robo = new Robo();

                robo.nome = nomesDosRobos[contador];
                robo.posicaoX = Convert.ToInt32(coordenadasAtuais[0]);
                robo.posicaoY = Convert.ToInt32(coordenadasAtuais[1]);
                robo.direcao = Convert.ToChar(coordenadasAtuais[2]);

                char[] instrucoes = comandosIniciais[contador].ToCharArray();    //pq char [] instrucoes  aqui no robo um e nao nos demais ?

                robo.Explorar(instrucoes);

                Console.WriteLine(robo.ObterLocalizacao());

                robos[contador] = robo;
                
            }

            Console.ReadLine();
        }
    }
}


