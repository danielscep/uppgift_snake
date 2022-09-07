namespace UppgiftSnake
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int[] snakeTail = new int[] { 0, 0 }; //snake tail x,y position
            int[] snakeHead = new int[] { 0, 0 }; //snake head x,y position
            DrawMap(1, 10);
        }

        public static void DrawMap(int height, int width)
        {
            for (int i = 0; i < width; i++)
            {
                Console.Write("#");
            }
        }
    }
}