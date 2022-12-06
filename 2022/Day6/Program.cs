using System.Linq;

namespace Day6
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

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];

                List<char> buffer = new List<char>();

                for (int j = 0; j < line.Length; j++)
                {
                    char c = line[j];

                    for (int k = 0; k < buffer.Count; k++)
                    {
                        if (buffer[k] == c)
                        {
                            buffer.RemoveRange(0, k + 1);
                            break;
                        }
                    }

                    buffer.Add(c);

                    if (buffer.Count >= 14)
                    {
                        Console.WriteLine(j + 1);
                        break;
                    }
                }
            }
        }

        public static void Problem1()
        {
            string[] lines = File.ReadAllLines("input.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];

                List<char> buffer = new List<char>();

                for (int j = 0; j < line.Length; j++)
                {
                    char c = line[j];

                    for (int k = 0; k < buffer.Count; k++)
                    {
                        if (buffer[k] == c)
                        {
                            buffer.RemoveRange(0, k + 1);
                            break;
                        }
                    }

                    buffer.Add(c);

                    if (buffer.Count >= 4)
                    {
                        Console.WriteLine(j+1);
                        break;
                    }
                }
            }
        }
    }
}