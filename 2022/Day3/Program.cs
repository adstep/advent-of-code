namespace Day3
{
    public class Program
    {
        public static void Main()
        {
            Problem2();
        }

        public static void Problem2()
        {
            string[] lines = File.ReadAllLines("input.txt");

            int totalScore = 0;

            for (int i = 0; i < lines.Length; i += 3)
            {
                Dictionary<char, int> badgeMap = new Dictionary<char, int>();

                for (int j = 0; j < 3; j++)
                {
                    string line = lines[i + j];

                    HashSet<char> c0 = new HashSet<char>();
                    HashSet<char> c1 = new HashSet<char>();

                    for (int k = 0; k < line.Length / 2; k++)
                    {
                        c0.Add(line[k]);
                        c1.Add(line[(line.Length / 2) + k]);
                    }

                    HashSet<char> r = new HashSet<char>(c0.Union(c1));

                    foreach (char v in r)
                    {
                        if (!badgeMap.ContainsKey(v))
                        {
                            badgeMap[v] = 0;
                        }

                        badgeMap[v]++;
                    }
                }

                int score = badgeMap.Where(kv => kv.Value == 3).Select(kv => Score(kv.Key)).First();
                totalScore += score;
            }

            Console.WriteLine(totalScore);
            Console.ReadKey();
        }

        public static void Problem1()
        {
            string[] lines = File.ReadAllLines("input.txt");

            int totalScore = 0;

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];

                HashSet<char> r0 = new HashSet<char>();
                HashSet<char> r1 = new HashSet<char>();

                for (int j = 0; j < line.Length / 2; j++)
                {
                    r0.Add(line[j]);
                    r1.Add(line[(line.Length / 2) + j]);
                }

                List<char> intersect = r0.Intersect(r1).ToList();
                int score = intersect.Select(Score).Sum();

                totalScore += score;
            }

            Console.WriteLine(totalScore);
            Console.ReadKey();
        }

        public static int Score(char c)
        {
            if (char.IsLower(c))
            {
                return 1 + (int)c - (int)'a';
            }
            else
            {
                return 27 + (int)c - (int)'A';
            }
        }
    }
}
