namespace RoboTupiniquim2025
{
    internal class Program
    {
        //-------------------------------------------------Criar Grid Limite de atuação do Robo
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Robo Tupiniquim - Missão Marte");
            Console.WriteLine("---------------------------------------------");

            Console.Write("Digite a coordenada X do mapa: ");
            int limiteX = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a coordenada Y do mapa: ");
            int limiteY = Convert.ToInt32(Console.ReadLine());

            Console.ReadLine();

            //------------------------------------------------Criar entrada da movimentação do robô


            Console.Write("Digite a coordenada A do Robô: ");
            int coordenadaA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a coordenada B do Robô: ");
            int coordenadaB = Convert.ToInt32(Console.ReadLine());

            Console.ReadLine();

            //-------------------------------------------------Criar a lógica limite de atuação

            for (int posicaoX = 0; posicaoX < limiteX; posicaoX++)
            {
                if (posicaoX > 0)
                {


                }






            }
        }
    }
}