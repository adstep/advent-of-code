namespace Day4
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

            int count = 0;

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] parts = line.Split(',');
                string[] p0_components = parts[0].Split('-');
                string[] p1_components = parts[1].Split('-');

                int p0_lower = int.Parse(p0_components[0]);
                int p0_upper = int.Parse(p0_components[1]);
                int p1_lower = int.Parse(p1_components[0]);
                int p1_upper = int.Parse(p1_components[1]);

                Console.WriteLine($"{p0_lower} {p0_upper} {p1_lower} {p1_upper}");

                bool check0 = p0_lower >= p1_lower && p0_lower <= p1_upper;
                bool check1 = p0_upper >= p1_lower && p0_upper <= p1_upper;
                bool check2 = p1_lower >= p0_lower && p1_lower <= p0_upper;
                bool check3 = p1_upper >= p0_lower && p1_upper <= p0_upper;

                bool containedPair = check0 || check1 || check2 || check3;

                count += (containedPair) ? 1 : 0;
            }

            Console.WriteLine(count);
        }

        public static void Problem1()
        {
            string[] lines = File.ReadAllLines("input.txt");

            int count = 0;

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] parts = line.Split(',');
                string[] p0_components = parts[0].Split('-');
                string[] p1_components = parts[1].Split('-');

                int p0_lower = int.Parse(p0_components[0]);
                int p0_upper = int.Parse(p0_components[1]);
                int p1_lower = int.Parse(p1_components[0]);
                int p1_upper = int.Parse(p1_components[1]);

                Console.WriteLine($"{p0_lower} {p0_upper} {p1_lower} {p1_upper}");

                bool check1 = p0_lower >= p1_lower && p0_upper <= p1_upper;
                bool check2 = p1_lower >= p0_lower && p1_upper <= p0_upper;

                bool containedPair = check1 || check2;

                count += (containedPair) ? 1 : 0;
            }

            Console.WriteLine(count);
        }
    }
}