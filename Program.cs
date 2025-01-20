namespace Set2Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dimensiune vector: ");
            int n = int.Parse(Console.ReadLine());

            int element;
            int elementAnterior = int.MinValue;
            bool cresc = true;
            for (int i = 0; i < n; i++)
            {
                element = int.Parse(Console.ReadLine());
                if(i >= 0 && element <= elementAnterior)
                {
                    cresc = false;
                }
                elementAnterior = element;
            }
            if(cresc )
            {
                Console.WriteLine("Secventa crescatoare");
            }
            else
            {
                Console.WriteLine("Secventa nu este crescatoare");
            }
        }
    }
}
