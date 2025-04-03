namespace RoboTupiniquim2025
{


    public static class Robo
    {
        public static int posicaoXRoboUm;
        public static int posicaoYRoboUm;
        public static int direcaoRoboUm;
    
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

        public static char VirarDireitaRoboUm()
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

        public static char VirarEsquerdaRoboUm()
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

        public static void MoverRoboDois(ref int posicaoXRoboDois, ref int posicaoYRoboDois, char direcaoRoboDois)
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

        public static char VirarDireitaRoboDois(char direcaoRoboDois)
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

        public static char VirarEsquerdaRoboDois(char direcaoRoboDois)
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



    }
}