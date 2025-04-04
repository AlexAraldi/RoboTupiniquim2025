namespace RoboTupiniquim2025
{       public  class Robo
    {
        public  int posicaoX;
        public  int posicaoY;
        public  char direcao;

        public  void Mover()
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
        public  void VirarDireita()
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
        public  void VirarEsquerda()
        {
            if (direcao == 'N')
                direcao = 'O';

            else if (direcao == 'O')
                direcao = 'S';

            else if (direcao == 'S')
                direcao = 'L';

            else if (direcao == 'L')
                direcao = 'N';
        }
        public  string ObterLocalizacao()
        {
            return $"{posicaoX} {posicaoY} {direcao}";
        }

    }
}