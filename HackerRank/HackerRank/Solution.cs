using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace HackerRank
{
    class Solution
    {
        /*
        static void Main(string[] args)
        {
            int t;
            string s;
            s=Console.ReadLine();
            int.TryParse(s, out t);
            while(t>0)
            {
                Int64 n, q;
                string[] p= Console.ReadLine().Split();

                n = Int64.Parse(p[0]);
                q = Int64.Parse(p[1]);
                Int64[] arr = new Int64[n];

                Int64 i = 1, j = 0, a = 0, b = n - 1;

                while(a<=b)
                {
                    arr[a] = i;
                    arr[b] = j;
                    a++;
                    b--;
                    i += 2;
                    j += 2;
                }
                Console.WriteLine(arr[q]);
                t--;

            }
           

        } */


        /*       //DAY1
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";
            int j;
            double k;
            //string k;
            string w;
            j = Convert.ToInt32(Console.ReadLine());
            k = Convert.ToDouble(Console.ReadLine());
            //double.TryParse(k,out dle);

            w = Console.ReadLine();
            k = k + d;
            Console.WriteLine(i + j);
            Console.WriteLine("{0:0.0}",k);
            Console.WriteLine(s + w);

            Console.ReadLine();

        }  */




        /*           //Summation of elements of a array 
         *           https://www.hackerrank.com/challenges/simple-array-sum
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] tem = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(tem, Int32.Parse);
            int sum = 0;
            foreach (int item in arr)
            {
                sum += item;
            }

            Console.WriteLine(sum);
            Console.ReadLine();
        } */






        /* 
         * GOOD USE OF FOREACH (COMBINING TWO ARRAYS IN FOREACH)
         *  https://www.hackerrank.com/challenges/compare-the-triplets 
        static void Main(string[] args)
        {
        // int[] a = new int[3];
        //  int[] b = new int[3];


        // for (int i = 0; i < a.Length; i++){a[i] = int.Parse(Console.ReadLine());}
        // for (int i = 0; i < b.Length; i++){b[i] = int.Parse(Console.ReadLine());}




        string[] s = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(s, Int32.Parse);
        string[] s2 = Console.ReadLine().Split(' ');
        int[] b = Array.ConvertAll(s2, Int32.Parse);
        int Alice = 0, Bob = 0;

        foreach (var i in a.Zip(b, Tuple.Create))
        {
            if (i.Item1 > i.Item2)
                Alice++;
            else if (i.Item1 < i.Item2)
                Bob++;
        }


        Console.WriteLine("{0} {1}", Alice, Bob);
        Console.ReadLine();
        }
        */



        /*
         * https://www.hackerrank.com/challenges/a-very-big-sum

         static void Main(string[] args)
         {
             int n = Convert.ToInt32(Console.ReadLine());
             string[] s = Console.ReadLine().Split(' ');
             int[] arr = Array.ConvertAll(s, Int32.Parse);
             Int64 sum = 0;
             foreach (int item in arr)
             {
                 sum += item;
             }

             Console.WriteLine(sum);
         }

            */





        /*      //DAY2
                static void Main(string[] args)
                {
                    double mealCost;
                    mealCost = Convert.ToDouble(Console.ReadLine());
                    double tipPercent;
                    double taxPercent;
                    tipPercent = Convert.ToDouble(Console.ReadLine());
                    taxPercent = Convert.ToDouble(Console.ReadLine());
                    tipPercent = mealCost*(tipPercent / 100);
                    taxPercent = mealCost*(taxPercent / 100);
                    double totalCost;
                    totalCost = mealCost + tipPercent + taxPercent;
                    if (totalCost - Math.Floor(totalCost) > 0.5)
                    {
                        Console.WriteLine("The total meal cost is {0} dollars.",Math.Floor(totalCost) + 1);
                    }

                    else
                        Console.WriteLine("The total meal cost is {0} dollars.",Math.Floor(totalCost));

                    Console.ReadLine();
                }  */





        /*https://www.hackerrank.com/challenges/diagonal-difference
         * 2D ARRAY
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];
            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
            }

            int lsum = 0;
            for(int i=0,j=0;i<n;i++,j++)
            {
                lsum += a[i][j];
            }
            int rsum = 0;
            for (int i = 0, j = n-1; i < n; i++, j--)
            {
                rsum += a[i][j];
            }

            Console.WriteLine(Math.Abs(lsum - rsum));
        }

            */



        //https://www.hackerrank.com/contests/w28/challenges/lucky-number-eight
        /*
        static void Main(string[] args)
        {
            Int64 MOD = 1000000007;
            Int64 n = Convert.ToInt64(Console.ReadLine()); 
            string num = Console.ReadLine();
            Int64[] digits = num.ToString().ToCharArray().Select(x => (Int64)Char.GetNumericValue(x)).ToArray();

            Int64[,] dp = new Int64[n,8];
            for (int i = 0; i < 8; i++)
            {
                dp[0,i] = 0;
            }
            dp[0,digits[0] % 8] = 1;

            for (int i = 1 ; i <n; i++)
            {
                dp[i,digits[i] % 8] = 1;
                for (int j = 0; j < 8; j++)
                {
                    dp[i,(j * 10 + digits[i]) % 8] = (dp[i,(j * 10 + digits[i]) % 8] + dp[i - 1,j]) % MOD;
                    dp[i,j] = (dp[i,j] + dp[i - 1,j]) % MOD;
                }
            }

            Console.WriteLine(dp[n - 1, 0]);
            Console.ReadLine();
        } */


        /*

    static void Main(string[] args)
    {
        int queries = Convert.ToInt32(Console.ReadLine());
        string[] tokens = Console.ReadLine().Split(' ');

        int n = int.Parse(tokens[0]);
        int m = int.Parse(tokens[1]);
       // Console.WriteLine(m);
        Graph g = new Graph(n);
        int a, b;
        for (int i = 0; i < m; i++)
        {
            tokens = Console.ReadLine().Split(' ');
            a = int.Parse(tokens[0]);
            b = int.Parse(tokens[1]);
            g.AddEdge(a, b);
        }


        Console.Write("Breadth First Traversal from vertex 2:\n");
        g.BreadthFirstSearch(1);
        Console.ReadLine();
    }


}

class Graph
{
    private int _V;
   // private bool _directed;
    LinkedList<int>[] _adj;

    public Graph(int V)
    {
        _adj = new LinkedList<int>[V];

        for (int i = 0; i < _adj.Length; i++)
        {
            _adj[i] = new LinkedList<int>();
        }

        _V = V;
        //_directed = directed;
    }


    public void AddEdge(int v, int w)
    {
        _adj[v].AddLast(w);
        //_adj[w].AddLast(v);
    }

    public void BreadthFirstSearch(int s)
    {

        bool[] visited = new bool[_V];
        for (int i = 0; i < _V; i++)
            visited[i] = false;

        // Create a queue for BFS
        LinkedList<int> queue = new LinkedList<int>();

        visited[s] = true;
        queue.AddLast(s);

        while (queue.Any())
        {
            // Dequeue a vertex from queue and print it
            s = queue.First();
            Console.Write(s + " ");
            queue.RemoveFirst();

            LinkedList<int> list = _adj[s];

            foreach (var val in list)
            {
                if (!visited[val])
                {
                    visited[val] = true;
                    queue.AddLast(val);
                }
            }
        }
    } */


        //http://www.hackerrank.com/challenges/30-arrays
        /*
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            Array.Reverse(arr);
            Console.WriteLine(string.Join(" ", arr));
        }*/

    }
}
