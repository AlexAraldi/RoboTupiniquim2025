namespace RoboTupiniquim2025
{


    public static class Robo
    {
        public static int posicaoXRoboUm;
        public static int posicaoYRoboUm;
        public static char direcaoRoboUm;
        public static int posicaoXRoboDois;
        public static int posicaoYRoboDois;
        public static char direcaoRoboDois;

        public static void MoverRoboUm()
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
        public static void VirarDireitaRoboUm()
        {
            if (direcaoRoboUm == 'N')
                direcaoRoboUm = 'L';

            else if (direcaoRoboUm == 'L')
                direcaoRoboUm = 'S';

            else if (direcaoRoboUm == 'S')
                direcaoRoboUm = 'O';

            else if (direcaoRoboUm == 'O')
                direcaoRoboUm = 'N';
        }
        public static void VirarEsquerdaRoboUm()
        {
            if (direcaoRoboUm == 'N')
                direcaoRoboUm = 'O';

            else if (direcaoRoboUm == 'O')
                direcaoRoboUm = 'S';

            else if (direcaoRoboUm == 'S')
                direcaoRoboUm = 'L';

            else if (direcaoRoboUm == 'L')
                direcaoRoboUm = 'N';

        }
        public static string ObterLocalizacaoRoboUm()
        {
            return $"{posicaoXRoboUm} {posicaoYRoboUm} {direcaoRoboUm}";
        }


        public static void MoverRoboDois()
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

        public static void VirarDireitaRoboDois()
        {
            if (direcaoRoboDois == 'N')
                direcaoRoboDois = 'L';

            else if (direcaoRoboDois == 'L')
                direcaoRoboDois = 'S';

            else if (direcaoRoboDois == 'S')
                direcaoRoboDois = 'O';

            else if (direcaoRoboDois == 'O')
                direcaoRoboDois = 'N';
        }

        public static void VirarEsquerdaRoboDois()
        {
            if (direcaoRoboDois == 'N')
                direcaoRoboDois = 'O';

            else if (direcaoRoboDois == 'O')
                direcaoRoboDois = 'S';

            else if (direcaoRoboDois == 'S')
                direcaoRoboDois = 'L';

            else if (direcaoRoboDois == 'L')
                direcaoRoboDois = 'N';
        }

        public static string ObterLocalizacaoRoboDois()
        {
            return $"{posicaoXRoboDois} {posicaoYRoboDois} {direcaoRoboDois}";
        }




    }
}