namespace Day8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Problem2();   
        }

        public static void Problem2()
        {
            string[] lines = File.ReadAllLines("input.txt");

            int cols = lines[0].Length;
            int rows = lines.Length;

            int[] heights = new int[cols * rows];

            for (int i = 0; i < lines.Length; i++)
            {
                for (int j = 0; j < lines[i].Length; j++)
                {
                    heights[(i * cols) + j] = int.Parse(lines[i][j].ToString());
                }
            }

            int[] dirs = new int[] { -cols, 1, cols, -1 };
            int totalVisible = 0;
            int maxViewingSocre = int.MinValue;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    int index = (row * cols) + col;
                    int height = heights[(row * cols) + col];

                    bool visible = false;
                    int viewingScore = 1;

                    foreach (int dir in dirs)
                    {
                        bool dirVisible = true;

                        int dx = dir % cols;
                        int dy = dir / cols;
                        int viewingDistance = 0;

                        for (int i = 1; i < Math.Max(rows, cols); i++)
                        {
                            int checkCol = col + dx * i;
                            int checkRow = row + dy * i;

                            if (checkRow < 0 || checkRow >= rows)
                            {
                                break;
                            }
                            else if (checkCol < 0 || checkCol >= cols)
                            {
                                break;
                            }

                            int checkHeight = heights[(checkRow * cols) + checkCol];
                            viewingDistance++;

                            if (checkHeight >= height)
                            {
                                dirVisible = false;
                                break;
                            }
                        }

                        visible |= dirVisible;
                        viewingScore *= viewingDistance;
                    }

                    Console.Write($"{(viewingScore)}");

                    if (maxViewingSocre < viewingScore)
                    {
                        maxViewingSocre = viewingScore;
                    }

                    totalVisible += (visible) ? 1 : 0;
                }
                Console.WriteLine();
            }

            Console.WriteLine(maxViewingSocre);
        }

        public static void Problem1()
        {
            string[] lines = File.ReadAllLines("input.txt");

            int cols = lines[0].Length;
            int rows = lines.Length;

            int[] heights = new int[cols * rows];

            for (int i = 0; i < lines.Length; i++)
            {
                for (int j = 0; j < lines[i].Length; j++)
                {
                    heights[(i * cols) + j] = int.Parse(lines[i][j].ToString());
                }
            }

            int[] dirs = new int[] { -cols, 1, cols, -1 };
            int totalVisible = 0;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    int index = (row * cols) + col;
                    int height = heights[(row * cols) + col];

                    bool visible = false;

                    foreach (int dir in dirs)
                    {
                        bool dirVisible = true;

                        int dx = dir % cols;
                        int dy = dir / cols;

                        for (int i = 1; i < Math.Max(rows, cols); i++)
                        {
                            int checkCol = col + dx * i;
                            int checkRow = row + dy * i;

                            if (checkRow < 0 || checkRow >= rows)
                            {
                                break;
                            }
                            else if (checkCol < 0 || checkCol >= cols)
                            {
                                break;
                            }

                            int checkHeight = heights[(checkRow * cols) + checkCol];

                            if (checkHeight >= height)
                            {
                                dirVisible = false;
                                break;
                            }
                        }

                        visible |= dirVisible;

                        if (visible)
                        {
                            break;
                        }
                    }

                    Console.Write($"{(visible ? "T" : "F")}");

                    //Console.WriteLine($"Checking {row},{col} {visible}");

                    totalVisible += (visible) ? 1 : 0;
                }
                Console.WriteLine();
            }

            Console.WriteLine(totalVisible);
        }
    }
}