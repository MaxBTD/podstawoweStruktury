namespace pakowaniePrezentów
{
    internal class Program
    {
        static private int dodaw(int a, int b)
        {
            return a + b;
        }

        static private string porow(int a, int b)
        {
            return a == b ? "Obie liczby są równe" : "Liczby nie są równe";
        }

        static private double srednia(int a, int b, int c)
        {
            return (a + b + c)/3;
        }

        static private string parzyst(int a)
        {
            return a % 2 == 0 ? $"Liczba {a} jest parzysta" : $"Liczba {a} jest nieparzysta";
        }

        static private int najwieksza(int a, int b, int c)
        {
            int[] tabLiczb = { a, b, c };
            return tabLiczb.Max();
        }

        static private int dodawOdDo(int n, int m)
        {
            int x;
            if (m < n)
            {
                x = m;
                m = n;
                n = x;
            }

            x = 0;
            for(int i = n; i <= m; i++)
            {
                x += i;
            }

            return x;
        }

        static private List<int> liczbPierwsze(int n)
        {
            List<int> x = new List<int>();
            if (n >= 2)
                x.Add(2);

            for (int i = 2; i <= n; i++)
            {

                for(int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                        break;
                    if(j == i-1 && i%j != 0)
                        x.Add(i);
                }
                
            }

            return x;
        }

        static private string palindrom(int liczba)
        {
            string odrwot = "";
            string liczbaString = liczba.ToString();
            for(int i = liczbaString.Length - 1; i >= 0; i--)
            {
                odrwot += liczbaString[i];
            }
            return odrwot == liczbaString ? $"Liczba {liczba} jest palindromem" : $"Liczba {liczba} nie jest palindromem";
        }

        static private List<double> pierwiastki(int a, int b, int c)
        {
            return new List<double>();
        }

        static void Main(string[] args)
        {
            List<int> x = liczbPierwsze(32);
            for(int i = 0; i < x.Count()-1; i++)
            {
                Console.WriteLine(x[i]);
            }
        }
    }
}
