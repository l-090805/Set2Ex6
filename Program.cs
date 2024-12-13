namespace Set2Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dimensiune vector: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Elemente vector: ");
            int[] v = new int[n];

            for(int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            bool crescator = true;
                
            for(int i = 0;i < v.Length - 1; i++)
            {
                if (v[i] > v[i+1])
                {
                    crescator = false;
                    break;
                }
            }
            Console.WriteLine($" este crescator? {crescator}");
        }
    }
}
