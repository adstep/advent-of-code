namespace Day5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Problem2();
        }

        public static void Problem2() 
        {
            string[] lines0 = File.ReadAllLines("input0.txt");
            string[] lines1 = File.ReadAllLines("input1.txt");

            int stackCount = lines0[0].Length;

            List<Stack<char>> stacks = new List<Stack<char>>();

            for (int i = 0; i < stackCount; i++)
            {
                stacks.Add(new Stack<char>());
            }

            for (int i = 0; i < lines0.Length; i++)
            {
                string line = lines0[lines0.Length - 1 - i];

                for (int j = 0; j < line.Length; j++)
                {
                    char c = line[j];

                    if (c == ' ')
                        continue;

                    stacks[j].Push(c);
                }
            }

            for (int i = 0; i < lines1.Length; i++)
            {
                string line = lines1[i];
                string[] parts = line.Split(' ');

                int count = int.Parse(parts[1]);
                int source = int.Parse(parts[3]) - 1;
                int target = int.Parse(parts[5]) - 1;

                Stack<char> stack = new Stack<char>();

                for (int j = 0; j < count; j++)
                {
                    stack.Push(stacks[source].Pop());
                }

                while (stack.Any())
                {
                    stacks[target].Push(stack.Pop());
                }
            }

            for (int i = 0; i < stacks.Count; i++)
            {
                Console.Write(stacks[i].Pop());
            }
        }

        public static void Problem1()
        {
            string[] lines0 = File.ReadAllLines("input0.txt");
            string[] lines1 = File.ReadAllLines("input1.txt");

            int stackCount = lines0[0].Length;

            List<Stack<char>> stacks = new List<Stack<char>>();

            for (int i = 0; i < stackCount; i++)
            {
                stacks.Add(new Stack<char>());
            }

            for (int i = 0; i < lines0.Length; i++)
            {
                string line = lines0[lines0.Length- 1 - i];

                for (int j = 0; j<line.Length; j++)
                {
                    char c = line[j];

                    if (c == ' ')
                        continue;

                    stacks[j].Push(c);
                }
            }

            for (int i = 0; i < lines1.Length; i++)
            {
                string line = lines1[i];
                string[] parts = line.Split(' ');

                int count = int.Parse(parts[1]);
                int source = int.Parse(parts[3])-1;
                int target = int.Parse(parts[5])-1;

                for (int j = 0; j < count; j++)
                {
                    stacks[target].Push(stacks[source].Pop());
                }
            }

            for (int i =0;i < stacks.Count; i++)
            {
                Console.Write(stacks[i].Pop());
            }
        }
    }
}